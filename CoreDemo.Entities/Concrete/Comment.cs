using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Project.Entities.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public string CommentUserName { get; set; }

        public string CommentTitle { get; set; }

        public string CommentContent { get; set; }

        public DateTime CommentDate { get; set; }

        public bool CommentStatus { get; set; }

        public int BlogId { get; set; }

        public Blog Blog { get; set; }

        public int BLogScore { get; set; }
    }
}
