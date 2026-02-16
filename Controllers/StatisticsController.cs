using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.Skills.Average(x => x.SkillValue);
            ViewBag.v4 = context.Skills.Where(x => x.SkillValue > 80).Count();
            ViewBag.v5 = context.Services.Count();
            ViewBag.v6 = context.Testimonials.Count();
            ViewBag.v7 = context.Portfolios.Count();

            ViewBag.v8 = context.Messages.Count();
            ViewBag.v9 = context.Messages.Where(x => x.Isread == true).Count();
            ViewBag.v10 = context.Messages.Where(x => x.Isread == false).Count();


            return View();
        }
    }
}