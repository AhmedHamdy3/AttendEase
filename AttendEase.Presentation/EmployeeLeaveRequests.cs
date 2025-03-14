using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
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
        EmployeeActionLogService employeeActionLogService;
        CustomTable table;
        //public Action removeOverlayAction;
        //public Action showOverlayAction;


        public EmployeeLeaveRequests()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            leaveRequestsService = new LeaveRequestsService(connectionString);
            employeeActionLogService = new EmployeeActionLogService(connectionString);
        }

        async private void EmployeeLeaveRequests_Load(object sender, EventArgs e)
        {
            table = new CustomTable(888, 570, 30, 240);
            ShowRequests();
            this.Controls.Add(table.tablePanel);
        }
        private void ShowRequests()
        {
            var leaveRequests = leaveRequestsService.GetLeaveRequests(GlobalData.RegisterEmployee.EmployeeId);
            table.fillTable(leaveRequests, new[] { "Request Type", "Duraton", "Start Day", "End Day", "Status" }, "", null, null);

        }

        public void removeOverlay()
        {
            //removeOverlayAction();
        }
        private void csb_addRequest_Click(object sender, EventArgs e)
        {
            CreateLeaveRequest createLeaveRequest = new CreateLeaveRequest();
            createLeaveRequest.AddLeaveRequest = AddLeaveRequest;
            createLeaveRequest.ShowDialog();
            createLeaveRequest.BringToFront();
            this.SendToBack();
        }

        private void AddLeaveRequest(LeaveRequest leaveRequest)
        {
            leaveRequestsService.AddRequest(leaveRequest);
            employeeActionLogService.AddAction("Leave Request"
                , $"The Employee '{GlobalData.RegisterEmployee.Name}' whose Id is '{GlobalData.RegisterEmployee.EmployeeId}' submitted a request for {leaveRequest.LeaveType} in {DateTime.Now.ToString()}"
                , GlobalData.RegisterEmployee.EmployeeId);
            ShowRequests();
        }
    }
}
