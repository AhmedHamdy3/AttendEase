using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class AttendanceAttendanceStatus
    {
        // Composite primary key (Foreign keys)
        public int AttendanceId { get; set; }
        public int AttendanceStatusId { get; set; }

        // Navigation Properties
        public virtual Attendance Attendance { get; set; }
        public virtual AttendanceStatus AttendanceStatus { get; set; }
    }
}
