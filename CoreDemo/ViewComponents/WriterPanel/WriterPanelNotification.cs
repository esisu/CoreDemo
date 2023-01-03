using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.WriterPanel
{
    public class WriterPanelNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
