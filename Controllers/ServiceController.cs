using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Services.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateService([FromForm] Service service)
        {
            context.Services.Add(service);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = context.Services.Find(id);
            if (value != null)
            {
                context.Services.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var value = context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService([FromForm] Service service)
        {
            var value = context.Services.Find(service.ServiceId);
            if (value != null)
            {
                value.title = service.title;
                value.Description = service.Description;
                value.Status = service.Status;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}