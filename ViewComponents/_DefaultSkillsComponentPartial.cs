using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using System.Linq;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultSkillsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            // İstatistiklerden farkı: Burada Count() demiyoruz, 
            // Tüm listeyi (yetenek adı ve değerini) sayfaya gönderiyoruz.
            var values = context.Skills.ToList();
            return View(values);
        }
    }
}