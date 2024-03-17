using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebLibrary.Repository;
using WebLibrary.Models;
using WebLibrary.DAO;
using Microsoft.AspNetCore.Http;
using Project_Group3.Models;
using Microsoft.AspNetCore.Identity;

namespace Project_Group3.Controllers
{
    public class UserController : Controller
    {
        InstructorRepository instructorRepository = null;
        ILearnerRepository learnerRepository = null;
        IAdminRepository adminRepository = null;
        ISmtpRepository smtpRepository = null;
        private string tmpEmail;
        public UserController()
        {
            learnerRepository = new LearnerRepository();
            instructorRepository = new InstructorRepository();
            adminRepository = new AdminRepository();
            smtpRepository = new StmpRepository();
        }

        public IActionResult Login()
        {
            int? insSession = HttpContext.Session.GetInt32("InsID");
            int? learnerSession = HttpContext.Session.GetInt32("LearnerID");

            Console.WriteLine($"InsID: {insSession}, LearnerID: {learnerSession}");

            if (insSession != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else if (learnerSession != null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }


        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                var instructor = instructorRepository.GetInstructorByEmailOrUser(model.EmailOrUsername);
                var learner = learnerRepository.GetLearnerByEmailOrUser(model.EmailOrUsername);
                // var admin = adminRepository.GetAdminByUsername(model.EmailOrUsername);


                if (instructor != null && instructor.Password == model.Password)
                {
                    // HttpContext.Session.SetString("UserRole", "Instructor");
                    // HttpContext.Session.SetInt32("InsID", instructor.InstructorId);
                    // Response.Cookies.Append("MyCookie", instructor.InstructorId.ToString());
                    if(instructor.Status == "Wait"){
                        ViewBag.err = "The account has not been moderated!!!";
                        return View();
                    }else if(instructor.Status == "Delete"){
                        ViewBag.err = "The account no longer exists!!!";
                        return View();
                    }
                    Response.Cookies.Append("Role", "instructor");
                    Response.Cookies.Append("Name", instructor.Username);
                    Response.Cookies.Append("ID", instructor.InstructorId.ToString());
                    return RedirectToAction("Index", "Home");

                }
                else if (learner != null && learner.Password == model.Password)
                {
                    // HttpContext.Session.SetString("UserRole", "Learner");
                    Response.Cookies.Append("Role", "learner");
                    HttpContext.Session.SetInt32("LearnerID", learner.LearnerId);
                    Console.WriteLine($"LearnerID: {HttpContext.Session.GetInt32("LearnerID")}");
                    // Response.Cookies.Append("MyCookie", learner.LearnerId.ToString());
                    Response.Cookies.Append("Name", learner.Username);
                    Response.Cookies.Append("ID", learner.LearnerId.ToString());
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.err = "Email, user or password incorrectly please enter again!.";
                    return View(model);
                }
            }
            catch
            {
                ViewBag.err = "Lỗi đăng nhập!";
                return View();
            }
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                // Kiểm tra tuổi
                DateTime currentDate = DateTime.Now;
                DateTime minimumBirthDate = currentDate.AddYears(-18); // Ngày sinh tối thiểu để đủ 18 tuổi

                if (model.Birthday >= minimumBirthDate)
                {
                    ViewBag.err = "Your year of birth is not old enough to register";
                    return View(model);
                }

                var LearnerModel = new Learner
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender = model.Gender,
                    Birthday = model.Birthday,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Country = model.Country,
                    Username = model.Username,
                    Password = model.Password,
                    Picture = model.Picture,
                    RegistrationDate = DateTime.Now.Date,
                    Status = "Active",
                };
                learnerRepository.InsertLearner(LearnerModel);
                ViewBag.UserId = LearnerModel.LearnerId.ToString();
                ViewBag.Role = "Learner";
                Response.Cookies.Append("MyCookie", LearnerModel.LearnerId.ToString());
                // Điều hướng đến trang chính sau khi đăng ký thành công
                return RedirectToAction("Login", "User", new { id = LearnerModel.LearnerId, role = "Learner" });
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                ViewBag.err = "Đã xảy ra lỗi khi đăng ký: " + ex.Message;
                return View(model);
            }
        }

        public IActionResult InstructorRegister()
        {
            // TODO: Your code here
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InstructorRegister(RegisterViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                if (string.IsNullOrEmpty(model.Introduce))
                {
                    ModelState.AddModelError("InstructorField", "Vui lòng nhập thông tin Instructor");
                    return View(model);
                }

                // Kiểm tra tuổi
                DateTime currentDate = DateTime.Now;
                DateTime minimumBirthDate = currentDate.AddYears(-21); // Ngày sinh tối thiểu để đủ 21 tuổi

                if (model.Birthday >= minimumBirthDate)
                {
                    ViewBag.err = "Your year of birth is not old enough to register";
                    return View(model);
                }

                var instructorModel = new Instructor
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Gender = model.Gender,
                    Birthday = model.Birthday,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Country = model.Country,
                    Username = model.Username,
                    Password = model.Password,
                    Picture = model.Picture,
                    RegistrationDate = DateTime.Now.Date,
                    Income = 0,
                    Introduce = model.Introduce,
                    Status = "Wait",
                };

                instructorRepository.InsertInstructor(instructorModel);
                ViewBag.UserId = instructorModel.InstructorId;
                ViewBag.Role = "Learner";
                Response.Cookies.Append("MyCookie", instructorModel.InstructorId.ToString());
                // Điều hướng đến trang chính sau khi đăng ký thành công
                return RedirectToAction("Login", "User", new { id = instructorModel.InstructorId, role = "Instructor" });
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                ViewBag.err = "Đã xảy ra lỗi khi đăng ký: " + ex.Message;
                return View(model);
            }
        }

        public IActionResult Logout()
        {
            // Xóa cookie
            foreach (var cookie in HttpContext.Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }

            // Xóa session
            HttpContext.Session.Clear(); // Hoặc HttpContext.Session.Remove("UserId");

            // Chuyển hướng đến trang login hoặc trang chính
            return RedirectToAction("Login", "User");
        }

        public int Random()
        {
            Random random = new Random();
            int otp = random.Next(10000, 99999);

            HttpContext.Session.SetInt32("otp", otp);
            return otp;
        }

        public IActionResult ResetPassword()
        {
            // TODO: Your code here
            return View();
        }
        
        public IActionResult otp(string email)
        {
            int random = Random();

            System.Console.WriteLine(random);

            string tmpEmail = HttpContext.Session.GetString("email");

            if (!string.IsNullOrEmpty(tmpEmail)) smtpRepository.sendMail(tmpEmail, "Mã xác thực OTP", $"Mã xác thực OTP của bạn là: [{random}], tuyệt đối không chia sẻ mã này cho người khác!");

            else return RedirectToAction("CheckEmail");

            return View(email);
        }


        [HttpPost]
        public IActionResult otp(int otp, int otp1, int otp2, int otp3, int otp4)
        {
            int otpValue = otp * 10000 + otp1 * 1000 + otp2 * 100 + otp3 * 10 + otp4;

            if (HttpContext.Session.GetInt32("otp") == otpValue) return View("ResetPassword");

            return View();
        }

        public IActionResult CheckEmail() => View();


        [HttpPost]
        public IActionResult CheckEmail(string email)
        {
            try
            {
                var learner = learnerRepository.GetLearnerByEmail(email);
                var instructor = instructorRepository.GetInstructorByEmail(email);

                string UserMail = learner?.Email ?? instructor?.Email ?? "";

                if (UserMail == null) return View();

                HttpContext.Session.SetString("email", UserMail);

                return RedirectToAction("otp");

            }
            catch (System.Exception)
            {
                return View(email);
            }
        }

        [HttpPost]
        public IActionResult ResetPassword(string password, string confirmPassword)
        {
            try
            {
                if (password != confirmPassword) return View(ViewBag.err = "Mk Không khớp");

                string email = HttpContext.Session.GetString("email");

                if (email != null)
                {
                    var learner = learnerRepository.GetLearnerByEmail(email);
                    var instructor = instructorRepository.GetInstructorByEmail(email);
                    if (learner != null)
                    {
                        learnerRepository.UpdatePass(learner.LearnerId, password);
                    }

                    if (instructor != null)
                    {
                        instructorRepository.UpdatePass(instructor.InstructorId, password);
                    }
                }
                return RedirectToAction("Login");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        [HttpPost]
        public IActionResult ChangePassword(string email, string password, string newPassword, string confirmPassword)
        {
            try
            {

                if (newPassword != confirmPassword) return View();

                if (email != null)
                {
                    var learner = learnerRepository.GetLearnerByEmail(email);
                    var instructor = instructorRepository.GetInstructorByEmail(email);
                    if (learner != null)
                    {
                        learnerRepository.UpdatePass(learner.LearnerId, newPassword);
                    }

                    if (instructor != null)
                    {
                        instructorRepository.UpdatePass(instructor.InstructorId, newPassword);
                    }
                }
                
                foreach (var cookie in HttpContext.Request.Cookies.Keys)
                {
                    Response.Cookies.Delete(cookie);
                }

                // Xóa session
                HttpContext.Session.Clear(); // Hoặc HttpContext.Session.Remove("UserId");

                // Chuyển hướng đến trang login hoặc trang chính
                return RedirectToAction("Login", "User");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}