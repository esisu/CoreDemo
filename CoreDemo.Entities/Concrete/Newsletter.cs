using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Project.Entities.Concrete
{
    public class Newsletter
    {

        [Key]
        public int MailId { get; set; }
        
        public string  Mail { get; set; }

        public bool Status { get; set; }

    }
}
