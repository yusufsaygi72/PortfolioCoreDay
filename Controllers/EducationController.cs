using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class EducationController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Educations.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateEducation([FromForm] Education education)
        {
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEducation(int id)
        {
            var value = context.Educations.Find(id);
            if (value != null)
            {
                context.Educations.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var value = context.Educations.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateEducation([FromForm] Education education)
        {
            var value = context.Educations.Find(education.EducationId);
            if (value != null)
            {
                value.Title = education.Title;
                value.Universty = education.Universty;
                value.Department = education.Department;
                value.EducationDate = education.EducationDate;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}