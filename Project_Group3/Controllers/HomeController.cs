using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using WebLibrary.DAO;
using WebLibrary.Models;
using WebLibrary.Repository;

namespace Project_Group3.Controllers
{
    public class HomeController : Controller
    {
        IInstructorRepository instructorRepository = null;
        ICourseRepository courseRepository = null;
        ICategoryRepository categoryRepository = null;
        IInstructRepository instructRepository = null;
        ILearnerRepository learnerRepository = null;
        IReviewRepository reviewRepository = null;
        ILessonRepository lessonRepository = null;
        IChapterRepository chapterRepository = null;
        IEnrollmentRepository enrollmentRepository = null;
        IReportRepository reportRepository = null;
        ISmtpRepository smtpRepository = null;
        
        public HomeController()
        {
            courseRepository = new CourseRepository();
            categoryRepository = new CategoryRepository();
            instructorRepository = new InstructorRepository();
            instructRepository = new InstructRepository();
            learnerRepository = new LearnerRepository();
            reviewRepository = new ReviewRepository();
            lessonRepository = new LessonRepository();
            chapterRepository = new ChapterRepository();
            enrollmentRepository = new EnrollmentRepository();
            reportRepository = new ReportRepository();
            smtpRepository = new StmpRepository();
        }


        public IActionResult Index()
        {
            var categoryList = categoryRepository.GetCategorys()
                .OrderByDescending(c => c.Courses.Count)
                .Take(8)
                .ToList();

            var instructorList = instructorRepository.GetInstructors()
                .Take(4)
                .ToList();

            return View(Tuple.Create(categoryList, instructorList));
        }

        public IActionResult About()
        {
            // TODO: Your code here
            return View();
        }

        public IActionResult Course(string search)
        {
            var course = courseRepository.GetCourses();
            var category = categoryRepository.GetCategorys();
            var instruct = instructRepository.GetInstructs();
            var instructor = instructorRepository.GetInstructors();
            var review = reviewRepository.GetReviews();
            var courseList = course.ToList();
            var categoryList = category.ToList();
            var instructList = instruct.ToList();
            var instructorList = instructor.ToList();
            var reviewList = review.ToList();

            if (!string.IsNullOrEmpty(search))
            {
                string lowercaseSearch = search.ToLower();
                courseList = courseList.Where(c => c.CourseName.ToLower().Contains(lowercaseSearch)).ToList();
                ViewBag.search = search;
            }

            return View(Tuple.Create(courseList, categoryList, instructList, instructorList, reviewList));
        }

        public IActionResult Contact()
        {
            // TODO: Your code here
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Report report)
        {
            if (ModelState.IsValid)
            {
                report.SubmittedTime = DateTime.Now;
                reportRepository.AddNew(report);
                smtpRepository.sendMail("huynhnguyenbao3105@gmail.com", report.Title, "My name is " + report.Name + ". My Email is: " + report.Email + " I wanna say " + report.Content);

                return View();
            }
            return View();
        }

