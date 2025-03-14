using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AttendEase.BusinessLogic.AttendanceService;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

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
                    Duration = (leaveRequest.EndDate - leaveRequest.StartDate).Days + 1,
                    Status = leaveRequest.Status,
                })
                .ToList();

                return leaveRequests;
            }
        }

        public void AddRequest(LeaveRequest leaveRequest)
        {
            using (var context = new AttendEaseContext())
            {
                context.LeaveRequests.Add(leaveRequest);
                context.SaveChanges();
            }    
        }

        public List<Request> GetLeaveRequests()
        {

            using (var context = new AttendEaseContext())
            {
                var requests = (from lr in context.LeaveRequests
                                join emp in context.Employees on lr.EmployeeId equals emp.EmployeeId
                                orderby lr.CreationTime descending
                                select new Request

                                {
                                    Id = lr.LeaveRequestId,
                                    Title = lr.Title,
                                    Description = lr.Description,
                                    Status = lr.Status,
                                    StartDate = lr.StartDate,
                                    EndDate = lr.EndDate,
                                    LeaveType = lr.LeaveType,
                                    IsRead = lr.IsRead,
                                    CreationTime = lr.CreationTime,
                                    Name = emp.Name,
                                    ProfileImage = emp.ProfileImage,
                                    JobTitle = emp.JobTitle,
                                }).ToList();
                return requests;
            }
        }

        public List<Request> GetPendingLeaveRequests()
        {

            using (var context = new AttendEaseContext())
            {
                var requests = (from lr in context.LeaveRequests
                                join emp in context.Employees on lr.EmployeeId equals emp.EmployeeId
                                where lr.Status == "Pending"
                                orderby lr.CreationTime descending
                                select new Request

                                {
                                    Id = lr.LeaveRequestId,
                                    Title = lr.Title,
                                    Description = lr.Description,
                                    Status = lr.Status,
                                    StartDate = lr.StartDate,
                                    EndDate = lr.EndDate,
                                    LeaveType = lr.LeaveType,
                                    IsRead = lr.IsRead,
                                    CreationTime = lr.CreationTime,
                                    Name = emp.Name,
                                    ProfileImage = emp.ProfileImage,
                                    JobTitle = emp.JobTitle,
                                }).ToList();
                return requests;
            }
        }

        public Request GetRequestById(int id)
        {
            using (var context = new AttendEaseContext())
            {
                var request = (from lr in context.LeaveRequests
                               join emp in context.Employees on lr.EmployeeId equals emp.EmployeeId
                               where lr.LeaveRequestId == id
                               select new Request
                               {
                                   Id = lr.LeaveRequestId,
                                   Title = lr.Title,
                                   Description = lr.Description,
                                   Status = lr.Status,
                                   StartDate = lr.StartDate,
                                   EndDate = lr.EndDate,
                                   LeaveType = lr.LeaveType,
                                   IsRead = lr.IsRead,
                                   CreationTime = lr.CreationTime,
                                   Name = emp.Name,
                                   ProfileImage = emp.ProfileImage,
                                   JobTitle = emp.JobTitle
                               }).FirstOrDefault();
                return request;
            }
        }

        public void UpdateRequest(int id)
        {
            using (var context = new AttendEaseContext())
            {
                LeaveRequest leaveRequest = context.LeaveRequests.Where(lr => lr.LeaveRequestId == id).SingleOrDefault();
                leaveRequest.IsRead = true;
                context.SaveChanges();
            }

        }

        public void UpdateRequest(int id, string status)
        {

            using (var context = new AttendEaseContext())
            {
                LeaveRequest leaveRequest = context.LeaveRequests.Where(lr => lr.LeaveRequestId == id).SingleOrDefault();

                leaveRequest.IsRead = true;
                leaveRequest.Status = status;
                //if (status == "Accepted")
                //{
                //    leaveRequest.Status = status;
                //}
                //else if (status == "Rejected")
                //{
                //    leaveRequest.Status = status;
                //}
                //else
                //{
                //    leaveRequest.Status = "Pending";
                //}
                context.SaveChanges();
            }

        }

        public void DeleteRequest(int id)
        {
            using (var context = new AttendEaseContext())
            {
                LeaveRequest leaveRequest = context.LeaveRequests.Where(lr => lr.LeaveRequestId == id).SingleOrDefault();

                context.LeaveRequests.Remove(leaveRequest);
                context.SaveChanges();
            }
        }

        public int CountOfUnreadedRequests()
        {
            using (var context = new AttendEaseContext())
            {
                int unreadedRequests = context.LeaveRequests.Where(lr => lr.IsRead == false).Count();
                return unreadedRequests;
            }
        }


        #region Data Transfer Objects
        public class Request
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public DateTime CreationTime { get; set; }
            public string LeaveType { get; set; }
            public bool IsRead { get; set; }
            public string Name { get; set; }
            public string JobTitle { get; set; }
            public byte[]? ProfileImage { get; set; }
        }

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
