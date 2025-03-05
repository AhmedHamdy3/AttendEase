using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.BusinessLogic
{
    public class AttendanceService
    {

        private readonly string connectionString;

        public AttendanceService(string connectionString)
        {

            this.connectionString= connectionString;
        }
        
        public List<AttendanceSummary> getLast10DaysAttendanceSummary(int page)
        {
            List<AttendanceSummary> dailyAttendanceSummary = new List<AttendanceSummary>();
            DateTime date = DateTime.Today.AddDays(-10 * page);
            for (int i = 0; i < 10; ++i)
            {
                DateTime currDate = date.AddDays(-i);
                dailyAttendanceSummary.Add(GetSummaryAttendance(currDate, currDate));
            }
            return dailyAttendanceSummary;
        }

        public AttendanceSummary GetSummaryAttendance(DateTime startDate, DateTime endDate)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var attendanceData = context.Attendances
                .Where(attendance => attendance.AttendanceDate >= startDate && attendance.AttendanceDate <= endDate)
                .SelectMany(attendance => attendance.AttendanceAttendanceStatuses.Select(aas => aas.AttendanceStatus.Status));

                return new AttendanceSummary
                {
                    StartDate = startDate,
                    EndDate = endDate,
                    Present = attendanceData.Count(status => status == "Present"),
                    Absent = attendanceData.Count(status => status == "Absent"),
                    Late = attendanceData.Count(status => status == "Late"),
                    Early = attendanceData.Count(status => status == "Early")
                };
            }
        }
        public class AttendanceSummary
        {
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public int Present { get; set; }
            public int Absent { get; set; }
            public int Late { get; set; }
            public int Early { get; set; }

            //public override string ToString()
            //{
            //    //if (StartDate == EndDate)
            //    //    return $"{StartDate.ToShortDateString()}, {TotalDaysPresent}, {TotalDaysAbsent}, {TotalDaysLate}, {TotalDaysEarly}";
            //    //else
            //    //    return $"{StartDate.ToShortDateString()}, {EndDate.ToShortDateString()}, {TotalDaysPresent}, {TotalDaysAbsent}, {TotalDaysLate}, {TotalDaysEarly}";
            //}
        }
    }
}
