using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.DataAccess.Abstract
{
    public interface IBlogDal
    {
        List<Blog> GetBlogs();

        Blog GetBlog(int id);

        void AddBlog(Blog blog);

        void UpdateBlog(Blog blog);

        void DeleteBLog(Blog blog);
    }
}
