using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            // Dosya adın Index olduğu için buraya açıkça yazdım
            return View("Index", values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTestimonial([FromForm] Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            if (value != null)
            {
                context.Testimonials.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial([FromForm] Testimonial testimonial)
        {
            var value = context.Testimonials.Find(testimonial.TestimonialId);
            if (value != null)
            {
                value.NameSurname = testimonial.NameSurname;
                value.Title = testimonial.Title;
                value.Description = testimonial.Description;
                value.ImageUrl = testimonial.ImageUrl;
                context.SaveChanges();
            }
            return RedirectToAction("TestimonialList");
        }
    }
}