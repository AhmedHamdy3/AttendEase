using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public DateTime CreationTime { get; set; }
        public bool IsRead { get; set; }

        // Foreign Key
        public int EmployeeId { get; set; }

        // Navigation Property
        public virtual Employee Employee { get; set; }
    }
}
