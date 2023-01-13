using System.Collections.Generic;
using CoreDemo.Project.Business.Abstract;
using CoreDemo.Project.DataAccess.Abstract;
using CoreDemo.Project.Entities.Concrete;

namespace CoreDemo.Project.Business.Concrete
{
    public class NotificationManager:INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification t)
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Notification t)
        {
            throw new System.NotImplementedException();
        }

        public void TDelete(Notification t)
        {
            throw new System.NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _notificationDal.GetListAll();
        }

        public Notification GetById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
