using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using System.Linq;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultPortfolioComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Portfolios.Include(x => x.Category).ToList();
            return View(values);
        }
    }
}