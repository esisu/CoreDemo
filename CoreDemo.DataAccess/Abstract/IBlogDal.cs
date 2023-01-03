using System.Collections.Generic;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.DataAccess.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {

        List<Blog> GetListWithCategory();

        List<Blog> GetListWithCategoryByWriter(int id);

    }
}
