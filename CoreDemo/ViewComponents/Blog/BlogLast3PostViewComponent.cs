using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.Blog
{
    public class BlogLast3PostViewComponent:ViewComponent
    {
        readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetLast3BLog();
            return View(values);
        }
    }
}
