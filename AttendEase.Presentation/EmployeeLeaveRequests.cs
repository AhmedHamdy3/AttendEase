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
    public partial class EmployeeLeaveRequests : Form
    {
        LeaveRequestsService leaveRequestsService;
        Table table;
        public EmployeeLeaveRequests()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            leaveRequestsService = new LeaveRequestsService(connectionString);
        }

        private void EmployeeLeaveRequests_Load(object sender, EventArgs e)
        {
            table = new Table(888, 570, 30, 240);
            this.Controls.Add(table.tablePanel);
            var leaveRequests = leaveRequestsService.GetLeaveRequests(GlobalData.RegisterEmployee.EmployeeId);
            table.fillTable(leaveRequests, new[] { "Request Type", "Duraton", "Start Day", "End Day", "Status" }, "", null, null);
        }
    }
}
