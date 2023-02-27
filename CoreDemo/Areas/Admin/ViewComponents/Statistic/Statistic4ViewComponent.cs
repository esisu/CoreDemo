using System.Linq;
using CoreDemo.Project.DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4ViewComponent : ViewComponent
    {
        readonly Context _context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = _context.Admins.Where(x => x.AdminId == 1).Select(y => y.Name);
            ViewBag.v2 = _context.Admins.Where(x => x.AdminId == 1).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.v3 = _context.Admins.Where(x => x.AdminId == 1).Select(y => y.Description).FirstOrDefault();
            return View();
        }
    }
}
