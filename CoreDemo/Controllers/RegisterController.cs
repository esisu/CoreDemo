using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.Business.ValidationRules;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using FluentValidation.Results;
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
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(writer);
            if (results.IsValid)
            {
                writer.WriterAbout = "Hakkımda";
                writer.WriterStatus = true;
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();;
        }

    }
}
