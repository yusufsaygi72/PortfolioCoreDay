using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using System.Linq;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultEducationComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Educations.ToList();
            return View(values);
        }
    }
}