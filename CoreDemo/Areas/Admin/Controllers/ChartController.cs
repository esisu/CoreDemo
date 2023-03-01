using System.Collections.Generic;
using CoreDemo.Project.Web.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass()
            {
                Categorycount = 11,
                Categoryname = "Teknoloji"
            });
            list.Add(new CategoryClass()
            {
                Categorycount = 99,
                Categoryname = "Cep Telenu"
            });
            list.Add(new CategoryClass()
            {
                Categorycount = 5,
                Categoryname = "Yazılım"
            });
            return Json(new { jsonlist = list });
        }

    }

    
        
    

}
