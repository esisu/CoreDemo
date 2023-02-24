using System;
using System.IO;
using System.Linq;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.Business.ValidationRules;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using CoreDemo.Project.Web.UI.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    //[Authorize]
    [AllowAnonymous]
    public class WriterController : Controller
    {
        private readonly WriterManager _writerManager = new WriterManager(new EfWriterRepository());

        [Authorize]
        public IActionResult Index()
        {
            if (User.Identity != null)
            {
                var user = User.Identity.Name;
                ViewBag.v = user;
                Context c = new Context();
                var userdetail = c.Writer.Where(x => x.WriterMail == user).Select(y => y.WriterName).FirstOrDefault();
                ViewBag.v2 = userdetail;
            }
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
        
        public IActionResult Test()
        {
            return View();
        }
        
        public PartialViewResult WriterPanelNavBarPartial()
        {
            return PartialView();
        }
        
        public PartialViewResult WriterPanelFooterPartial()
        {
            return PartialView();
        }
        
        public IActionResult EditProfile()
        {
            Context c = new Context();
            var userMail = User.Identity.Name;
            var writerID = c.Writer.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var writerValues = _writerManager.TGetById(writerID);
            return View(writerValues);
        }

        [HttpPost]
        public IActionResult EditProfile(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult results = writerValidator.Validate(writer);
            if (results.IsValid)
            {
                writer.WriterStatus = true;
                _writerManager.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var validationFailure in results.Errors)
                {
                    ModelState.AddModelError(validationFailure.PropertyName, validationFailure.ErrorMessage);
                }
            }

            return View();
        }

        public IActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProfile(AddProfileImage addProfileImage)
        {

            Writer writer = new Writer();

            if (addProfileImage.WriterImage != null)
            {
                var extension = Path.GetExtension(addProfileImage.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                addProfileImage.WriterImage.CopyTo(stream);
                writer.WriterImage = newImageName;
            }

            writer.WriterMail = addProfileImage.WriterMail;
            writer.WriterName = addProfileImage.WriterName;
            writer.WriterPassword = addProfileImage.WriterPassword;
            writer.WriterStatus = true;
            writer.WriterAbout = addProfileImage.WriterAbout;
            _writerManager.TAdd(writer);
            //WriterValidator writerValidator = new WriterValidator();
            //ValidationResult results = writerValidator.Validate(writer);
            //if (results.IsValid)
            //{
            //    writer.WriterStatus = true;

            //    return RedirectToAction("Index", "Dashboard");
            //}
            //else
            //{
            //    foreach (var validationFailure in results.Errors)
            //    {
            //        ModelState.AddModelError(validationFailure.PropertyName, validationFailure.ErrorMessage);
            //    }
            //}

            return View();
        }
    }
}
