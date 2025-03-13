using AttendEase.BusinessLogic;
using AttendEase.Presentation.CustomControls;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.StyledXmlParser.Jsoup.Nodes;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AttendEase.BusinessLogic.AttendanceService;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace AttendEase.Presentation.Attendance
{
    public enum Flag
    {
        DailyAttendance,
        WeeklyAttendance,
        MonthlyAttendance,
        AttendanceDay,
        AttendanceWeek,
        AttendanceMonth
    }
    public partial class AttendanceSummary : Form
    {
        AttendanceService attendanceService;
        CustomTable table;
        Flag flag;
        int page;
        DateTime startDate, endDate;
        public AttendanceSummary()
        {
            InitializeComponent();

            var configBuilder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            attendanceService = new AttendanceService(connectionString);

            table = new CustomTable(888, 570, 30, 240);
            ccb_summaryType.SelectedIndex = 0;
            DailySelected();
            flag = Flag.DailyAttendance;
            page = 0;
            this.Controls.Add(table.tablePanel);
        }

        private void DailySelected()
        {
            flag = Flag.DailyAttendance;
            page = 0;
            var dailyAttendanceSummary = attendanceService.GetPageOfDailyAttendanceSummary(0);
            table.fillTable(dailyAttendanceSummary, new[] { "Start Date", "End Date", "Prsent", "Absent", "Late", "Early" }, "Day", AttendanceInSpecificDay, null);
        }
        private void WeeklySelected()
        {
            flag = Flag.WeeklyAttendance;
            page = 0;
            var WeeklyAttendanceSummary = attendanceService.GetPageOfWeeklyAttendanceSummary(0);
            table.fillTable(WeeklyAttendanceSummary, new[] { "Start Date", "End Date", "Prsent", "Absent", "Late", "Early" }, "Period", AttendanceInSpecificWeek, null);
        }
        private void MonthlySelected()
        {
            flag = Flag.MonthlyAttendance;
            page = 0;
            var MonthyAttendanceSummary = attendanceService.GetPageOfMonthlyAttendanceSummary(0);
            table.fillTable(MonthyAttendanceSummary, new[] { "Start Date", "End Date", "Prsent", "Absent", "Late", "Early" }, "Period", AttendanceInSpecificMonth, null);
        }

        private void AttendanceInSpecificDay(DateTime StartDate, DateTime EndDate)
        {
            lbl_details_header.Text = $"Attendance for the Day: {StartDate: MMMM d, yyyy}";
            lbl_title.Visible = false;
            btn_back.Visible = true;
            ccb_summaryType.Visible = false;

            flag = Flag.AttendanceDay;
            startDate = StartDate; endDate = EndDate;
            var attendanceDay = attendanceService.GetAttendanceInSpecificDay(StartDate);
            table.fillTable(attendanceDay, new[] { "Employee", "Department", "Status", "CheckIn", "CheckOut", "Late", "Early" }, "", null, null);
        }
        private void AttendanceInSpecificWeek(DateTime StartDate, DateTime EndDate)
        {
            lbl_details_header.Text = $"Attendance for the Week: {StartDate: MMMM d, yyyy} to {EndDate: MMMM d, yyyy}";
            flag = Flag.AttendanceWeek;
            startDate = StartDate; endDate = EndDate;
            commonBetweenWeekAndMonth(StartDate, EndDate);
        }

        private void AttendanceInSpecificMonth(DateTime StartDate, DateTime EndDate)
        {
            commonBetweenWeekAndMonth(StartDate, EndDate);
            flag = Flag.AttendanceMonth;
            startDate = StartDate; endDate = EndDate;
            lbl_details_header.Text = $"Attendance for the Month: {StartDate: MMMM d, yyyy} to {EndDate: MMMM d, yyyy}";
        }

        private void commonBetweenWeekAndMonth(DateTime StartDate, DateTime EndDate)
        {
            var attendancePeriod = attendanceService.GetAttendanceInSpecificPeriod(StartDate, EndDate);
            lbl_title.Visible = false;
            btn_back.Visible = true;
            ccb_summaryType.Visible = false;

            table.fillTable(attendancePeriod, new[] { "Employee", "Department", "Present", "Absent", "Late", "Early" }, "", null, null);
        }

        private void CheckTheValueOfComboBoxAndUpdateTheTable()
        {
            if (ccb_summaryType.SelectedIndex == 0)
            {
                DailySelected();
            }
            else if (ccb_summaryType.SelectedIndex == 1)
            {
                WeeklySelected();
            }
            else if (ccb_summaryType.SelectedIndex == 2)
            {
                MonthlySelected();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            lbl_details_header.Text = "";
            lbl_title.Visible = true;
            btn_back.Visible = false;
            ccb_summaryType.Visible = true;


            CheckTheValueOfComboBoxAndUpdateTheTable();
        }

        private void ccb_summaryType_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckTheValueOfComboBoxAndUpdateTheTable();

        }

        private void cbtn_exportPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set the file filter to show only PDF files
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1; // Default to PDF files
                saveFileDialog.RestoreDirectory = true; // Restore the previous directory
                saveFileDialog.Title = "Save PDF File"; // Dialog title
                saveFileDialog.DefaultExt = "pdf"; // Default file extension

                // Show the dialog and check if the user clicked OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName; // Get the selected file path
                    if (flag == Flag.DailyAttendance || flag == Flag.WeeklyAttendance || flag == Flag.MonthlyAttendance)
                    {
                        attendanceService.ExportPdf(page, flag.ToString(), filePath);
                    }
                    else if (flag == Flag.AttendanceDay)
                    {
                        attendanceService.ExportPdf(startDate, flag.ToString(), filePath);
                    }
                    else if (flag == Flag.AttendanceWeek || flag == Flag.AttendanceMonth)
                    {
                        attendanceService.ExportPdf(startDate, endDate, flag.ToString(), filePath);
                    }
                }
            }
        }

        private void cbtn_exportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.DefaultExt = "xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (flag == Flag.DailyAttendance || flag == Flag.WeeklyAttendance || flag == Flag.MonthlyAttendance)
                    {
                        attendanceService.ExportExcel(page, flag.ToString(), filePath);
                    }
                    else if (flag == Flag.AttendanceDay)
                    {
                        attendanceService.ExportExcel(startDate, flag.ToString(), filePath);
                    }
                    else if (flag == Flag.AttendanceWeek || flag == Flag.AttendanceMonth)
                    {
                        attendanceService.ExportExcel(startDate, endDate, flag.ToString(), filePath);
                    }
                }
            }
        }

        private void AttendanceSummary_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_exportMenu.Visible = cbtn_exportExcel.Visible = cbtn_exportPdf.Visible = false;

        }

        private void cbtn_export_Click(object sender, EventArgs e)
        {
            pnl_exportMenu.Visible = cbtn_exportExcel.Visible = cbtn_exportPdf.Visible = true;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
