using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
	public class AboutController : Controller
	{

		AboutManager aboutManager = new AboutManager(new EfAboutRepository());

		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult SocialMediaAbout()
		{
			var values = aboutManager.GetList();
			return PartialView(values);
		}

	}
}
