using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Project.Web.UI.ViewComponents.Category
{
    public class CategoryListViewComponent:ViewComponent
    {
        private readonly CategoryManager _categoryManager = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke(int id)
        {
            List<Entities.Concrete.Category> categories = _categoryManager.GetList();
            return View(categories);
        }
    }
}
