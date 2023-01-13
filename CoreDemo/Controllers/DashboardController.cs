using System.Linq;
using CoreDemo.Project.DataAccess.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    [AllowAnonymous]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();

            ViewBag.BlogToplamSayisi = context.Blogs.Count().ToString();
            //ViewBag.GirisYapanKullaniciBlogToplamSayisi = context.Blogs.Where(x=>x.WriterId==1).Count().ToString();
            ViewBag.GirisYapanKullaniciBlogToplamSayisi = context.Blogs.Count(x => x.WriterId == 1).ToString();
            ViewBag.ToplamKategoriSayisi = context.Categories.Count().ToString();

            return View();
        }
    }
}
