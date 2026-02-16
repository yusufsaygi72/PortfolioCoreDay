using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        // id parametresi opsiyonel, bir mesaja tıklandığında detay göstermek için kullanacağız
        public IActionResult Index(int id = 0)
        {
            var values = context.Messages.OrderByDescending(x => x.SendDate).ToList();

            if (id != 0)
            {
                var message = context.Messages.Find(id);
                if (message != null)
                {
                    message.Isread = true; // Okundu olarak işaretle
                    context.SaveChanges();
                    ViewBag.MessageDetail = message; // View tarafına mesajı yolla
                }
            }
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            if (value != null)
            {
                context.Messages.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}