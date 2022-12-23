using CoreDemo.Project.Entities.Concrete;
using System.Collections.Generic;

namespace CoreDemo.Project.Business.Abstract
{
    public interface ICommentService
    {
        void AddComment(Comment comment);

        //void UpdateComment(Comment comment);

        //void DeleteComment(Comment comment);

        List<Comment> GetAllComments(int id);

        //Comment GetCommentById(int id);
    }
}
