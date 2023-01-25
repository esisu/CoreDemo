using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.Repositories;
using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.Project.DataAccess.EntityFramework
{
    public class EfMessage2Repository:GenericRepository<Message2>,IMessageDal2
    {

        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using var c = new Context();
            return c.Messages2s.Include(x => x.SenderUser).Where(x => x.ReciverId == id).ToList();
        }

    }
}
