using System;
using System.Collections.Generic;
using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly EfCategoryRepository _efCategoryRepository;

        public CategoryManager(ICategoryDal categoryDal, EfCategoryRepository efCategoryRepository)
        {
            _efCategoryRepository = efCategoryRepository;
        }

        public void AddCategory(Category category)
        {
            _efCategoryRepository.Insert(category);
        }

        public void UpdateCategory(Category category)
        {
            _efCategoryRepository.Update(category);
        }

        public void DeleteCategory(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public List<Category> GetAllCategories()
        {
            return _efCategoryRepository.GetListAll();
        }

        public Category GetCategoryById(int id)
        {
            return _efCategoryRepository.GetById(id);
        }
    }
}
