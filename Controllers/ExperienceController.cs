using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            if (value != null)
            {
                context.Experiences.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("ExperienceList");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience([FromForm] Experience experience)
        {
            var value = context.Experiences.Find(experience.ExperienceId);
            if (value != null)
            {
                value.CompanyName = experience.CompanyName;
                value.Title = experience.Title;
                value.ExperienceDate = experience.ExperienceDate;
                value.Description = experience.Description;

                context.SaveChanges();
            }
            return RedirectToAction("ExperienceList");
        }
    }
}