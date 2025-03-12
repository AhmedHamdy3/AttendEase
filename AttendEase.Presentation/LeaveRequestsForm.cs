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
using AttendEase.DataAccess.Entities;
using Microsoft.Extensions.Configuration;
using static AttendEase.BusinessLogic.LeaveRequestsService;

namespace AttendEase.Presentation
{
    public partial class LeaveRequestsForm : Form
    {
        int currentPage = 0;
        int pageSize = 3;
        AttendEaseContext context;
        LeaveRequestsService leaveRequestsService;
        List<Request> allRequests;

        public LeaveRequestsForm()
        {
            InitializeComponent();
            context = new AttendEaseContext();
            var configBuilder = new ConfigurationBuilder()
                               .AddJsonFile("appsettings.json")
                               .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            leaveRequestsService = new LeaveRequestsService(connectionString);


            loadRequests();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        #region helper methods
        private void loadRequests()
        {
            allRequests = leaveRequestsService.GetLeaveRequests();
            ShowPage(currentPage);
        }

        int firstId;
        int secondId;
        int thirdId;

        private void ShowPage(int page)
        {
            var pageRequests = allRequests.Skip(page * pageSize).Take(pageSize).ToList();

            if (pageRequests.Count > 0)
            {
                lbl_userName1.Text = pageRequests[0].Name;
                lbl_title1.Text = pageRequests[0].Title;
                firstId = pageRequests[0].Id;

            }

            if (pageRequests.Count > 1)
            {
                lbl_userName2.Text = pageRequests[1].Name;
                lbl_title2.Text = pageRequests[1].Title;
                secondId = pageRequests[1].Id;
            }

            if (pageRequests.Count > 2)
            {
                lbl_userName3.Text = pageRequests[2].Name;
                lbl_title3.Text = pageRequests[2].Title;
                thirdId = pageRequests[2].Id;
            }


            pic_prev.Enabled = currentPage > 0;
            pic_next.Enabled = (currentPage + 1) * pageSize < allRequests.Count;

        }


        #endregion

        private void pic_prev_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                ShowPage(currentPage);
            }
        }

        private void pic_next_Click(object sender, EventArgs e)
        {
            if ((currentPage + 1) * pageSize < allRequests.Count)
            {
                currentPage++;
                ShowPage(currentPage);
            }
        }


        private void btn_view1_Click(object sender, EventArgs e)
        {
            int Id = firstId;
            var request = allRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id);
                frm.Show();

            }
        }

        private void btn_view2_Click(object sender, EventArgs e)
        {

            int Id = secondId;
            var request = allRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id);
                frm.Show();

            }
        }

        private void Btn_view3_Click(object sender, EventArgs e)
        {

            int Id = thirdId;
            var request = allRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id);
                frm.Show();

            }

        }
    }
}
