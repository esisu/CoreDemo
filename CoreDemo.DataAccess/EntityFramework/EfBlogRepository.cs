using System.Collections.Generic;
using System.Linq;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.Repositories;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Project.DataAccess.EntityFramework
{
    public class EfBlogRepository:GenericRepository<Blog>,IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using var c = new Context();
            return c.Blogs.Include(x => x.Category).ToList();
        }
    }
}
