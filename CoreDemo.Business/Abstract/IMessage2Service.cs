using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.Business.Abstract
{
    public interface IMessage2Service:IGenericService<Message2>
    {
        List<Message2> GetInboxListByWriter(int id);
    }
}
