using CoreDemo.Project.Web.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

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

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            list.Add(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult DeleteWriter(int id)
        {
            var yazar = list.FirstOrDefault(x=>x.id == id);
            list.Remove(yazar);
            return Json(yazar);
        }

        [HttpPost]
        public IActionResult UpdateWriter(WriterClass writerClass)
        {
            var yazar = list.FirstOrDefault(x => x.id == writerClass.id);
            yazar.name = writerClass.name;
            var jsonWriter = JsonConvert.SerializeObject(writerClass);
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
                id = 2,
                name = "arzu"
            },
            new WriterClass()
            {
                id = 3,
                name = "burak"
            }
        };

    }
}