using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.WriterPanel
{
    public class WriterPanelMessageNotification: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
