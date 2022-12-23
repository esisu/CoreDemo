using System.Collections.Generic;
using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Project.Web.UI.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlogPartial(int id)
        {
            List<Comment> comments = _commentManager.GetAllComments(id);
            return PartialView(comments);
        }

    }
}
