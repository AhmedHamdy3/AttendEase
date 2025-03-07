using AttendEase.BusinessLogic;
using AttendEase.Presentation.CustomControls;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendEase.Presentation.Attendance
{
    public partial class AttendanceSummary : Form
    {
        AttendanceService attendanceService;
        Table table;
        public AttendanceSummary()
        {
            InitializeComponent();

            var configBuilder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            attendanceService = new AttendanceService(connectionString);
            table = new Table(888, 570, 30, 240);
        }

        private void AttendanceSummary_Load(object sender, EventArgs e)
        {
            cb_summaryType.SelectedIndex = 0;
            this.Controls.Add(table.tablePanel);
            DailySelected();
        }
        private void DailySelected()
        {
            var dailyAttendanceSummary = attendanceService.GetPageOfDailyAttendanceSummary(0);
            table.fillTable(dailyAttendanceSummary, new[] { "Start Date", "End Date", "Prsent", "Absent", "Late", "Early" }, "Day", AttendanceInSpecificDay);
        }
        private void WeeklySelected()
        {
            var WeeklyAttendanceSummary = attendanceService.GetPageOfWeeklyAttendanceSummary(0);
            table.fillTable(WeeklyAttendanceSummary, new[] { "Start Date", "End Date", "Prsent", "Absent", "Late", "Early" }, "Period", AttendanceInSpecificWeek);
        }
        private void MonthlySelected()
        {
            var MonthyAttendanceSummary = attendanceService.GetPageOfMonthlyAttendanceSummary(0);
            table.fillTable(MonthyAttendanceSummary, new[] { "Start Date", "End Date", "Prsent", "Absent", "Late", "Early" }, "Period", AttendanceInSpecificMonth);
        }

        private void AttendanceInSpecificDay(DateTime StartDate, DateTime EndDate)
        {
            lbl_details_header.Text = $"Attendance for the Day: {StartDate: MMMM d, yyyy}";
            lbl_title.Visible = false;
            pb_back.Visible = true;
            btn_cb_summaryType.Visible = false;
            cb_summaryType.Visible = false;

            var attendanceDay = attendanceService.GetAttendanceInSpecificDay(StartDate);
            table.fillTable(attendanceDay, new[] { "Employee", "Department", "Status", "CheckIn", "CheckOut", "Late", "Early" }, "", null);
        }
        private void AttendanceInSpecificWeek(DateTime StartDate, DateTime EndDate)
        {
            lbl_details_header.Text = $"Attendance for the Week: {StartDate: MMMM d, yyyy} to {EndDate: MMMM d, yyyy}";
            commonBetweenWeekAndMonth(StartDate, EndDate);
        }

        private void AttendanceInSpecificMonth(DateTime StartDate, DateTime EndDate)
        {
            commonBetweenWeekAndMonth(StartDate, EndDate);
            lbl_details_header.Text = $"Attendance for the Month: {StartDate: MMMM d, yyyy} to {EndDate: MMMM d, yyyy}";
        }

        private void commonBetweenWeekAndMonth(DateTime StartDate, DateTime EndDate)
        {

            var attendancePeriod = attendanceService.GetAttendanceInSpecificPeriod(StartDate, EndDate);
            lbl_title.Visible = false;
            pb_back.Visible = true;
            btn_cb_summaryType.Visible = false;
            cb_summaryType.Visible = false;
            table.fillTable(attendancePeriod, new[] { "Employee", "Department", "Present", "Absent", "Late", "Early" }, "", null);
        }

        private void cb_summarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckTheValueOfComboBoxAndUpdateTheTable();
        }

        private void pb_back_Click(object sender, EventArgs e)
        {
            lbl_details_header.Text = "";
            lbl_title.Visible = true;
            pb_back.Visible = false;
            btn_cb_summaryType.Visible = true;
            cb_summaryType.Visible = true;

            CheckTheValueOfComboBoxAndUpdateTheTable();
        }

        private void CheckTheValueOfComboBoxAndUpdateTheTable()
        {
            if (cb_summaryType.SelectedIndex == 0)
            {
                DailySelected();
            }
            else if (cb_summaryType.SelectedIndex == 1)
            {
                WeeklySelected();
            }
            else if (cb_summaryType.SelectedIndex == 2)
            {
                MonthlySelected();
            }
        }
    }
}
