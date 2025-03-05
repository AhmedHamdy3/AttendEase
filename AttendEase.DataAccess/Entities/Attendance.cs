using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public DateTime AttendanceDate { get; set; }
        public TimeSpan? CheckInTime { get; set; }
        public TimeSpan? CheckOutTime { get; set; }
        public TimeSpan? WorkedHours { get; set; }

        // Foreign Key
        public int EmployeeId { get; set; }

        // Navigation Properties
        public virtual Employee Employee { get; set; }
        public virtual ICollection<AttendanceAttendanceStatus> AttendanceAttendanceStatuses { get; set; }
    }
}
