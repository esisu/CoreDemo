using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class RegisterController : Controller
    {
        private WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.WriterAbout = "Hakkımda";
            writer.WriterStatus = true;
            wm.WriterAdd(writer);
            return RedirectToAction("Index","Blog");
        }

    }
}
