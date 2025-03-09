using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AttendEase.BusinessLogic.AttendanceService;

namespace AttendEase.BusinessLogic
{
    public class AttendanceService
    {

        private readonly string connectionString;

        public AttendanceService(string connectionString)
        {

            this.connectionString= connectionString;
        }

        #region Attendance Summary Reports
        public List<AttendanceSummary> GetPageOfDailyAttendanceSummary(int page)
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

        public List<AttendanceSummary> GetPageOfWeeklyAttendanceSummary(int page)
        {
            List<AttendanceSummary> weeklyAttendanceSummary = new List<AttendanceSummary>();
            DateTime date = DateTime.Today;
            for (int i = 0; i < 10; ++i)
            {
                var week = GetPreviousWeek(date, i + 10 * page);
                AttendanceSummary attendanceSummary = GetSummaryAttendance(week.StartDate, week.EndDate);
                weeklyAttendanceSummary.Add(attendanceSummary);
            }
            return weeklyAttendanceSummary;
        }

        public List<AttendanceSummary> GetPageOfMonthlyAttendanceSummary(int page)
        {
            List<AttendanceSummary> monthlyAttendanceSummary = new List<AttendanceSummary>();
            DateTime date = DateTime.Today;
            for (int i = 0; i < 10; ++i)
            {
                var month = GetPreviousMonth(date, i + 10 * page);
                AttendanceSummary attendanceSummary = GetSummaryAttendance(month.StartDate, month.EndDate);
                monthlyAttendanceSummary.Add(attendanceSummary);
            }
            return monthlyAttendanceSummary;
        }
        #endregion
        
