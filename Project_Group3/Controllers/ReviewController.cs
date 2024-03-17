using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebLibrary.Models;
using WebLibrary.Repository;
using WebLibrary.DAO;

namespace Project_Group3.Controllers
{
    public class ReviewController : Controller
    {
        ReviewRepository reviewRepository = null;
        public ReviewController() => reviewRepository = new ReviewRepository();

        public ActionResult Index()
        {
            var Reviewlist = reviewRepository.GetReviews();
            return View(Reviewlist);
        }
        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Review= reviewRepository.GetReviewByID(id.Value);
            if (Review== null)
            {
                return NotFound();

            }
            return View(Review);
        }

        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Review Review)
        {
            var cookieValue = Request.Cookies["ID"];
            var courseID = Review.CourseId;
            try
            {
                if (ModelState.IsValid)
                {
                    Review.LearnerId = int.Parse(cookieValue);
                    Review.ReviewDate = DateTime.Now;
                     int? rating = Review.Rating;

                    reviewRepository.InsertReview(Review);
                    ViewBag.SuccessMessage = "Đánh giá đã được gửi thành công.";
                    // Hoặc có thể chuyển hướng đến một trang thành công
                    return RedirectToAction("CourseDetail", "Home", new { id = courseID });
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Đã xảy ra lỗi: " + ex.Message;
            }

            // Nếu có lỗi xảy ra hoặc dữ liệu không hợp lệ, hiển thị lại form
            return View(Review);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Review= reviewRepository.GetReviewByID(id.Value);
            if (Review== null)
            {
                return NotFound();
            }
            return View(Review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Review review)
        {
            try
            {
                if (id != review.ReviewId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    reviewRepository.UpdateReview(review);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();

            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Review = reviewRepository.GetReviewByID(id.Value);
            if (Review == null)
            {
                return NotFound();
            }
            return View(Review);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                reviewRepository.DeleteReview(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View();
            }

        }
    }
}