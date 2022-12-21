using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.DataAccess.Abstract
{
    public interface ICategoryDal
    {

        List<Category> GetCategories();

        Category GetCategory(int id);

        void AddCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(Category category);
        

    }
}
