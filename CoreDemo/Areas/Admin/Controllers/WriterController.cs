using CoreDemo.Project.Web.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Office2010.ExcelAc;

namespace CoreDemo.Project.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(list);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterById(int id)
        {
            var findWriter = list.FirstOrDefault(x => x.id == id);
            var jsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriter);
        }

        public static List<WriterClass> list = new List<WriterClass>()
        {
            new WriterClass()
            {
                id = 1,
                name = "erkan"
            },
            new WriterClass()
            {
                id = 1,
                name = "arzu"
            },
            new WriterClass()
            {
                id = 1,
                name = "burak"
            }
        };
    }
}