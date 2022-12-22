using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Project.Entities.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        
        public string ContactUsername { get; set; }
        
        public string ContactEmail { get; set; }
        
        public string ContactSubject { get; set; }
        
        public string ContactMessage { get; set; }

        public DateTime ContactDate { get; set; }

        public bool ContactStatus { get; set; }
    }
}
