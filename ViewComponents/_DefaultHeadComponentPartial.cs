using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
      public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