        public IActionResult InstructorProfile(int? id)
        {
            if (id == null) return NotFound();

            Instructor instructor = instructorRepository.GetInstructorByID(id.Value);

            if (instructor == null) return NotFound();

            ViewBag.Role = "instructor";

            ModelsView modelsView = new ModelsView
            {
                Instructor = instructor,
            };

            return View(modelsView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult InstructorProfile(int id, ModelsView models)
        {
            try
            {

                if (id != models.Instructor.InstructorId)
                {
                    System.Console.WriteLine(id + " " + models.Instructor.InstructorId);
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    instructorRepository.UpdateInstructor(models.Instructor);
                }
                return RedirectToAction("InstructorProfile", "Home", new { id = models.Instructor.InstructorId });
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public IActionResult LearnerProfile(int? id)
        {
            var enrollment = enrollmentRepository.GetEnrollment();

            if (id == null) return NotFound();

            Learner learner = learnerRepository.GetLearnerByID(id.Value);

            if (learner == null) return NotFound();

            ViewBag.Role = "learner";

            ModelsView modelsView = new ModelsView
            {
                Learner = learner,
                EnrollmentList = enrollment.ToList(),
            };

            return View(modelsView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LearnerProfile(int id, ModelsView models)
        {
            try
            {

                if (id != models.Learner.LearnerId)
                {
                    System.Console.WriteLine(id + " " + models.Learner.LearnerId);
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    learnerRepository.UpdateLearner(models.Learner);
                }
                return RedirectToAction("LearnerProfile", "Home", new { id = models.Learner.LearnerId });
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAccountLearner(Learner learner)
        {
            try
            {
                var i = learnerRepository.GetLearnerByID(learner.LearnerId);
                if (ModelState.IsValid)
                {
                    learner.FirstName = i.FirstName;
                    learner.LastName = i.LastName;
                    learner.Gender = i.Gender;
                    learner.Birthday = i.Birthday;
                    learner.PhoneNumber = i.PhoneNumber;
                    learner.Email = i.Email;
                    learner.Country = i.Country;
                    learner.Username = i.Username;
                    learner.Password = i.Password;
                    learner.Picture = i.Picture;
                    learner.RegistrationDate = i.RegistrationDate;
                    learner.Status = "Delete";
                    learnerRepository.UpdateLearner(learner);
                }
                foreach (var cookie in HttpContext.Request.Cookies.Keys)
                {
                    Response.Cookies.Delete(cookie);
                }

                HttpContext.Session.Clear();

                return RedirectToAction("Login", "User");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteAccountInstructor(Instructor instructor)
        {
            try
            {
                var i = instructorRepository.GetInstructorByID(instructor.InstructorId);
                if (ModelState.IsValid)
                {
                    instructor.FirstName = i.FirstName;
                    instructor.LastName = i.LastName;
                    instructor.Gender = i.Gender;
                    instructor.Birthday = i.Birthday;
                    instructor.PhoneNumber = i.PhoneNumber;
                    instructor.Email = i.Email;
                    instructor.Country = i.Country;
                    instructor.Username = i.Username;
                    instructor.Password = i.Password;
                    instructor.Picture = i.Picture;
                    instructor.Income = i.Income;
                    instructor.Introduce = i.Introduce;
                    instructor.RegistrationDate = i.RegistrationDate;
                    instructor.Status = "Delete";
                    instructorRepository.UpdateInstructor(instructor);
                }
                foreach (var cookie in HttpContext.Request.Cookies.Keys)
                {
                    Response.Cookies.Delete(cookie);
                }

                HttpContext.Session.Clear();

                return RedirectToAction("Login", "User");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                var learner = learnerRepository.GetLearnerByID(id);
                if (learner == null)
                {
                    return NotFound();
                }

                learner.Status = "Delete";
                learnerRepository.UpdateLearner(learner);

                return RedirectToAction("Instructor", "Admin");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public IActionResult CourseDetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var instruct = instructRepository.GetInstructByID(id.Value);
            if (instruct == null)
            {
                return NotFound();
            }
            var courseId = TempData["CourseId"] as string;
            var course = courseRepository.GetCourses();
            var instructor = instructorRepository.GetInstructors();
            var review = reviewRepository.GetReviews();
            var learner = learnerRepository.GetLearners();
            var chapter = chapterRepository.GetChapters();
            var lesson = lessonRepository.GetLessons();
            var enrollment = enrollmentRepository.GetEnrollment();

            var courseInfo = course.FirstOrDefault(c => c.CourseId == instruct.CourseId);
            var instructorInfo = instructor.FirstOrDefault(i => i.InstructorId == instruct.InstructorId);
            ViewBag.CourseID = id;
            return View(Tuple.Create(courseInfo, instructorInfo, review, learner, chapter, lesson, enrollment));
        }

        public IActionResult Learning(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course = courseRepository.GetCourseByID(id.Value);
            if (course == null)
            {
                return NotFound();
            }

            var chapter = chapterRepository.GetChapters();
            var lesson = lessonRepository.GetLessons();
            return View(Tuple.Create(course, chapter, lesson));
        }

        public IActionResult CheckOut(int? id)
        {
            var learner = learnerRepository.GetLearnerByID(id.Value);

            return View(learner);
        }

        public IActionResult QA()
        {
            // TODO: Your code here
            return View();
        }
        

    }
}
