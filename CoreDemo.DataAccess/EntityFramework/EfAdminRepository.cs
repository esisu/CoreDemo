using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.DataAccess.Repositories;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.DataAccess.EntityFramework
{
    public class EfAdminRepository:GenericRepository<Admin>,IAdminDal
    {
    }
}
