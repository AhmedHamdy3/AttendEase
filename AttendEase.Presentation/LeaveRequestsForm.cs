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
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.Configuration;
using static AttendEase.BusinessLogic.LeaveRequestsService;

namespace AttendEase.Presentation
{
    public partial class LeaveRequestsForm : Form
    {
        private HubConnection _connection;
        int currentPage = 0;
        int pageSize = 3;
        AttendEaseContext context;
        LeaveRequestsService leaveRequestsService;
        List<Request> allUnreadedRequests;
        Action updateUnreadedRequests;

        public LeaveRequestsForm(Action updateUnreadedRequests)
        {
            InitializeComponent();
            InitializeSignalR();

            this.updateUnreadedRequests = updateUnreadedRequests;

            context = new AttendEaseContext();
            var configBuilder = new ConfigurationBuilder()
                               .AddJsonFile("appsettings.json")
                               .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            leaveRequestsService = new LeaveRequestsService(connectionString);

            loadRequests();
            this.updateUnreadedRequests = updateUnreadedRequests;
        }

        //private void updateUnreadRequestV2()
        //{
        //    updateUnreadedRequests();
        //}

        private async void InitializeSignalR()
        {
            // Create a connection to the SignalR hub
            _connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7066/leaveRequestHub") // Replace with your SignalR server URL
                .Build();


            // Define what to do when a leave request is received (for HR)
            _connection.On<string>("ReceiveLeaveRequest", (message) =>
            {
                // Show the leave request in the UI
                updateUnreadedRequests();
                loadRequests();
            });

            try
            {
                // Start the connection
                await _connection.StartAsync();
                await _connection.InvokeAsync("RegisterUserRole", "HR"); // For HR

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to SignalR: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            allUnreadedRequests = leaveRequestsService.GetUnreadedLeaveRequests();
            ShowPage(currentPage);
        }

        int firstId;
        int secondId;
        int thirdId;

        private void ShowPage(int page)
        {
            var pageRequests = allUnreadedRequests.Skip(page * pageSize).Take(pageSize).ToList();

            if (pageRequests.Count > 0)
            {
                lbl_userName1.Text = pageRequests[0].Name;
                //lbl_userName1.Location = new Point(pnl_user1.Location.X + pnl_user1.Width / 2 - lbl_userName1.Width / 2, lbl_userName1.Location.Y);
                pic_user1.Image = GlobalData.ByteArrayToImage(pageRequests[0]?.ProfileImage);
                lbl_title1.Text = pageRequests[0].LeaveType;
                firstId = pageRequests[0].Id;
            }

            if (pageRequests.Count > 1)
            {
                lbl_userName2.Text = pageRequests[1].Name;
                //lbl_userName2.Location = new Point(pnl_user2.Location.X + pnl_user2.Width / 2 - lbl_userName2.Width / 2, lbl_userName2.Location.Y);
                pic_user2.Image = GlobalData.ByteArrayToImage(pageRequests[1]?.ProfileImage);
                lbl_title2.Text = pageRequests[1].LeaveType;
                secondId = pageRequests[1].Id;
            }

            if (pageRequests.Count > 2)
            {
                lbl_userName3.Text = pageRequests[2].Name;
                //lbl_userName3.Location = new Point(pnl_user3.Location.X + pnl_user3.Width / 2 - lbl_userName3.Width / 2, lbl_userName3.Location.Y);
                pic_user3.Image = GlobalData.ByteArrayToImage(pageRequests[2]?.ProfileImage);
                lbl_title3.Text = pageRequests[2].LeaveType;
                thirdId = pageRequests[2].Id;
            }


            pic_prev.Enabled = currentPage > 0;
            pic_next.Enabled = (currentPage + 1) * pageSize < allUnreadedRequests.Count;

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
            if ((currentPage + 1) * pageSize < allUnreadedRequests.Count)
            {
                currentPage++;
                ShowPage(currentPage);
            }
        }


        private void btn_view1_Click(object sender, EventArgs e)
        {
            int Id = firstId;
            var request = allUnreadedRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id, new Action(updateUnreadedRequests), new Action(loadRequests));
                frm.Show();

            }
        }

        private void btn_view2_Click(object sender, EventArgs e)
        {

            int Id = secondId;
            var request = allUnreadedRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id, new Action(updateUnreadedRequests), new Action(loadRequests));
                frm.Show();

            }
        }

        private void Btn_view3_Click(object sender, EventArgs e)
        {

            int Id = thirdId;
            var request = allUnreadedRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id, new Action(updateUnreadedRequests), new Action(loadRequests));
                frm.Show();

            }

        }
    }
}
