using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.Business.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {
        List<Message> GetInboxListByWriter(string mail);
    }
}
