using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
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
        LeaveRequestsService leaveRequestsService;
        public Action<LeaveRequest> AddLeaveRequest;
        //public Action removeOverlay;
        public CreateLeaveRequest()
        {
            InitializeComponent();

            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            leaveRequestsService = new LeaveRequestsService(connectionString);
        }
        private void CreateLeaveRequest_Load(object sender, EventArgs e)
        {
            cb_requestType.DataSource = new List<Object>
            {
                new { Name = "Sick Leave", Value = "Sick Leave" },
                new { Name = "Vacation", Value = "Vacation" },
                new { Name = "Leave Request", Value = "Leave Request" }
            };
            cb_requestType.DisplayMember = "Name";
            cb_requestType.ValueMember = "Value";
        }

        private void csb_close_Click(object sender, EventArgs e)
        {
            //removeOverlay();
            this.Close();
        }

        private void csb_sendRequest_Click(object sender, EventArgs e)
        {
            string type = cb_requestType.SelectedValue.ToString();
            DateTime startDate = dtp_startDate.Value;
            DateTime endDate = dtp_endDate.Value;
            var comment = rb_comment.Text;
            
            LeaveRequest leaveRequest = new LeaveRequest()
            {
                LeaveType = type,
                StartDate = startDate,
                EndDate = endDate,
                Description = comment,
                EmployeeId = GlobalData.EmployeeId
            };

            AddLeaveRequest(leaveRequest);
            //removeOverlay();
            this.Close();
        }

    }
}
