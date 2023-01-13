using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Project.Entities.Concrete
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        public string Sender { get; set; }

        public string Reciver { get; set; }

        public string Subject { get; set; }

        public string Details { get; set; }

        public DateTime MessageDate { get; set; }

        public bool Status { get; set; }


    }
}
