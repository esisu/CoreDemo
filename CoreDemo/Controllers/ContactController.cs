using System;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class ContactController : Controller
    {

        private readonly ContactManager _contactManager = new ContactManager(new EfContactRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
            contact.ContactStatus = true;
            _contactManager.ContactAdd(contact);
            return RedirectToAction("Index","Blog");
        }

    }
}
