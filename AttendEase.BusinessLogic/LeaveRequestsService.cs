using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AttendEase.BusinessLogic.AttendanceService;

namespace AttendEase.BusinessLogic
{
    public class LeaveRequestsService
    {
        private readonly string connectionString;
        public LeaveRequestsService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<LeaveRequestForSpecificEmployee> GetLeaveRequests(int id)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var leaveRequests =
                context.LeaveRequests.Where(leaveRequest => leaveRequest.EmployeeId == id)
                .OrderByDescending(leaveRequests => leaveRequests.CreationTime)
                .Select(leaveRequest => new LeaveRequestForSpecificEmployee
                {
                    RequestType = leaveRequest.LeaveType,
                    StartDate = leaveRequest.StartDate,
                    EndDate = leaveRequest.EndDate,
                    Duration = (leaveRequest.EndDate - leaveRequest.StartDate).Days,
                    Status = leaveRequest.Status,
                })
                .ToList();

                return leaveRequests;
            }
        }
        #region Data Transfer Objects
        public class LeaveRequestForSpecificEmployee
        {
            public string RequestType { get; set; }
            public int Duration { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public string Status { get; set; }
        }
            #endregion
    }
}
