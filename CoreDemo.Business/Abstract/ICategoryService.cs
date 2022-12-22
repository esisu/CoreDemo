using System.Collections.Generic;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Abstract
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        
        void UpdateCategory(Category category);
        
        void DeleteCategory(Category category);

        List<Category> GetAllCategories();

        Category GetCategoryById(int id);
    }
}
