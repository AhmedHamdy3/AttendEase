using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public string Title { get; set; }
        public string LeaveType { get; set; } // Sick, Vacation
        public string? Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime StartDate { get; set; } // Start date of the leave
        public DateTime EndDate { get; set; } // End date of the leave
        public string Status { get; set; } //  Pending, Approved
        public bool IsRead { get; set; } // 1 -> Readed, 0 -> Unreaded 

        // Foreign Key
        public int EmployeeId { get; set; }

        // Navigation Property
        public virtual Employee Employee { get; set; }
    }
}
