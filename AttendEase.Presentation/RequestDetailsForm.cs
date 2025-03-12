using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendEase.BusinessLogic;
using Azure.Core;
using Microsoft.Extensions.Configuration;
using static AttendEase.BusinessLogic.LeaveRequestsService;


namespace AttendEase.Presentation
{
    public partial class RequestDetailsForm : Form
    {
        LeaveRequestsService leaveRequestsService;
        int Id;
        BusinessLogic.LeaveRequestsService.Request request;
        public RequestDetailsForm()
        {
            InitializeComponent();

            var configBuilder = new ConfigurationBuilder()
                               .AddJsonFile("appsettings.json")
                               .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            leaveRequestsService = new LeaveRequestsService(connectionString);

        }


        public RequestDetailsForm(int id) : this()
        {
            Id = id;
            request = leaveRequestsService.GetRequestById(Id);

            leaveRequestsService.UpdateRequest(Id);


            lbl_name.Text = request.Name;
            lbl_start.Text = (request.StartDate).ToString();
            lbl_end.Text = (request.EndDate).ToString();
            lbl_title.Text = request.Title;
            lbl_creationDate.Text = (request.CreationTime).ToString();
            lbl_desc.Text = request.Description;
            lbl_jobTitle.Text = request.JobTitle;






        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RequestDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            leaveRequestsService.UpdateRequest(Id, "Accepted");
            MessageBox.Show("Request Accepted");
            leaveRequestsService.DeleteRequest(Id);
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            leaveRequestsService.UpdateRequest(Id, "Rejected");
            MessageBox.Show("Request Rejected");
            leaveRequestsService.DeleteRequest(Id);



        }
    }
}
