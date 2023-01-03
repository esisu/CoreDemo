using System.Collections.Generic;
using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //public void AddCategory(Category category)
        //{
        //    _categoryDal.Insert(category);
        //}

        //public void UpdateCategory(Category category)
        //{
        //    _categoryDal.Update(category);
        //}

        //public void DeleteCategory(Category category)
        //{
        //    _categoryDal.Delete(category);
        //}

        //public List<Category> GetAllCategories()
        //{
        //    return _categoryDal.GetListAll();
        //}

        //public Category GetCategoryById(int id)
        //{
        //    return _categoryDal.GetById(id);
        //}

        /*---------*/

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public List<Category> GetList()
        {
            return _categoryDal.GetListAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

    }
}
