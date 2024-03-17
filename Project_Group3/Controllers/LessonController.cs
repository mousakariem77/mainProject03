using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using WebLibrary.Models;
using WebLibrary.Repository;
namespace Project_Group3.Controllers
{

    public class LessonController : Controller
    {

        ILessonRepository lessonRepository = null;
        IChapterRepository chapterRepository = null;
        ICourseRepository courseRepository = null;
        public LessonController()
        {
            lessonRepository = new LessonRepository();
            chapterRepository = new ChapterRepository();
            courseRepository = new CourseRepository();
        }


        public ActionResult Index(int chapterId, int courseId, string search = "")
        {

            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.CourseId = courseId;
            ViewBag.ChapterId = chapterId;

            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;

            var lessonList = lessonRepository.GetLessons();

            // Tìm tất cả các chương có CourseId trùng khớp với courseId
            var lessonsToDisplay = lessonList.Where(l => l.ChapterId == chapterId && l.CourseId == courseId).ToList();

            if (!string.IsNullOrEmpty(search))
            {
                lessonsToDisplay = lessonsToDisplay.Where(l => l.LessonName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            }
            ViewBag.Search = search;

            // Trả về view, truyền danh sách chương để hiển thị
            return View(lessonsToDisplay);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Lesson = lessonRepository.GetLessonByID(id.Value);
            if (Lesson == null)
            {
                return NotFound();

            }
            return View(Lesson);
        }
        //Get Learnercontroller/Create  
        public ActionResult Create(int chapterId, int courseId)
        {
            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;

            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Lesson lesson, int chapterId, int courseId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Kiểm tra điều kiện cho thuộc tính LessonName
                    if (!string.IsNullOrEmpty(lesson.LessonName))
                    {
                        // Kiểm tra điều kiện cho thuộc tính Description
                        if (!string.IsNullOrEmpty(lesson.Description))
                        {
                            // Kiểm tra điều kiện cho thuộc tính PercentToPassed
                            if (lesson.PercentToPassed.HasValue && lesson.PercentToPassed.Value >= 0 && lesson.PercentToPassed.Value <= 100)
                            {

                                // Kiểm tra điều kiện cho thuộc tính Content
                                if (!string.IsNullOrEmpty(lesson.Content))
                                {
                                    // Kiểm tra điều kiện cho thuộc tính Index
                                    if (lesson.Index.HasValue && lesson.Index.Value > 0)
                                    {
                                        // Kiểm tra điều kiện cho thuộc tính Time
                                        if (lesson.Time.HasValue && lesson.Time.Value > 0)
                                        {
                                            lessonRepository.InsertLesson(lesson);
                                            return RedirectToAction("Index", new { chapterId = chapterId, courseId = courseId });
                                        }
                                        else
                                        {
                                            ModelState.AddModelError("Time", "Time must be a positive value.");
                                        }
                                    }
                                    else
                                    {
                                        ModelState.AddModelError("Index", "Index must be a positive value.");
                                    }
                                }
                                else
                                {
                                    ModelState.AddModelError("Content", "Content is required.");
                                }
                            }
                            else
                            {
                                ModelState.AddModelError("PercentToPassed", "PercentToPassed must ,be a value between 0 and 100.");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Description", "Description is required.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("LessonName", "LessonName is required.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                ViewBag.Message = ex.Message;
            }
            var chapter = chapterRepository.GetChapterByID(chapterId);
            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;
            ViewBag.ChapterName = chapter.ChapterName;
            return View(lesson);
        }


        public ActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var Lesson = lessonRepository.GetLessonByID(id.Value);

            if (Lesson == null) return NotFound();

            return View(new ModelsView { Lesson = Lesson });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModelsView modelsView)
        {
            try
            {
                var lesson = lessonRepository.GetLessonByID(modelsView.Lesson.LessonId);
                if (lesson != null)
                {
                    lessonRepository.UpdateLesson(modelsView.Lesson);
                    return RedirectToAction("Index", new { chapterId = lesson.ChapterId, courseId = lesson.CourseId });
                }
                return View(modelsView);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(modelsView);

            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var Lesson = lessonRepository.GetLessonByID(id.Value);

            if (Lesson == null) return NotFound();

            return View(new ModelsView { Lesson = Lesson });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ModelsView modelsView)
        {
            try
            {
                var lesson = lessonRepository.GetLessonByID(modelsView.Lesson.LessonId);
                if (lesson != null)
                {
                    lessonRepository.DeleteLesson(lesson.LessonId);
                    return RedirectToAction("Index", new { chapterId = lesson.ChapterId, courseId = lesson.CourseId });
                }
                return View(modelsView);
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View(modelsView);
            }

        }
    }
}