using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
