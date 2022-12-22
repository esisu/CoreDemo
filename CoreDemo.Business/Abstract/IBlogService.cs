using CoreDemo.Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
