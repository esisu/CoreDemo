using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.DataAccess.Abstract
{
    public interface IMessageDal2:IGenericDal<Message2>
    {
        List<Message2> GetListWithMessageByWriter(int id);
    }
}
