using System.Collections.Generic;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            List<Category> values =_categoryManager.GetList();
            return View(values);
        }
    }
}
