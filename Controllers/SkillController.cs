using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class SkillController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        // LIST
        public IActionResult Index()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        // GET
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        // POST
        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            if (!ModelState.IsValid)
                return View(skill);

            context.Skills.Add(skill);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
