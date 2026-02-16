using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultSliderComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
