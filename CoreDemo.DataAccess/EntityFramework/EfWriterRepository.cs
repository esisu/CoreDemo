﻿using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.DataAccess.Repositories;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.DataAccess.EntityFramework
{
    public class EfWriterRepository:GenericRepository<Writer>,IWriterDal
    {
    }
}