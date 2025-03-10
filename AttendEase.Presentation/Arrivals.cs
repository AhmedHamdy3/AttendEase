﻿using AttendEase.BusinessLogic;
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
    public partial class Arrivals : Form
    {
        AttendanceService attendanceService;
        Table table;
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
        }

        private void Arrivals_Load(object sender, EventArgs e)
        {
            table = new Table(888, 570, 30, 240);
            this.Controls.Add(table.tablePanel);
            var month = AttendanceService.GetPreviousMonth(DateTime.Now, 0);

            dtp_startDate.Value = month.StartDate;
            dtp_endDate.Value = month.EndDate;

            ShowArrivals();
        }


        private void dtp_startDate_ValueChanged(object sender, EventArgs e)
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

        private void dtp_endDate_ValueChanged(object sender, EventArgs e)
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

        private void GetLateAndEarlyForSpecificEmployee(int id)
        {
            isDetails = 1;
            this.id = id;
            table.tablePanel.Location = new Point(30, 280);
            table.tablePanel.Size = new Size(888, 530);
            btn_back.Visible = true;
            ShowArrivalsDetail();
        }

        private void ShowArrivals()
        {
            var lateArrivalsAndEarlyDeparture = attendanceService.GetLateArrivalsAndEarlyDepartureInSpecificPeriod(dtp_startDate.Value, dtp_endDate.Value);
            table.fillTable(lateArrivalsAndEarlyDeparture, new[] { "Employee", "Department", "Late", "Early" }, "Arrivals", null, GetLateAndEarlyForSpecificEmployee);
        }
        private void ShowArrivalsDetail()
        {
            var lateArrivalsAndEarlyDepartureForSpecificEmployee = attendanceService.GetLateArrivalsAndEarlyDepartureInSpecificPeriodForSpecificEmployee(dtp_startDate.Value, dtp_endDate.Value, this.id);
            table.fillTable(lateArrivalsAndEarlyDepartureForSpecificEmployee, new string[] { "Employee", "Date", "Check In", "Check Out", "Total Time", "type" }, "", null, null);
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            isDetails = 0;
            table.tablePanel.Location = new Point(30, 240);
            table.tablePanel.Size = new Size(888, 570);
            btn_back.Visible = false;
            ShowArrivals();
        }
    }
}
