using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class AttendanceStatus
    {
        public int AttendanceStatusId { get; set; }
        public string Status { get; set; }

        // Navigation Properties
        public virtual ICollection<AttendanceAttendanceStatus> AttendanceAttendanceStatuses { get; set; }
    }
}
