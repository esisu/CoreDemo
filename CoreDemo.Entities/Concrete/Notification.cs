using System;
using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Project.Entities.Concrete
{
    public class Notification
    {

        [Key]
        public int NotificationId { get; set; }

        public string NotificationType { get; set; }

        public string NotificationTypeSymbol { get; set; }

        public string NotificationDetails { get; set; }

        public bool NotificationStatus { get; set; }

        public string NotificationColor { get; set; }

        public DateTime NotificationDate { get; set; }



    }
}
