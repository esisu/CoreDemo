using System.Linq;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic3ViewComponent : ViewComponent
    {
        private BlogManager bm = new BlogManager(new EfBlogRepository());

        readonly Context _context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.SonBlog = _context.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
