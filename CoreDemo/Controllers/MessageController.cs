using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Project.Web.UI.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        private readonly Message2Manager _messageManager = new Message2Manager(new EfMessage2Repository());

        public IActionResult Inbox()
        {
            int id = 2;
            List<Message2> values = _messageManager.GetInboxListByWriter(id).ToList();
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var value = _messageManager.GetById(id);
            return View(value);
        }

    }
}
