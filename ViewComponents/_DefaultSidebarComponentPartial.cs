using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
