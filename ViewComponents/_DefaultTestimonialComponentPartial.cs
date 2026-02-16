using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent    
    {
        PortfolioContext context =new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Testimonials.ToList();
            return View(values);
        }
    }
}
