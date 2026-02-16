using Microsoft.AspNetCore.Mvc;

namespace PortfolioCoreDay.Controllers
{
    public class ErrorController : Controller
    {
       
        public IActionResult Error404()
        {
            return View();
        }
    }
}