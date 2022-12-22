using System.Collections.Generic;

namespace CoreDemo.Project.DataAccess.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        List<T> GetListAll();

        T GetById(int id);
    }
}
