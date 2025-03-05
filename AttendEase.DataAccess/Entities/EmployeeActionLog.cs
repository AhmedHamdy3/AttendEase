using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class EmployeeActionLog
    {
        public int EmployeeActionLogId { get; set; }
        public TimeSpan CreationTime { get; set; }
        public string Action { get; set; }
        public string? Detils { get; set; }

        // Foreign Key
        public int EmployeeId { get; set; }

        // Navigation Property
        public virtual Employee Employee { get; set; }
    }
}
