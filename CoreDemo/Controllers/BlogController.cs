using System.Collections.Generic;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            List<Blog> blogs = _blogManager.GetBlogListWithCategory();

            return View(blogs);
        }
    }
}
