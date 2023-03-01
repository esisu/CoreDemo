using System.Collections.Generic;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using CoreDemo.Project.DataAccess.Concrete;
using CoreDemo.Project.Web.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {

        //public IActionResult ExportStaticExcelBlogList()
        //{
        //    var workBook = new XLWorkbook();
        //    var worksheet = workBook.Worksheets.Add("BLog Listesi");
        //    worksheet.Cell(1, 1).Value = "Blog Id";
        //    worksheet.Cell(1, 2).Value = "Blog Adı";
        //    int blogRowCount = 2;
        //    foreach (var item in GetBlogList())
        //    {
        //        worksheet.Cell(blogRowCount,1).Value= item.Id;
        //        worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
        //        blogRowCount++;
        //    }
        //    using (var stream = new MemoryStream())
        //    {
        //        workBook.SaveAs(stream);
        //        var content = stream.ToArray();
        //        return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","BlogListesi.xlsx");
        //    }
        //}

        //List<BlogModel> GetBlogList()
        //{
        //    List<BlogModel> blogList = new List<BlogModel>()
        //    {
        //        new BlogModel(){Id = 1,BlogName = "Burak"},
        //        new BlogModel(){Id = 2,BlogName = "Arzu"},
        //        new BlogModel(){Id = 3,BlogName = "Erkan"},
        //        new BlogModel(){Id = 4,BlogName = "Serkan"}
        //    };
        //    return blogList;
        //}

        public IActionResult BlogListExcel()
        {
            return View();
        }

        public IActionResult ExportDynamicExcelBlogList()
        {
            var workBook = new XLWorkbook();
            var worksheet = workBook.Worksheets.Add("BLog Listesi");
            worksheet.Cell(1, 1).Value = "Blog Id";
            worksheet.Cell(1, 2).Value = "Blog Adı";
            int blogRowCount = 2;
            foreach (var item in GetBlogListDynamic())
            {
                worksheet.Cell(blogRowCount, 1).Value = item.Id;
                worksheet.Cell(blogRowCount, 2).Value = item.BlogName;
                blogRowCount++;
            }
            using (var stream = new MemoryStream())
            {
                workBook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "BlogListesi.xlsx");
            }
        }

        List<BlogModel> GetBlogListDynamic()
        {
            List<BlogModel> blogList = new List<BlogModel>();
            var context = new Context();
            blogList = context.Blogs.Select(x => new BlogModel()
            {
                Id = x.BlogId,
                BlogName = x.BlogTitle
            }).ToList();
            return blogList;
        }

    }

}
