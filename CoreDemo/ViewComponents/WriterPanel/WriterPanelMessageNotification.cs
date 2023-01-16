using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.WriterPanel
{
    public class WriterPanelMessageNotification: ViewComponent
    {
        private readonly MessageManager _messageManager = new MessageManager(new EfMessageRepository());

        public IViewComponentResult Invoke()
        {

            string mail = "erkan@erkan.com";

            var values = _messageManager.GetInboxListByWriter(mail);

            return View(values);
        }
    }
}
