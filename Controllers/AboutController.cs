using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        [HttpGet]
        public IActionResult Index()
        {
            var value = context.Abouts.FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(About about)
        {
            var value = context.Abouts.FirstOrDefault();

            if (value == null)
            {
                
                context.Abouts.Add(about);
            }
            else
            {
                
                value.Title = about.Title;
                value.Description = about.Description;
                value.Birthday = about.Birthday;
                value.Website = about.Website;
                value.Degree = about.Degree;
                value.Phone = about.Phone;
                value.Email = about.Email;
            }

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}