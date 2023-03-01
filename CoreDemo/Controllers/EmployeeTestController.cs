using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class EmployeeTestController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();

            var responseMesaj = await client.GetAsync("http://localhost:5261/api/Default");

            var jsonstring = await responseMesaj.Content.ReadAsStringAsync();

            var values = JsonConvert.DeserializeObject<List<ClassCalisan>>(jsonstring);

            return View(values);
        }

        public async Task<IActionResult> AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(ClassCalisan calisan)
        {
            var client = new HttpClient();

            var jsonEmployee = JsonConvert.SerializeObject(calisan);

            StringContent stringContent = new StringContent(jsonEmployee, Encoding.UTF8, "application/json");

            var responseMesaj = await client.PostAsync("http://localhost:5261/api/Default", stringContent);

            if (responseMesaj.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View(calisan);
        }
        
        [HttpGet]
        public async Task<IActionResult> UpdateEmployee(int id)
        {
            var client = new HttpClient();

            var responseMesaj = await client.GetAsync("http://localhost:5261/api/Default/"+id);

            if (responseMesaj.IsSuccessStatusCode)
            {

                var jsonstring = await responseMesaj.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ClassCalisan>(jsonstring);
                return View(values);
            }
            
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public async Task<IActionResult> UpdateEmployee(ClassCalisan calisan)
        {
            var client = new HttpClient();
            var jsonemployee = JsonConvert.SerializeObject(calisan);
            var content = new StringContent(jsonemployee, Encoding.UTF8);
            var responseMesaj = await client.PutAsync("http://localhost:5261/api/Default/", content);
            if (responseMesaj.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
                
            }
            else
            {
                return View(calisan);
            }
        }
        
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var client = new HttpClient();

            var responseMesaj = await client.DeleteAsync("http://localhost:5261/api/Default/" + id);

            if (responseMesaj.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
               
            }
            return View();

        }






    }

    public class ClassCalisan
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }


}
