using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact([FromForm] Contact contact)
        {
            var value = context.Contacts.Find(contact.ContactId);
            if (value != null)
            {
                value.Address = contact.Address;
                value.Phone = contact.Phone;
                value.Email = contact.Email;
                value.MapUrl = contact.MapUrl;
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}