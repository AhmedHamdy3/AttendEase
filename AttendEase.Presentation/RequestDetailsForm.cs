﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
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
        Action updateUnreadedRequests;
        Action loadRequests;
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
            lbl_jobTitle.Text = request.JobTitle;

            lbl_start.Text = request.StartDate.ToShortDateString();
            lbl_end.Text = request.EndDate.ToShortDateString();
            lbl_requestType.Text = request.LeaveType;
            lbl_creationDate.Text = request.CreationTime.ToShortDateString();
            lbl_desc.Text = request.Description;
            pb_EmployeeImage.Image = GlobalData.ByteArrayToImage(request.ProfileImage);
            lbl_name.Location = new Point(this.Width / 2 - lbl_name.Width / 2, lbl_name.Location.Y);
            lbl_jobTitle.Location = new Point(this.Width / 2 - lbl_jobTitle.Width / 2, lbl_jobTitle.Location.Y);


        }
        public RequestDetailsForm(int id, Action updateUnreadedRequests, Action loadRequests) : this(id)
        {
            this.updateUnreadedRequests = updateUnreadedRequests;
            this.loadRequests = loadRequests;
            this.updateUnreadedRequests();
        }
        private void RequestDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            leaveRequestsService.UpdateRequest(Id, "Accepted");
            MessageBox.Show("Request Accepted");
            loadRequests();
            this.Close();
            //leaveRequestsService.DeleteRequest(Id);
        }

        private void btn_reject_Click(object sender, EventArgs e)
        {
            leaveRequestsService.UpdateRequest(Id, "Rejected");
            MessageBox.Show("Request Rejected");
            loadRequests();
            this.Close();
            //leaveRequestsService.DeleteRequest(Id);
        }
    }
}
