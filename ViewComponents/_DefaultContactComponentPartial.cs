using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultContactComponentPartial:ViewComponent
      
    {
     PortfolioContext  context=new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values=context.Contacts.ToList();
            return View(values);
        }
    }
}
