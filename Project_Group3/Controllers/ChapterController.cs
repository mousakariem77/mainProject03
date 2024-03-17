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

    public class ChapterController : Controller
    {

        IChapterRepository chapterRepository = null;
        ICourseRepository courseRepository = null;
        ICategoryRepository categoryRepository = null;
        ILessonRepository lessonRepository = null;
        IInstructorRepository instructorRepository = null;
        public ChapterController()
        {
            courseRepository = new CourseRepository();
            categoryRepository = new CategoryRepository();
            chapterRepository = new ChapterRepository();
            lessonRepository = new LessonRepository();
            instructorRepository = new InstructorRepository();

        }

        public ActionResult Index(int courseId, string search = "")
        {
            try
            {
                ViewBag.CourseId = courseId;

                var course = courseRepository.GetCourseByID(courseId);
                if (course == null) return NotFound();

                ViewBag.CourseName = course.CourseName;

                var chapterList = chapterRepository.GetChapters();

                var chaptersToDisplay = chapterList.Where(c => c.CourseId == courseId);

                if (!string.IsNullOrEmpty(search))
                {
                    chaptersToDisplay = chaptersToDisplay.Where(c => c.ChapterName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0);
                }

                var modelsView = new ModelsView
                {
                    ChaptersList = chaptersToDisplay.ToList(),
                    LessonsList = lessonRepository.GetLessons().ToList(),
                };

                ViewBag.Search = search;

                return View(modelsView);
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while processing your request.";
                return View();
            }
        }


        public ActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            var Chapter = chapterRepository.GetChapterByID(id.Value);

            if (Chapter == null) return NotFound();

            return View(Chapter);
        }

        public ActionResult Create(int courseId)
        {
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.CourseId = courseId;
            if (course == null)
            {
                ViewBag.CourseId = courseId;
                ViewBag.CourseName = "Unknown Course";
            }
            else
            {
                ViewBag.CourseId = courseId;
                if (string.IsNullOrEmpty(course.CourseName))
                {
                    ViewBag.CourseName = "Unknown Course";
                }
                else
                {
                    ViewBag.CourseName = course.CourseName;
                }
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chapter chapter, bool redirectToCreateLesson, int courseId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Kiểm tra điều kiện cho thuộc tính ChapterName
                    if (!string.IsNullOrEmpty(chapter.ChapterName))
                    {
                        // Kiểm tra điều kiện cho thuộc tính Index
                        if (chapter.Index.HasValue && chapter.Index.Value > 0)
                        {
                            // Kiểm tra điều kiện cho thuộc tính Description
                            if (!string.IsNullOrEmpty(chapter.Description))
                            {
                                // Kiểm tra điều kiện cho thuộc tính TotalTime
                                if (chapter.TotalTime.HasValue && chapter.TotalTime.Value > 0)
                                {
                                    chapterRepository.InsertChapter(chapter);

                                    if (redirectToCreateLesson)
                                    {
                                        return RedirectToAction("Create", "Lesson", new { chapterId = chapter.ChapterId, courseId = chapter.CourseId });
                                    }
                                    else
                                    {
                                        return RedirectToAction("Index", new { courseId = chapter.CourseId });
                                    }
                                }
                                else
                                {
                                    ModelState.AddModelError("TotalTime", "TotalTime must be a positive value.");
                                }
                            }
                            else
                            {
                                ModelState.AddModelError("Description", "Description is required.");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("Index", "Index must be a positive value.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("ChapterName", "ChapterName is required.");
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }

            ViewBag.CourseId = courseId;
            var course = courseRepository.GetCourseByID(courseId);
            ViewBag.CourseName = course.CourseName;
            return View(chapter);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var Chapter = chapterRepository.GetChapterByID(id.Value);

            if (Chapter == null) return NotFound();

            ModelsView modelsView = new ModelsView { Chapter = Chapter };

            return View(modelsView);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModelsView modelsView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var chapter = chapterRepository.GetChapterByID(modelsView.Chapter.ChapterId);

                    if (chapter != null)
                    {
                        chapterRepository.UpdateChapter(modelsView.Chapter);
                        return RedirectToAction("Index", new { courseId = chapter.CourseId });
                    }
                    else
                    {
                        ViewBag.Message = "Chapter not found.";
                        return View(modelsView);
                    }
                }
                else
                {
                    ViewBag.Message = "Model state is invalid.";
                    return View(modelsView);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }


        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var Chapter = chapterRepository.GetChapterByID(id.Value);

            if (Chapter == null) return NotFound();

            return View(new ModelsView { Chapter = Chapter });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ModelsView modelsView)
        {
            try
            {
                var chapter = chapterRepository.GetChapterByID(modelsView.Chapter.ChapterId);
                System.Console.WriteLine(chapter.ChapterId);
                if (chapter != null)
                {
                    chapterRepository.DeleteChapter(chapter.ChapterId);
                    return RedirectToAction("Index", new { courseId = modelsView.Chapter.CourseId });
                }
                return View(modelsView);
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View();
            }

        }
    }
}