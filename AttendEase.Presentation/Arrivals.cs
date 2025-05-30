﻿using AttendEase.BusinessLogic;
using AttendEase.Presentation.Attendance;
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
    public enum Flag
    {
        Arrivals,
        EmployeeArrivals
    }
    public partial class Arrivals : Form
    {
        AttendanceService attendanceService;
        EmployeesService employeesService;
        CustomTable table;
        int isDetails = 0;
        int id = -1;
        public Arrivals()
        {
            InitializeComponent();

            var configBuilder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            attendanceService = new AttendanceService(connectionString);
            employeesService = new EmployeesService(connectionString);

        }

        private void Arrivals_Load(object sender, EventArgs e)
        {
            table = new CustomTable(888, 570, 30, 240);
            var month = AttendanceService.GetPreviousMonth(DateTime.Now, 0);

            cdtp_startDate.Value = month.StartDate;
            cdtp_endDate.Value = month.EndDate;
            ShowArrivals();
            this.Controls.Add(table.tablePanel);
        }

        private void GetLateAndEarlyForSpecificEmployee(int id)
        {
            isDetails = 1;
            this.id = id;
            table.tablePanel.Location = new Point(30, 280);
            table.tablePanel.Size = new Size(888, 530);
            btn_back.Visible = true;
            lbl_title.Visible = false;
            lbl_details_header.Text = $"Late Arrivals and Early Departures - {employeesService.GetEmployee(id).Name}";
            ShowArrivalsDetail();
        }

        private void ShowArrivals()
        {
            var lateArrivalsAndEarlyDeparture = attendanceService.GetLateArrivalsAndEarlyDepartureInSpecificPeriod(cdtp_startDate.Value, cdtp_endDate.Value);
            table.fillTable(lateArrivalsAndEarlyDeparture, new[] { "Employee", "Department", "Late", "Early" }, "Arrivals", null, GetLateAndEarlyForSpecificEmployee);
        }
        private void ShowArrivalsDetail()
        {
            var lateArrivalsAndEarlyDepartureForSpecificEmployee = attendanceService.GetLateArrivalsAndEarlyDepartureInSpecificPeriodForSpecificEmployee(cdtp_startDate.Value, cdtp_endDate.Value, this.id);
            table.fillTable(lateArrivalsAndEarlyDepartureForSpecificEmployee, new string[] { "Employee", "Date", "Check In", "Check Out", "Total Time", "type" }, "", null, null);
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            isDetails = 0;
            id = -1;
            table.tablePanel.Location = new Point(30, 240);
            table.tablePanel.Size = new Size(888, 570);
            btn_back.Visible = false;
            lbl_details_header.Text = "";
            lbl_title.Visible = true;
            ShowArrivals();
        }

        private void cdtp_startDate_ValueChanged(object sender, EventArgs e)
        {
            if (isDetails == 0)
            {
                ShowArrivals();
            }
            else if (isDetails == 1)
            {
                ShowArrivalsDetail();
            }
        }

        private void cdtp_endDate_ValueChanged(object sender, EventArgs e)
        {
            if (isDetails == 0)
            {
                ShowArrivals();
            }
            else if (isDetails == 1)
            {
                ShowArrivalsDetail();
            }
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
                    attendanceService.arrivalsExportPdf(cdtp_startDate.Value, cdtp_endDate.Value, filePath, id);
                }
            }
        }

        private void cbtn_exportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // Set the file filter to show only Excel files
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.Title = "Save Excel File";
                saveFileDialog.DefaultExt = "xlsx";

                // Show the dialog and check if the user clicked OK
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName; // Get the selected file path
                    attendanceService.arrivalsExportExcel(cdtp_startDate.Value, cdtp_endDate.Value, filePath, id);
                }
            }
        }
        private void Arrivals_MouseClick(object sender, MouseEventArgs e)
        {
            pnl_exportMenu.Visible = cbtn_exportExcel.Visible = cbtn_exportPdf.Visible = false;
        }

        private void cbtn_export_Click(object sender, EventArgs e)
        {
            pnl_exportMenu.Visible = cbtn_exportExcel.Visible = cbtn_exportPdf.Visible = true;
        }

    }
}
