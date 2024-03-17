using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using Project_Group3.Service;
using WebLibrary.DAO;
using WebLibrary.Models;
using WebLibrary.Repository;
namespace Project_Group3.Controllers
{
    // [Authorize]

    public class PaymentController : Controller
    {
        public static bool hasPaid = false;
        private readonly IVnpayService _vnpayService;
        ICourseRepository coureseRepository = null;
        ILearnerRepository learnerRepository = null;
        IEnrollmentRepository enrollmentRepository = null;
        PaymentViewModel paymentViewModel = null;
        ISmtpRepository smtpRepository = null;
        IVoucherRepository voucherRepository = null;

        // ILearnerRepository ilearner = null;

        public PaymentController(IVnpayService vnpayService)
        {
            _vnpayService = vnpayService;
            coureseRepository = new CourseRepository();
            learnerRepository = new LearnerRepository();
            enrollmentRepository = new EnrollmentRepository();
            smtpRepository = new StmpRepository();
            voucherRepository = new VoucherRepository();
        }



        // [Authorize]
        public IActionResult PaymentFail()
        {
            // TODO: Your code here
            return View();
        }
        // [Authorize]




        // [Authorize]

        public IActionResult PaymentCallback()
        {
            
            int? learnerId = HttpContext.Session.GetInt32("learnerId");
            int? courseId = HttpContext.Session.GetInt32("courseId");
            Learner learner = learnerRepository.GetLearnerByID((int)learnerId);
            Course course = coureseRepository.GetCourseByID((int)courseId);
            var response = _vnpayService.PaymentExcute(Request.Query);

            if (response == null)
            {
                System.Console.WriteLine("faillllllllllllllll do null"); ;
                return RedirectToAction("PaymentFail");

            }
            EnrollmentDAO en = new EnrollmentDAO();

            en.AddNew((int)learnerId, (int)courseId);
            System.Console.WriteLine(learnerId + courseId);

            smtpRepository.sendMail(learner.Email, "You have successfully enrolled in the course", "Thank you for registering for the " + course.CourseName + " course." + " I wish you an enjoyable learning experience.");

            return RedirectToAction("CourseDetail", "Home", new { id = courseId });
        }


        [HttpGet]
        public IActionResult Index(int learnerId, int courseId)
        {
            Course c = coureseRepository.GetCourseByID(courseId);
            Learner l = learnerRepository.GetLearnerByID(learnerId);
            Console.WriteLine("Learner" + learnerId + " Course" + courseId);
            if (l == null || c == null)
            {
                return NotFound(); // Trả về lỗi 404 nếu không tìm thấy người học hoặc khóa học
            }
            HttpContext.Session.SetInt32("learnerId", learnerId);
            HttpContext.Session.SetInt32("courseId", courseId);

            paymentViewModel = new PaymentViewModel
            {
                courseId = c.CourseId,
                LeanrerId = l.LearnerId,
                courseName = c.CourseName,
                learnerName = l.FirstName + " " + l.LastName,
                Price = c.Price,
                Email = l.Email,
                enrollmentDate = DateTime.Now,
                status = "false"
            };

            return View(paymentViewModel);
        }

        [HttpPost]
        public IActionResult CheckOut(PaymentViewModel paymentViewModel)
        {
            string voucher = paymentViewModel.voucher;
            var learnerID =paymentViewModel.LeanrerId;
            System.Console.WriteLine(voucher);      
             System.Console.WriteLine(learnerID);

            if (string.IsNullOrEmpty(voucher))
            {
                var VnpayModel = new VnPaymentRequestModel
                {
                    Amount = (int)paymentViewModel.Price * 1000,
                    CreateDate = DateTime.Now,
                    Description = paymentViewModel.courseName,
                    Fullname = paymentViewModel.learnerName,
                    OrderId = new Random().Next(1000, 100000)
                };
                System.Console.WriteLine("null voucher");
                // Không có voucher được nhập
                return Redirect(_vnpayService.CreatePaymentUrl(HttpContext, VnpayModel));
            }
            else
            {
                var v = voucherRepository.GetVoucherByCode(voucher);
                bool isVoucherUsed = VoucherUsageDAO.Instance.IsVoucherUsedByUser(voucher, learnerID);
                if (isVoucherUsed == false)
                {
                    ModelState.AddModelError("", "You have already used this voucher");
                    System.Console.WriteLine("loi isused");
                    return RedirectToAction("PaymentFail");
                }
                if (v == null)
                {
                    ModelState.AddModelError("", "Invalid voucher"); // Thêm lỗi vào ModelState
                    return RedirectToAction("PaymentFail");// Trả về view với model và hiển thị lỗi
                }
                else
                {
                    if (DateTime.Now - v.StartAt >= v.EndAt - v.StartAt)
                    {
                        return RedirectToAction("PaymentFail");
                    }
                        VoucherUsageDAO.Instance.SaveVoucherUsage(voucher,paymentViewModel.LeanrerId);
                    var VnpayModel = new VnPaymentRequestModel
                    {
                        Amount = ((int)paymentViewModel.Price * 1000) - ((int)paymentViewModel.Price * 1000 * v.PercentDiscount / 100),

                        CreateDate = DateTime.Now,
                        Description = paymentViewModel.courseName,
                        Fullname = paymentViewModel.learnerName,
                        OrderId = new Random().Next(1000, 100000)
                    };

                    return Redirect(_vnpayService.CreatePaymentUrl(HttpContext, VnpayModel));
                }
            }
        }


    }


}
