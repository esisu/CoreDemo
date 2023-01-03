using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Concrete
{
    public class BlogManager:IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        //public void AddBlog(Blog blog)
        //{

        //}

        //public void UpdateBlog(Blog blog)
        //{
        //    _blogDal.Update(blog);
        //}

        //public void DeleteBlog(Blog blog)
        //{
        //    _blogDal.Delete(blog);
        //}

        //public List<Blog> GetAllBlogs()
        //{
        //    return _blogDal.GetListAll();
        //}

        //public Blog GetBlogById(int id)
        //{
        //    return _blogDal.GetById(id);
        //}

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            return _blogDal.GetListWithCategoryByWriter(id);
        }
        
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetAllBlogs(int id)
        {
            return _blogDal.GetListAll(x=>x.BlogId==id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetListAll(x => x.WriterId == id);
        }

        public List<Blog> GetLast3BLog()
        {
            return _blogDal.GetListAll().OrderByDescending(x=>x.BlogId).Take(3).ToList();
        }

        /*--------*/

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetListAll();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }
    }

}
