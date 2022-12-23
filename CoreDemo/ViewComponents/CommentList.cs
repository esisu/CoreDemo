using CoreDemo.Project.Business.Concrete;
using CoreDemo.Project.DataAccess.EntityFramework;
using CoreDemo.Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CoreDemo.Project.Web.UI.Models;

namespace CoreDemo.Project.Web.UI.ViewComponents
{
    public class CommentList:ViewComponent
    {
        private readonly CommentManager _commentManager = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            List<Comment> comments = _commentManager.GetAllComments(id);
            return View(comments);

            //var comments = new List<UserComment>
            //{
            //    new UserComment() { id = 1, Username = "Erkan" },
            //    new UserComment() { id = 1, Username = "Arzu" },
            //    new UserComment() { id = 1, Username = "Burak" },
            //};

            //return View(comments);
        }

    }
}
