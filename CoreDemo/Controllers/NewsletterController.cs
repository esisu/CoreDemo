using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly NewsletterManager _newsletterManager = new NewsletterManager(new EfNewsletterRepository());

        public PartialViewResult SubscribeNewsletter()
        {
            return PartialView();
        }

        [HttpPost]
        public RedirectToActionResult SubscribeNewsletter(Newsletter newsletter)
        {
            newsletter.Status = true;
            _newsletterManager.AddNewsletter(newsletter);
            return RedirectToAction("Index","Blog");
        }

    }
}
