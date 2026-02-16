using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;
using System.Linq;

namespace PortfolioCoreDay.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult ProjectList()
        {
            var values = context.Portfolios.Include(x => x.Category).ToList();
            return View("ProjectList", values);
        }

        public IActionResult PortfolioCards()
        {
            var values = context.Portfolios.Include(x => x.Category).ToList();
            return View("PortfolioCards", values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            ViewBag.Categories = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio([FromForm] Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioCards");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            if (value != null)
            {
                context.Portfolios.Remove(value);
                context.SaveChanges();
            }
            return RedirectToAction("PortfolioCards");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            ViewBag.Categories = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName", value.CategoryId);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio([FromForm] Portfolio portfolio)
        {
            var value = context.Portfolios.Find(portfolio.PortfolioId);
            if (value != null)
            {
                value.Title = portfolio.Title;
                value.Description = portfolio.Description;
                value.GithubUrl = portfolio.GithubUrl;
                value.ImageUrl = portfolio.ImageUrl;
                value.CategoryId = portfolio.CategoryId;
                context.SaveChanges();
            }
            return RedirectToAction("PortfolioCards");
        }
    }
}