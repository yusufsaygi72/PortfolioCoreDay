 using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialSidebarTopMenu()
        {
            return PartialView();
        }
        public PartialViewResult partialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult partialScript()
        {
            return PartialView();
        }

    }
}
