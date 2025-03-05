using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string? QRCodeData { get; set; } // Stores the EmployeeId as QR code data
        public string Name { get; set; }

        public byte[]? ProfileImage { get; set; }
        public string? JobTitle { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public string EmploymentType { get; set; }

        public int? UnreadRequests { get; set; }
        public int? UnreadNotifications { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? NationalId { get; set; }
        public string? Address { get; set; }

        public DateTime? HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public decimal? Salary { get; set; }

        // Foreign keys
        public int DepartmentId { get; set; }
        public int ScheduleId { get; set; }

        // Navigation properties
        public virtual Department Department { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<LeaveRequest> LeaveRequests { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<EmployeeActionLog> EmployeeActionLogs { get; set; }

    }
}