        #region Attendance Detailed Reports
        public List<EmployeeAttendanceInSpecificDay> GetAttendanceInSpecificDay(DateTime date)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                List<EmployeeAttendanceInSpecificDay> employeeAttendances = new List<EmployeeAttendanceInSpecificDay>();
                var attendances = context.Attendances.Where(attendance => attendance.AttendanceDate == date).ToList();
                foreach (var attendance in attendances)
                {
                    var status = attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Present") ? "Present" : "Absent";
                    var late = attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Late") ? "YES" : "NO";
                    var early = attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Early") ? "YES" : "NO";
                    var checkInTime = attendance.CheckInTime ?? new TimeSpan(0, 0, 0);
                    var checkOutTime = attendance.CheckOutTime ?? new TimeSpan(0, 0, 0);
                    
                    employeeAttendances.Add(new EmployeeAttendanceInSpecificDay()
                    {
                        Name = attendance.Employee.Name,
                        Department = attendance.Employee.Department.Name,
                        Status = status,
                        CheckInTime = checkInTime,
                        CheckOutTime = checkOutTime,
                        IsLate = late,
                        IsEarly = early,
                    });
                }
                return employeeAttendances;
            }
        }

        public List<EmployeeAttendanceInSpecificPeriod> GetAttendanceInSpecificPeriod(DateTime startDate, DateTime endDate)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                // Fetch all relevant data in a single query
                var attendanceData = context.Attendances
                    .Where(attendance => attendance.AttendanceDate >= startDate && attendance.AttendanceDate <= endDate)
                    .Select(attendance => new
                    {
                        Employee = attendance.Employee,
                        AttendanceStatuses = attendance.AttendanceAttendanceStatuses
                            .Select(aas => aas.AttendanceStatus.Status)
                            .ToList()
                    })
                    .ToList();

                // Group by employee and calculate attendance metrics
                var employeeAttendances = attendanceData
                    .GroupBy(ad => ad.Employee)
                    .Select(g => new EmployeeAttendanceInSpecificPeriod
                    {
                        Name = g.Key.Name,
                        Department = g.Key.Department.Name,
                        TotalDaysPresent = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Present"),
                        TotalDaysAbsent = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Absent"),
                        TotalDaysLate = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Late"),
                        TotalDaysEarly = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Early")
                    })
                    .ToList();

                return employeeAttendances;
            }
        }
        #endregion

        #region Late Arrivals & Early Departure
        public List<LateArrivalsAndEarlyDeparture> GetLateArrivalsAndEarlyDepartureInSpecificPeriod(DateTime startDate, DateTime endDate)
        {
            using(var context = new AttendEaseContext())
            {
                // Fetch all relevant data in a single query
                var attendanceData = context.Attendances
                    .Where(attendance => attendance.AttendanceDate >= startDate && attendance.AttendanceDate <= endDate)
                    .Select(attendance => new
                    {
                        Employee = attendance.Employee,
                        AttendanceStatuses = attendance.AttendanceAttendanceStatuses
                            .Select(aas => aas.AttendanceStatus.Status)
                            .ToList()
                    })
                    .ToList();

                // Group by employee and calculate attendance metrics
                var lateArrivalsAndEarlyDepartures = attendanceData
                    .GroupBy(ad => ad.Employee)
                    .Select(g => new LateArrivalsAndEarlyDeparture
                    {
                        Name = g.Key.Name,
                        Department = g.Key.Department.Name,
                        TotalDaysLate = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Late"),
                        TotalDaysEarly = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Early"),
                        Id = g.Key.EmployeeId
                    })
                    .Where(a => a.TotalDaysLate > 0 || a.TotalDaysEarly > 0)
                    .ToList();

                return lateArrivalsAndEarlyDepartures;
            }
        }

        public List<LateArrivalsAndEarlyDepartureForSpecificEmployee> GetLateArrivalsAndEarlyDepartureInSpecificPeriodForSpecificEmployee(DateTime startDate, DateTime endDate, int id)
        {
            using (var context = new AttendEaseContext())
            {
                // Fetch all relevant data in a single query
                var attendanceData = 
                    context.Employees.Where(employee => employee.EmployeeId == id).FirstOrDefault()?
                    .Attendances.Where(attendance => attendance.AttendanceDate >= startDate && attendance.AttendanceDate <= endDate)
                    .Where
                        (
                        attendance => attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Late") 
                        || 
                        attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Early")
                        )
                    .ToList();

                // 
                var lateArrivalsAndEarlyDepartureForSpecificEmployee = attendanceData
                    .Select(attendance => new LateArrivalsAndEarlyDepartureForSpecificEmployee
                    {
                        Name = attendance.Employee.Name,
                        Date = attendance.AttendanceDate,
                        CheckInTime = attendance.CheckInTime,
                        CheckOutTime = attendance.CheckOutTime,
                        TotalsHourOfWorking = attendance.CheckOutTime - attendance.CheckInTime,
                        LateOrEarly = (
                            !attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Late")
                            ? "Early"
                            : !attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Early")
                            ? "Late"
                            : "Late & Early"
                            )
                    })
                    .ToList();

                return lateArrivalsAndEarlyDepartureForSpecificEmployee;
            }
        }
        #endregion

        #region Frequent Absence
        public List<FrequentAbsence> GetFrequentAbsenceInSpecificPeriod(DateTime startDate, DateTime endDate)
        {
            using (var context = new AttendEaseContext())
            {
                // Fetch all relevant data in a single query
                var attendanceData = context.Attendances
                    .Where(attendance => attendance.AttendanceDate >= startDate && attendance.AttendanceDate <= endDate)
                    .Select(attendance => new
                    {
                        Employee = attendance.Employee,
                        AttendanceStatuses = attendance.AttendanceAttendanceStatuses
                            .Select(aas => aas.AttendanceStatus.Status)
                            .ToList()
                    })
                    .ToList();

                var FrequentAbsences = attendanceData
                    .GroupBy(ad => ad.Employee)
                    .Select(g => new
                    {
                        Name = g.Key.Name,
                        Department = g.Key.Department.Name,
                        TotalDaysPresent = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Present"),
                        TotalDaysAbsent = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Absent"),
                        Id = g.Key.EmployeeId
                    }).
                    Select(ab => new FrequentAbsence
                    {
                        Name = ab.Name,
                        Department = ab.Department,
                        TotalDaysAbsent = ab.TotalDaysAbsent,
                        TotalDaysPresent = ab.TotalDaysPresent,
                        AbsencePrecentage = Math.Round((double)ab.TotalDaysAbsent / (ab.TotalDaysPresent + ab.TotalDaysAbsent) * 100),
                        Id = ab.Id
                    })
                    .Where(a => a.AbsencePrecentage > 10 )
                    .ToList();

                return FrequentAbsences;
            }
        }
        #endregion

        #region Helper Functions
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
        public static DateRange GetPreviousWeek(DateTime date, int cntOfWeeksAgo)
        {
            DateTime StartDate = date.AddDays(-((int)date.DayOfWeek + 2) - (7 * cntOfWeeksAgo));
            DateTime EndDate = (date < StartDate.AddDays(6)) ? date : StartDate.AddDays(6);
            return new DateRange { StartDate = StartDate, EndDate = EndDate };
        }
        public static DateRange GetPreviousMonth(DateTime date, int cntOfMonthsAgo)
        {
            DateTime StartDate = new DateTime(date.Year, date.Month, 1).AddMonths(-cntOfMonthsAgo);
            DateTime EndDate = (date < StartDate.AddMonths(1).AddDays(-1)) ? date : StartDate.AddMonths(1).AddDays(-1);

            return new DateRange { StartDate = StartDate, EndDate = EndDate };
        }
        #endregion

        #region Data Transfer Objects
            public class AttendanceSummary
            {
                public DateTime StartDate { get; set; }
                public DateTime EndDate { get; set; }
                public int Present { get; set; }
                public int Absent { get; set; }
                public int Late { get; set; }
                public int Early { get; set; }
            }

            public class DateRange
            {
                public DateTime StartDate { get; set; }
                public DateTime EndDate { get; set; }
            }

            public class EmployeeAttendanceInSpecificPeriod
            {
                public string Name { get; set; }
                public string Department { get; set; }
                public int TotalDaysPresent { get; set; }
                public int TotalDaysAbsent { get; set; }
                public int TotalDaysLate { get; set; }
                public int TotalDaysEarly { get; set; }
            }

            public class EmployeeAttendanceInSpecificDay
            {
                public string Name { get; set; }
                public string Department { get; set; }
                public string Status { get; set; }
                public TimeSpan CheckInTime { get; set; }
                public TimeSpan CheckOutTime { get; set; }
                public string IsLate { get; set; }
                public string IsEarly { get; set; }
            }

            public class LateArrivalsAndEarlyDeparture
            {
                public string Name { get; set; }
                public string Department{ get; set; }
                public int TotalDaysLate { get; set;}
                public int TotalDaysEarly { get; set; }
                public int Id { get; set; }
            }
            public class LateArrivalsAndEarlyDepartureForSpecificEmployee
            {
                public string Name{ get; set; }

                public DateTime Date { get; set; }
                public TimeSpan? CheckInTime { get; set; }
                public TimeSpan? CheckOutTime { get; set; }
                public TimeSpan? TotalsHourOfWorking { get; set; }
                public string LateOrEarly { get; set; }
            }

        public class FrequentAbsence
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public int TotalDaysPresent { get; set; }
            public int TotalDaysAbsent { get; set; }
            public double AbsencePrecentage { get; set; }
            public int Id { get; set; }
        }
        #endregion

    }
}
