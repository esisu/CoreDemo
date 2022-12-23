using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.Business.Abstract
{
    public interface IBlogService
    {
        void AddBlog(Blog blog);

        void UpdateBlog(Blog blog);

        void DeleteBlog(Blog blog);

        List<Blog> GetAllBlogs();

        Blog GetBlogById(int id);

        List<Blog> GetBlogListWithCategory();

        List<Blog> GetAllBlogs(int id);

    }
}
