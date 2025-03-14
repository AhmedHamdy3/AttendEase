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
        List<Request> allPendingRequests;
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


        #region helper methods
        private void loadRequests()
        {
            allPendingRequests = leaveRequestsService.GetPendingLeaveRequests();
            ShowPage(currentPage);
        }

        int firstId;
        int secondId;
        int thirdId;

        private void ShowPage(int page)
        {
            var pageRequests = allPendingRequests.Skip(page * pageSize).Take(pageSize).ToList();

            if (pageRequests.Count > 2)
            {
                pnl_user1.Visible = pnl_user2.Visible = pnl_user3.Visible = pic_next.Visible = pic_prev.Visible = true;
                showUser(pageRequests,1);
                showUser(pageRequests, 2);
                showUser(pageRequests,3);

            }
            else if (pageRequests.Count > 1)
            {

                pnl_user1.Visible = pnl_user2.Visible = pic_next.Visible = pic_prev.Visible = true;
                pnl_user3.Visible = false;
                showUser(pageRequests, 1);
                showUser(pageRequests, 2);
            }
            else if (pageRequests.Count > 0)
            {
  
                pnl_user1.Visible = pic_next.Visible = pic_prev.Visible = true;
                pnl_user2.Visible = pnl_user3.Visible = false;
                showUser(pageRequests, 1);
            }
            else
            {
                pnl_user1.Visible = pnl_user2.Visible = pnl_user3.Visible = pic_next.Visible = pic_prev.Visible = false;
            }

            pic_prev.Enabled = currentPage > 0;
            pic_next.Enabled = (currentPage + 1) * pageSize < allPendingRequests.Count;

        }

        private void showUser(List<Request> pageRequests, int userNum)
        {
            if (userNum == 1)
            {
                lbl_userName1.Text = pageRequests[0].Name;
                lbl_userName1.Location = new Point(pnl_user1.ClientSize.Width / 2 - lbl_userName1.Width / 2, lbl_userName1.Location.Y);
                pic_user1.Image = GlobalData.ByteArrayToImage(pageRequests[0]?.ProfileImage);
                lbl_requestType1.Text = pageRequests[0].LeaveType;
                lbl_requestType1.Location = new Point(pnl_user1.ClientSize.Width / 2 - lbl_requestType1.Width / 2, lbl_requestType1.Location.Y);
                firstId = pageRequests[0].Id;
            }
            else if (userNum == 2)
            {
                lbl_userName2.Text = pageRequests[1].Name;
                lbl_userName2.Location = new Point(pnl_user2.ClientSize.Width / 2 - lbl_userName2.Width / 2, lbl_userName2.Location.Y);
                pic_user2.Image = GlobalData.ByteArrayToImage(pageRequests[1]?.ProfileImage);
                lbl_requestType2.Text = pageRequests[1].LeaveType;
                lbl_requestType2.Location = new Point(pnl_user2.ClientSize.Width / 2 - lbl_requestType2.Width / 2, lbl_requestType2.Location.Y);
                secondId = pageRequests[1].Id;
            }
            else if (userNum == 3) {
                lbl_userName3.Text = pageRequests[2].Name;
                lbl_userName3.Location = new Point(pnl_user3.ClientSize.Width / 2 - lbl_userName3.Width / 2, lbl_userName3.Location.Y);
                pic_user3.Image = GlobalData.ByteArrayToImage(pageRequests[2]?.ProfileImage);
                lbl_requestType3.Text = pageRequests[2].LeaveType;
                lbl_requestType3.Location = new Point(pnl_user3.ClientSize.Width / 2 - lbl_requestType3.Width / 2, lbl_requestType3.Location.Y);
                thirdId = pageRequests[2].Id;
            }
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
            if ((currentPage + 1) * pageSize < allPendingRequests.Count)
            {
                currentPage++;
                ShowPage(currentPage);
            }
        }


        private void btn_view1_Click(object sender, EventArgs e)
        {
            int Id = firstId;
            var request = allPendingRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id, updateUnreadedRequests, new Action(loadRequests));
                frm.Show();

            }
        }

        private void btn_view2_Click(object sender, EventArgs e)
        {
            int Id = secondId;
            var request = allPendingRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id, updateUnreadedRequests, new Action(loadRequests));
            frm.Show();

            }
        }


        private void Btn_view3_Click(object sender, EventArgs e)
        {

            int Id = thirdId;
            var request = allPendingRequests.FirstOrDefault(x => x.Id == Id);

            if (request != null)
            {
                RequestDetailsForm frm = new RequestDetailsForm(Id, updateUnreadedRequests, new Action(loadRequests));
                frm.Show();

            }

        }


    }
}
