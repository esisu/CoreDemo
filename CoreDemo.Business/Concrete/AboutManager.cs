using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.Business.Concrete
{
	public class AboutManager : IAboutService
	{
        readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

        public void TAdd(About t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetList()
		{
			return _aboutDal.GetListAll();
		}

        public About GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
