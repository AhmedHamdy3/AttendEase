using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using Microsoft.AspNetCore.SignalR.Client;
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
    public partial class CreateLeaveRequest : Form
    {
        private HubConnection _connection;
        LeaveRequestsService leaveRequestsService;
        public Action<LeaveRequest> AddLeaveRequest;
        //public Action removeOverlay;
        public CreateLeaveRequest()
        {
            InitializeComponent();
            InitializeSignalR();

            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            leaveRequestsService = new LeaveRequestsService(connectionString);
        }

        async private void InitializeSignalR()
        {
            // Create a connection to the SignalR hub
            _connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7066/leaveRequestHub") // Replace with your SignalR server URL
                .Build();

            await _connection.StartAsync();
            await _connection.InvokeAsync("RegisterUserRole", "Employee"); // For Employee
        }
        private void CreateLeaveRequest_Load(object sender, EventArgs e)
        {
            ccb_requestType.DataSource = new List<Object>
            {
                "Sick Leave",
                "Vacation",
                "Unpaid Leave"
            };
            ccb_requestType.SelectedIndex = 0;
        }

        private void csb_close_Click(object sender, EventArgs e)
        {
            //removeOverlay();
            this.Close();
        }

        private void csb_sendRequest_Click(object sender, EventArgs e)
        {
            string type = ccb_requestType.SelectedItem.ToString();
            DateTime startDate = cdtp_startDate.Value;
            DateTime endDate = cdtp_endDate.Value;
            var comment = ctxt_comment.Text;

            LeaveRequest leaveRequest = new LeaveRequest()
            {
                LeaveType = type,
                StartDate = startDate,
                EndDate = endDate,
                Description = comment,
                EmployeeId = GlobalData.RegisterEmployee.EmployeeId
            };

            AddLeaveRequest(leaveRequest);

            SendLeaveRequest();

            this.Close();
        }

        private void cb_requestType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void SendLeaveRequest()
        {
            if (_connection != null && _connection.State == HubConnectionState.Connected)
            {
                await _connection.InvokeAsync("SendLeaveRequest");
            }
            else
            {
                MessageBox.Show("SignalR connection is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
