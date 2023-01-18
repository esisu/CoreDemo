using System;
using System.Collections.Generic;
using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Concrete
{
    public class Message2Manager:IMessage2Service
    {
        private readonly IMessageDal2 _messageDal;

        public Message2Manager(IMessageDal2 messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetList()
        {
            return _messageDal.GetListAll();
        }

        public Message2 GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _messageDal.GetListAll(x => x.ReciverId==id);
        }
        
    }
}
