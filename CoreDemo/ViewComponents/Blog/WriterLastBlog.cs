using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetBlogListByWriter(3);
            return View(values);
        }

    }
}
