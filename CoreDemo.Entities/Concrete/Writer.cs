﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Project.Entities.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }

        public string WriterName { get; set; }

        public string WriterAbout { get; set; }

        public string WriterImage { get; set; }

        public string WriterMail { get; set; }

        public string WriterPassword { get; set; }

        public bool WriterStatus { get; set; }

        public List<Blog> Blogs { get; set; }
        
        public virtual ICollection<Message2> WriterSender { get;}

        public virtual ICollection<Message2> WriterReciver { get; }

    }
}
