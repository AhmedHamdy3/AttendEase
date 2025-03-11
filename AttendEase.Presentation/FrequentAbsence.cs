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

namespace AttendEase.Presentation
{
    public partial class FrequentAbsence : Form
    {
        AttendanceService attendanceService;
        Table table;
        int isDetails = 0;
        int id = -1;
        public FrequentAbsence()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            attendanceService = new AttendanceService(connectionString);
        }

        private void FrequentAbsence_Load(object sender, EventArgs e)
        {
            table = new Table(888, 570, 30, 240);
            var month = AttendanceService.GetPreviousMonth(DateTime.Now, 0);

            dtp_startDate.Value = month.StartDate;
            dtp_endDate.Value = month.EndDate;

            ShowFrequentAbsence();
            this.Controls.Add(table.tablePanel);

        }


        //if (isDetails == 0)
        //{
        //    ShowFrequentAbsence();
        //}
        //else if (isDetails == 1)
        //{
        //    ShowFrequentAbsenceDetail();
        //}




        private void GetAbsencesForSpecificEmployee(int id)
        {
            isDetails = 1;
            this.id = id;
            table.tablePanel.Location = new Point(30, 280);
            table.tablePanel.Size = new Size(888, 530);
            btn_back.Visible = true;
            ShowFrequentAbsenceDetail();
        }
        private void ShowFrequentAbsence()
        {
            var FrequentAbsence = attendanceService.GetFrequentAbsenceInSpecificPeriod(dtp_startDate.Value, dtp_endDate.Value);
            table.fillTable(FrequentAbsence, new[] { "Employee", "Department", "Present", "Absent", "Precentage" }, "FrequentAbsences", null, GetAbsencesForSpecificEmployee);
        }
        private void ShowFrequentAbsenceDetail()
        {
            var AbsencesForSpecificEmployee = attendanceService.GetAbsencesSpecificPeriodForSpecificEmployee(dtp_startDate.Value, dtp_endDate.Value, this.id);
            table.fillTable(AbsencesForSpecificEmployee, new string[] { "Employee", "Date", "Reaseon of Absence" }, "", null, null);
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            isDetails = 0;
            table.tablePanel.Location = new Point(30, 240);
            table.tablePanel.Size = new Size(888, 570);
            btn_back.Visible = false;
            ShowFrequentAbsence();
        }

        private void dtp_startDate_ValueChanged(object sender, EventArgs e)
        {
            if (isDetails == 0)
            {
                ShowFrequentAbsence();
            }
            else if (isDetails == 1)
            {
                ShowFrequentAbsenceDetail();
            }
        }

        private void dtp_endDate_ValueChanged(object sender, EventArgs e)
        {
            if (isDetails == 0)
            {
                ShowFrequentAbsence();
            }
            else if (isDetails == 1)
            {
                ShowFrequentAbsenceDetail();
            }
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            isDetails = 0;
            table.tablePanel.Location = new Point(30, 240);
            table.tablePanel.Size = new Size(888, 570);
            btn_back.Visible = false;
            ShowFrequentAbsence();
        }
    }
}
