using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using System.Linq; 

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.projectCount = context.Portfolios.Count();
            ViewBag.messageCount = context.Messages.Count();

          
            Random rnd = new Random();
            ViewBag.randomValue = rnd.Next(10, 31);

            return View();
        }
    }
}