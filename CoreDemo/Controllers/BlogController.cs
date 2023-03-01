using System;
using System.Collections.Generic;
using System.Linq;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.Business.ValidationRules;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Project.Web.UI.Controllers
{
    //[AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        Context c = new Context();

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
            Blog blog = _blogManager.GetById(id);
            return View(blog);
        }

        public IActionResult BlogListByWriter()
        {
            var userMail = User.Identity.Name;
            var writerID = c.Writer.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = _blogManager.GetListWithCategoryByWriter(writerID);
            return View(values);
        }

        public IActionResult BlogAdd()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in categoryManager.GetList()
                                               select new SelectListItem()
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.KategoriListesi = categories;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            var userMail = User.Identity.Name;
            var writerID = c.Writer.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = _blogManager.GetListWithCategoryByWriter(writerID);
            BlogValidator blogValidator = new BlogValidator();
            ValidationResult results = blogValidator.Validate(blog);
            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
                blog.WriterId = writerID;
                _blogManager.TAdd(blog);
                return RedirectToAction("BlogListByWriter");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
                List<SelectListItem> categories = (from x in categoryManager.GetList()
                                                   select new SelectListItem()
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryId.ToString()
                                                   }).ToList();
                ViewBag.KategoriListesi = categories;
                return View();
            }
        }

        public IActionResult DeleteBlog(int id)
        {
            var value = _blogManager.GetById(id);
            _blogManager.TDelete(value);
            return RedirectToAction("BlogListByWriter");
        }

        public IActionResult BlogEdit(int id)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categories = (from x in categoryManager.GetList()
                                               select new SelectListItem()
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryId.ToString()
                                               }).ToList();
            ViewBag.KategoriListesi = categories;
            var value = _blogManager.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult BlogEdit(Blog blog)
        {
            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
            blog.WriterId = 1;
            _blogManager.TUpdate(blog);
            return RedirectToAction("BlogListByWriter");
        }

    }
}
