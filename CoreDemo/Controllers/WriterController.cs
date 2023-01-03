using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    //[Authorize]
    public class WriterController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }

        [AllowAnonymous]
        public PartialViewResult WriterPanelNavBarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterPanelFooterPartial()
        {
            return PartialView();
        }

    }
}
