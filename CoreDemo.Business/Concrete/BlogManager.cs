using System.Collections.Generic;
using System.Linq;
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

        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetListAll();
        }

        public Blog GetBlogById(int id)
        {
            return _blogDal.GetById(id);
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

    }

}
