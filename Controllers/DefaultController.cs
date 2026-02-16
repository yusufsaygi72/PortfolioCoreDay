using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System;

namespace PortfolioCoreDay.Controllers
{
    public class DefaultController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message m)
        {
            m.SendDate = DateTime.Now;
            m.Isread = false;

            context.Messages.Add(m);
            context.SaveChanges();

            
            TempData["SuccessMessage"] = "Mesajınız başarıyla gönderildi!";

            return RedirectToAction("Index");
        }
    }
}