using System.Collections.Generic;
using System.Linq;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.WriterPanel
{
    public class WriterPanelMessageNotification: ViewComponent
    {
        private readonly Message2Manager _messageManager = new Message2Manager(new EfMessage2Repository());

        public IViewComponentResult Invoke()
        {
            int id = 2;
            List<Message2> values = _messageManager.GetInboxListByWriter(id).ToList();
            return View(values);
        }
    }
}
