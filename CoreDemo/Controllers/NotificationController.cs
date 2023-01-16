using System.Collections.Generic;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    [AllowAnonymous]
    public class NotificationController : Controller
    {
        private readonly NotificationManager _notificationManager = new NotificationManager(new EfNotificationRepository());


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllNotification()
        {
            List<Notification> notificationList = _notificationManager.GetList();
            return View(notificationList);
        }


    }
}
