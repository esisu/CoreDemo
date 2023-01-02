using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
	public class AboutController : Controller
	{
        readonly AboutManager _aboutManager = new AboutManager(new EfAboutRepository());

		public IActionResult Index()
		{
            var values = _aboutManager.GetList();
            return View(values);
		}

		public PartialViewResult SocialMediaAbout()
		{
			
			return PartialView();
		}

	}
}
