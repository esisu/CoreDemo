using System.Linq;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.ViewComponents.WriterPanel
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        private WriterManager _writerManager = new WriterManager(new EfWriterRepository());

        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            if (User.Identity != null)
            {
                var userMail = User.Identity.Name;

                var writerID = c.Writer.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();

                var values = _writerManager.GetWriterById(writerID);

                return View(values);
            }
            else
            {
                return View();
            }
        }

    }
}
