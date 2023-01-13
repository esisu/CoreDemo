using System.Collections.Generic;

namespace CoreDemo.Project.Business.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T t);

        void TUpdate(T t);

        void TDelete(T t);

        List<T> GetList();

        T GetById(int id);
    }
}
