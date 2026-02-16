using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using System.Linq;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultJobComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Jobs.ToList();
            return View(values);
        }
    }
}
