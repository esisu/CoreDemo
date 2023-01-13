using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.Notification
{
    public class NotificationList:ViewComponent
    {
        readonly NotificationManager _notificationManager = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = _notificationManager.GetList();
            return View(values);
        }
    }
}
