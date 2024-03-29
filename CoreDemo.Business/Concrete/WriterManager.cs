﻿using System.Collections.Generic;
using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Concrete
{
    public class WriterManager:IWriterService
    {
        private readonly IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        
        //public void WriterAdd(Writer writer)
        //{
        //    _writerDal.Insert(writer);
        //}

        public void TAdd(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void TUpdate(Writer t)
        {
            _writerDal.Update(t);
        }

        public void TDelete(Writer t)
        {
            _writerDal.Delete(t);
        }

        public List<Writer> GetList()
        {
          return  _writerDal.GetListAll();
        }

        public Writer TGetById(int id)
        {
          return  _writerDal.GetById(id);
        }

        public Writer GetById(int id)
        {
            return _writerDal.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x=>x.WriterId==id);
        }

    }
}
