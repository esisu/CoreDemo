using System.Collections.Generic;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {
            List<Blog> blogs = _blogManager.GetBlogListWithCategory();

            return View(blogs);
        }

        public IActionResult BlogDetails(int id)
        {
            List<Blog> blogs = _blogManager.GetAllBlogs(id);

            return View(blogs);
        }

        public IActionResult BlogReadAll(int id)
        {
            Blog blog = _blogManager.GetBlogById(id);
            return View(blog);
        }
        
        

    }
}
