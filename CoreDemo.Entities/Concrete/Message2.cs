using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Project.Entities.Concrete
{
    public class Message2
    {
        [Key]
        public int MessageId { get; set; }

        public int SenderId { get; set; }

        public int ReciverId { get; set; }

        public string Subject { get; set; }

        public string Details { get; set; }

        public DateTime MessageDate { get; set; }

        public bool Status { get; set; }

        public Writer SenderUser { get; set; }
        public Writer ReciverUser { get; set; }
    }
}
