using System.Linq;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1ViewComponent : ViewComponent
    {
        private BlogManager bm = new BlogManager(new EfBlogRepository());

        Context context = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.count = bm.GetList().Count;
            ViewBag.contactCount = context.Contacts.Count();
            ViewBag.yorumSayisiCount = context.Comments.Count();

            //string api = "14ad2aba611dbef9c504b82a127794c5";
            //string connection = "http://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            //XDocument document = XDocument.Load(connection);
            //ViewBag.v4 = document.Descendants("tempatures").ElementAt(0).Attribute("value").Value;
            ViewBag.v4 = "5";
            return View();
        }
    }
}
