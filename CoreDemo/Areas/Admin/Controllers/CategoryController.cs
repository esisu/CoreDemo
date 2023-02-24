using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.Business.ValidationRules;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

using X.PagedList;

namespace CoreDemo.Project.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index(int page = 1)
        {
            var values = cm.GetList().ToPagedList(page, 3);

            return View(values);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();

            ValidationResult result = categoryValidator.Validate(category);

            if (result.IsValid)
            {
                category.CategoryStatus = true;
                cm.TAdd(category);
                return RedirectToAction("Index", "Category");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

            return View();
        }

    }
}
