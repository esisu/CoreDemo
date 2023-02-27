using System.Linq;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1ViewComponent : ViewComponent
    {
        private BlogManager bm = new BlogManager(new EfBlogRepository());

        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.count = bm.GetList().Count;
            ViewBag.contactCount = context.Contacts.Count();
            ViewBag.yorumSayisiCount = context.Comments.Count();
            return View();
        }
    }
}
