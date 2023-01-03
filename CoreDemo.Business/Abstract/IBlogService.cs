using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.Business.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();

        List<Blog> GetAllBlogs(int id);

        List<Blog> GetBlogListByWriter(int id);

    }
}
