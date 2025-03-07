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
    public partial class Arrivals : Form
    {
        AttendanceService attendanceService;
        Table table;
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
            var lateArrivalsAndEarlyDeparture = attendanceService.GetLateArrivalsAndEarlyDepartureInSpecificPeriod(new DateTime(2025, 2, 22), new DateTime(2025,2,27));
            table.fillTable(lateArrivalsAndEarlyDeparture, new[] { "Employee", "Department", "Late", "Early"}, "", null);

        }
    }
}
