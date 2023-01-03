using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.Business.Abstract
{
    public interface IWriterService:IGenericService<Writer>
    {
        //void WriterAdd(Writer writer);

        List<Writer> GetWriterById(int id);
    }
}
