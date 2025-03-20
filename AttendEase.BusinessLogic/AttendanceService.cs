using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Pdf;
using iText.Layout.Properties;
using System.IO;
using static AttendEase.BusinessLogic.AttendanceService;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using Microsoft.EntityFrameworkCore.Diagnostics;
using OfficeOpenXml;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AttendEase.BusinessLogic
{
    public class AttendanceService
    {

        private readonly string connectionString;
        EmployeesService employeesService;

        public AttendanceService(string connectionString)
        {

            this.connectionString= connectionString;
            employeesService = new EmployeesService(connectionString);
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
                        CheckIn = checkInTime,
                        CheckOut = checkOutTime,
                        Late = late,
                        Early = early,
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
                        Present = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Present"),
                        Absent = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Absent"),
                        Late = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Late"),
                        Early = g.SelectMany(ad => ad.AttendanceStatuses).Count(status => status == "Early")
                    })
                    .ToList();

                return employeeAttendances;
            }
        }
        #endregion

        #region Export Attendance Files
        public void ExportPdf(int page, string type, string path)
        {
            if(type == "DailyAttendance")
            {
                var data = GetPageOfDailyAttendanceSummary(page);
                ExportToPdf<AttendanceSummary>(data, path, "Daily Attendance Summary");
            }
            else if (type == "WeeklyAttendance")
            {
                var data = GetPageOfWeeklyAttendanceSummary(page);
                ExportToPdf<AttendanceSummary>(data, path, "Weekly Attendance Summary");
            }
            else if (type == "MonthlyAttendance")
            {
                var data = GetPageOfMonthlyAttendanceSummary(page);
                ExportToPdf<AttendanceSummary>(data, path, "Monthly Attendance Summary");
            }
        }
        public void ExportPdf(DateTime date, string type, string path)
        {
                var data = GetAttendanceInSpecificDay(date);
                ExportToPdf<EmployeeAttendanceInSpecificDay>(data, path, $"Attendance Report For {date.ToShortDateString()}");
        }
        public void ExportPdf(DateTime startDate, DateTime endDate, string type, string path)
        {
            var data = GetAttendanceInSpecificPeriod(startDate, endDate);
            if (type == "AttendanceWeek")
            {
                ExportToPdf<EmployeeAttendanceInSpecificPeriod>(data, path, $"Attendance Report For The Week: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}");
            }
            else if(type == "AttendanceMonth")
            {
                ExportToPdf<EmployeeAttendanceInSpecificPeriod>(data, path, $"Attendance Report For The Month: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}");
            }
        }
        public void ExportExcel(int page, string type, string path)
        {
            if (type == "DailyAttendance")
            {
                var data = GetPageOfDailyAttendanceSummary(page);
                ExportToExcel<AttendanceSummary>(data, path, "Daily Attendance Summary");
            }
            else if (type == "WeeklyAttendance")
            {
                var data = GetPageOfWeeklyAttendanceSummary(page);
                ExportToExcel<AttendanceSummary>(data, path, "Weekly Attendance Summary");
            }
            else if (type == "MonthlyAttendance")
            {
                var data = GetPageOfMonthlyAttendanceSummary(page);
                ExportToExcel<AttendanceSummary>(data, path, "Monthly Attendance Summary");
            }
        }
        public void ExportExcel(DateTime date, string type, string path)
        {
            var data = GetAttendanceInSpecificDay(date);
            ExportToExcel<EmployeeAttendanceInSpecificDay>(data, path, $"Attendance Report For {date.ToShortDateString()}");
        }
        public void ExportExcel(DateTime startDate, DateTime endDate, string type, string path)
        {
            var data = GetAttendanceInSpecificPeriod(startDate, endDate);
            if (type == "AttendanceWeek")
            {
                ExportToExcel<EmployeeAttendanceInSpecificPeriod>(data, path, $"Attendance Report For The Week: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}");
            }
            else if (type == "AttendanceMonth")
            {
                ExportToExcel<EmployeeAttendanceInSpecificPeriod>(data, path, $"Attendance Report For The Month: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}");
            }
        }
        public void arrivalsExportPdf(DateTime startDate, DateTime endDate, string path, int id = -1)
        {
            if(id == -1)
            {
                var data = GetLateArrivalsAndEarlyDepartureInSpecificPeriod(startDate, endDate);
                ExportToPdf(data, path, $"Late Arrivals Report For The Period: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 1);
            }
            else
            {
                Employee? employee = employeesService.GetEmployee(id);
                var data = GetLateArrivalsAndEarlyDepartureInSpecificPeriodForSpecificEmployee(startDate, endDate, id);
                ExportToPdf(data, path, $"Late Arrivals Report For {employee?.Name}: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 0);
            }
        }
        public void arrivalsExportExcel(DateTime startDate, DateTime endDate, string path, int id = -1)
        {
            if (id == -1)
            {
                var data = GetLateArrivalsAndEarlyDepartureInSpecificPeriod(startDate, endDate);
                ExportToExcel(data, path, $"Late Arrivals Report For The Period: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 1);
            }
            else
            {
                Employee? employee = employeesService.GetEmployee(id);
                var data = GetLateArrivalsAndEarlyDepartureInSpecificPeriodForSpecificEmployee(startDate, endDate, id);
                ExportToExcel(data, path, $"Late Arrivals Report For {employee?.Name}: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 0);
            }
        }
        public void absenceExportPdf(DateTime startDate, DateTime endDate, string path, int id = -1)
        {
            if (id == -1)
            {
                var data = GetFrequentAbsenceInSpecificPeriod(startDate, endDate);
                ExportToPdf(data, path, $"Frequent Absence Report For The Period: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 1);
            }
            else
            {
                Employee? employee = employeesService.GetEmployee(id);
                var data = GetAbsencesSpecificPeriodForSpecificEmployee(startDate, endDate, id);
                ExportToPdf(data, path, $"Frequent Absence Report For {employee?.Name}: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 0);
            }
        }
        public void absenceExportExcel(DateTime startDate, DateTime endDate, string path, int id = -1)
        {
            if (id == -1)
            {
                var data = GetFrequentAbsenceInSpecificPeriod(startDate, endDate);
                ExportToExcel(data, path, $"Frequent Absence Report For The Period: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 1);
            }
            else
            {
                Employee? employee = employeesService.GetEmployee(id);
                var data = GetAbsencesSpecificPeriodForSpecificEmployee(startDate, endDate, id);
                ExportToExcel(data, path, $"Frequent Absence Report For {employee?.Name}: \nFrom {startDate.ToShortDateString()} To {endDate.ToShortDateString()}", 0);
            }
        }
        #endregion

        #region Late Arrivals & Early Departure
        public List<LateArrivalsAndEarlyDeparture> GetLateArrivalsAndEarlyDepartureInSpecificPeriod(DateTime startDate, DateTime endDate)
        {
            using(var context = new AttendEaseContext(this.connectionString))
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
            using (var context = new AttendEaseContext(this.connectionString))
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
                        CheckIn = attendance.CheckInTime,
                        CheckOut = attendance.CheckOutTime,
                        WorkingHours = attendance.CheckOutTime - attendance.CheckInTime,
                        Status = (
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
                        Present = ab.TotalDaysPresent,
                        Absent = ab.TotalDaysAbsent,
                        AbsencePrecentage = Math.Round((double)ab.TotalDaysAbsent / (ab.TotalDaysPresent + ab.TotalDaysAbsent) * 100),
                        Id = ab.Id
                    })
                    .Where(a => a.AbsencePrecentage > 10 )
                    .ToList();

                return FrequentAbsences;
            }
        }

        public List<EmployeeAbsences> GetAbsencesSpecificPeriodForSpecificEmployee(DateTime startDate, DateTime endDate, int id)
        {
            using(var context = new AttendEaseContext(this.connectionString))
            {
                var attendanceData =
                context.Employees.Where(employee => employee.EmployeeId == id).FirstOrDefault()?
                .Attendances.Where(attendance => attendance.AttendanceDate >= startDate && attendance.AttendanceDate <= endDate)
                .Where(attendance => attendance.AttendanceAttendanceStatuses.Any(aas => aas.AttendanceStatus.Status == "Absent"))
                .ToList();
                
                var employeeAbcences = attendanceData.Select( attendance => new EmployeeAbsences()
                    {
                        Name = attendance.Employee.Name,
                        date = attendance.AttendanceDate,
                        ReasonOfAbsence = null // ************************************************************************ update this
                })
                    .ToList();

                return employeeAbcences;
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

        public void ExportToPdf<T>(List<T> data, string filePath, string Header = "", int substractedColumns = 0)
        {
            using (PdfWriter writer = new PdfWriter(filePath))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Add a header to the document
                    Paragraph header = new Paragraph($"{Header}")
                        .SetTextAlignment(TextAlignment.CENTER) // Center-align the header text
                        .SetFontSize(18); // Set the font size
                    header.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD)); // Make the text bold (optional)
                    document.Add(header);

                    // Add some space between the header and the table
                    document.Add(new Paragraph("\n")); // Add a blank line or use SetMarginBottom to add space

                    // Create a table with the number of columns equal to the properties of T
                    iText.Layout.Element.Table table = new iText.Layout.Element.Table(UnitValue.CreatePercentArray(typeof(T).GetProperties().Length - substractedColumns)).UseAllAvailableWidth();

                    // Add headers
                    foreach (var prop in typeof(T).GetProperties())
                    {
                        // Skip the ID Column
                        if (prop.Name == "Id") continue;
                        Paragraph p = new Paragraph($"{prop.Name}")
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetFontSize(12);
                        p.SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD));
                        table.AddHeaderCell(p);
                    }

                    // Add data rows
                    foreach (var item in data)
                    {
                        foreach (var prop in typeof(T).GetProperties())
                        {
                            // Skip the ID Column
                            if (prop.Name == "Id") continue;

                            var value = prop.GetValue(item);
                            string cellValue;

                            // Check if the property type is DateTime
                            if (value is DateTime dateTimeValue)
                            {
                                // Format the DateTime to show only the date part
                                cellValue = dateTimeValue.ToShortDateString(); // or use .ToString("yyyy-MM-dd") for a specific format
                            }
                            else
                            {
                                // For non-DateTime values, use the default ToString() or an empty string if null
                                cellValue = value?.ToString() ?? "-";
                            }
                            if (prop.Name == "AbsencePrecentage") cellValue += "%";
                            table.AddCell(cellValue);
                        }
                    }

                    document.Add(table);
                }
            }
        }

        public void ExportToExcel<T>(List<T> data, string filePath, string Header="", int substractedColumns = 0)
        {
            // Set the EPPlus license context (required for EPPlus 5+)
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Create a new Excel package
            using (var package = new ExcelPackage())
            {
                // Get the properties of the class (columns)
                var properties = typeof(T).GetProperties();
                // Add a worksheet to the Excel package
                var worksheet = package.Workbook.Worksheets.Add("Sheet1");

                // Add a header string in the first row
                worksheet.Cells[1, 1].Value = Header;

                // Merge the first row for the header (optional)
                worksheet.Cells[1, 1, 1, typeof(T).GetProperties().Length - substractedColumns].Merge = true;

                // Format the header row
                using (var headerRange = worksheet.Cells[1, 1, 1, typeof(T).GetProperties().Length - substractedColumns])
                {
                    headerRange.Style.Font.Bold = true; // Make the header bold
                    headerRange.Style.Font.Size = 14; // Set the font size
                    headerRange.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center; // Center-align the header
                }

                // Add headers (column names)
                for (int i = 0; i < properties.Length; i++)
                {
                    if (properties[i].Name == "Id") continue;
                    worksheet.Cells[2, i + 1].Value = properties[i].Name;
                    // Format the column header (bold and larger font)
                    worksheet.Cells[2, i + 1].Style.Font.Bold = true;
                    worksheet.Cells[2, i + 1].Style.Font.Size = 12;
                }

                // Add data rows
                for (int i = 0; i < data.Count; i++)
                {
                    var item = data[i];
                    for (int j = 0; j < properties.Length; j++)
                    {
                        if(properties[j].Name == "Id") continue;

                        var value = properties[j].GetValue(item);
                        string cellValue;
                        // Check if the property type is DateTime
                        if (value is DateTime dateTimeValue)
                        {
                            // Format the DateTime to show only the date part
                            cellValue = dateTimeValue.ToShortDateString(); // or use .ToString("yyyy-MM-dd") for a specific format
                        }
                        else
                        {
                            // For non-DateTime values, use the default ToString() or an empty string if null
                            cellValue = value?.ToString() ?? "-";
                        }
                        if (properties[j].Name == "AbsencePrecentage") cellValue += "%";

                        worksheet.Cells[i + 3, j + 1].Value = cellValue;
                    }
                }

                // Auto-fit columns
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();
                // Save the Excel file
                var fileInfo = new FileInfo(filePath);
                package.SaveAs(fileInfo);
            }
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
            public int Present { get; set; }
            public int Absent { get; set; }
            public int Late { get; set; }
            public int Early { get; set; }
        }

        public class EmployeeAttendanceInSpecificDay
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public string Status { get; set; }
            public TimeSpan CheckIn { get; set; }
            public TimeSpan CheckOut { get; set; }
            public string Late { get; set; }
            public string Early { get; set; }
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
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public TimeSpan? CheckIn { get; set; }
            public TimeSpan? CheckOut { get; set; }
            public TimeSpan? WorkingHours { get; set; }
            public string Status { get; set; }
        }

        public class FrequentAbsence
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public int Present { get; set; }
            public int Absent { get; set; }
            public double AbsencePrecentage { get; set; }
            public int Id { get; set; }
        }

        public class EmployeeAbsences
        {
            public string Name { get; set; }
            public DateTime date { get; set; }
            public string ReasonOfAbsence { get; set; }
        }
        #endregion


        #region  CheckIn/Out
        public void HrCheckIn(int id)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var checkIn = context.Attendances.FirstOrDefault(a => a.EmployeeId == id);
                checkIn.CheckInTime = DateTime.Now.TimeOfDay;
                IsLate(id, (TimeSpan)checkIn.CheckInTime);

                context.SaveChanges();

            }
        }


        public void HrCheckOut(int id)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var Hr = context.Attendances.FirstOrDefault(a => a.EmployeeId == id);
                Hr.CheckOutTime = DateTime.Now.TimeOfDay;
                IsLeftEarly(id, (TimeSpan)Hr.CheckOutTime);

                context.SaveChanges();

            }
        }

        public bool HasCheckedIn(int id)
        {
            using(var context = new AttendEaseContext(this.connectionString))
            {
                var Hr = context.Attendances.FirstOrDefault(a=>a.EmployeeId==id);
                if (Hr == null)
                {
                    return false;
                }
                if (Hr.CheckInTime != null)
                {
                    return true;
                }
                return false;
            }
        }


        public bool HasCheckedOut(int id)
        {
            using (var context = new AttendEaseContext())
            {
                var Hr = context.Attendances.FirstOrDefault(a => a.EmployeeId == id);
                if (Hr == null)
                {
                    return false;
                }
                if (Hr.CheckOutTime != null)
                {
                    return true;
                }
                return false;
            }
        }



        public void IsLate(int id, TimeSpan checkin)
        {
            using (var context = new AttendEaseContext())
            {
                var today = DateTime.Now.Date;
                var dayOfWeek = today.DayOfWeek.ToString();

                var x = (from e in context.Employees
                         join s in context.Schedules on e.ScheduleId equals s.ScheduleId
                         join swd in context.ScheduleWorkDays on s.ScheduleId equals swd.ScheduleId
                         join wd in context.WorkDays on swd.WorkDayId equals wd.WorkDayId

                         where e.EmployeeId == id
                         where wd.DayOfWeek == dayOfWeek
                         select new
                         {

                             wd.DayOfWeek,
                             wd.WorkDayId,
                             wd.StartTime,
                             wd.EndTime


                         }).FirstOrDefault();

                if (x != null)
                {
                    if (checkin > x.StartTime)
                    {
                        var attendance = context.Attendances
                     .FirstOrDefault(a => a.EmployeeId == id && a.AttendanceDate.Date == today);

                        if (attendance != null)
                        {

                            var lateStatus = context.AttendanceStatuses
                                .FirstOrDefault(s => s.Status == "Late");

                            if (lateStatus != null)
                            {

                                var attendanceStatusLink = new AttendanceAttendanceStatus
                                {
                                    AttendanceId = attendance.AttendanceId,
                                    AttendanceStatusId = lateStatus.AttendanceStatusId
                                };

                                context.AttendanceAttendanceStatuses.Add(attendanceStatusLink);
                                context.SaveChanges();
                            }



                        }
                    }


                }
               
            }
        }
        public void IsLeftEarly(int id, TimeSpan checkout)
        {
            using (var context = new AttendEaseContext())
            {
                var today = DateTime.Now.Date;
                var dayOfWeek = today.DayOfWeek.ToString();

                var x = (from e in context.Employees
                         join s in context.Schedules on e.ScheduleId equals s.ScheduleId
                         join swd in context.ScheduleWorkDays on s.ScheduleId equals swd.ScheduleId
                         join wd in context.WorkDays on swd.WorkDayId equals wd.WorkDayId
                         where e.EmployeeId == id && wd.DayOfWeek == dayOfWeek
                         select new
                         {
                             wd.DayOfWeek,
                             wd.WorkDayId,
                             wd.StartTime,
                             wd.EndTime
                         }).FirstOrDefault();

                if (x != null)
                {
                    if (checkout < x.EndTime)
                    {

                        var attendance = context.Attendances
                            .FirstOrDefault(a => a.EmployeeId == id && a.AttendanceDate.Date == today);

                        if (attendance != null)
                        {

                            var leftEarlyStatus = context.AttendanceStatuses
                                .FirstOrDefault(s => s.Status == "Left Early");

                            if (leftEarlyStatus != null)
                            {

                                var attendanceStatusLink = new AttendanceAttendanceStatus
                                {
                                    AttendanceId = attendance.AttendanceId,
                                    AttendanceStatusId = leftEarlyStatus.AttendanceStatusId
                                };

                                context.AttendanceAttendanceStatuses.Add(attendanceStatusLink);
                                context.SaveChanges();
                            }
                        }
                    }
                }
            }
        }
#endregion
    }
}
