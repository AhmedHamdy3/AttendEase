using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.Attendance;
using AttendEase.Presentation.CustomControls;
using AttendEase.Presentation.Properties;
using AttendEase.Presentation.Scedual;
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
    public partial class HRDashboard : Form
    {
        private Button currentButton;
        AttendanceService attendanceService;
        EmployeeDisplay employeeDisplay;
        ProfileImage profileImage;
        LeaveRequestsService leaveRequestsService;
        public HRDashboard()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            leaveRequestsService = new LeaveRequestsService(connectionString);
        }

        private void HRDashboard_Load(object sender, EventArgs e)
        {
            #region Set The Profile Image
            profileImage = new ProfileImage();
            profileImage.Size = new Size(100, 100); // Must be square for a perfect circle
            profileImage.Location = new Point(100, 30); // Center it on the form
            profileImage.BorderStyle = BorderStyle.None; // Remove border
            profileImage.SizeMode = PictureBoxSizeMode.StretchImage; // Stretch image to fit
            profileImage.Cursor = Cursors.Hand;
            profileImage.Click += profileImage_Click;
            if (GlobalData.RegisterEmployee.ProfileImage == null)
            {
                profileImage.Image = Image.FromFile("../../../../Images/profileImage.png"); // Load an image
            }
            else
            {
                Image img = GlobalData.ByteArrayToImage(GlobalData.RegisterEmployee.ProfileImage);
                profileImage.Image = img;
            }
            
            // Add the CircularPictureBox to the form
            this.Controls.Add(profileImage);
            profileImage.BringToFront();
            #endregion

            // Add the name of the employee
            lbl_employeeName.Text = GlobalData.RegisterEmployee.Name;
            lbl_employeeName.Location = new Point(pnl_sideBar.Width / 2 - lbl_employeeName.Width / 2, lbl_employeeName.Location.Y);
            lbl_subTitle.Text = GlobalData.RegisterEmployee.SubTitle ?? "";
            lbl_subTitle.Location = new Point(pnl_sideBar.Width / 2 - lbl_subTitle.Width / 2, lbl_subTitle.Location.Y);

            btn_dashboard.PerformClick();
            updateUnreadedRequests();
        }


        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Management_Active);

            this.pnl_formLoader.Controls.Clear();
            DashboardPanelForm dashboardPanelForm = new DashboardPanelForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboardPanelForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(dashboardPanelForm);
            dashboardPanelForm.Show();
        }
        private void btn_employees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Management_Active);

            this.pnl_formLoader.Controls.Clear();
            EmployeeDisplay EmployeesDisplayForm = new EmployeeDisplay() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            EmployeesDisplayForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(EmployeesDisplayForm);
            EmployeesDisplayForm.Show();
        }

        private void btn_schedules_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Calendar_Active);
            this.pnl_formLoader.Controls.Clear();
            Scedual_details scedual_Details_form = new Scedual_details() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            scedual_Details_form.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(scedual_Details_form);
            scedual_Details_form.Show();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            using (WaitForm frm = new WaitForm(loadAttendance))
            {
                //this.SendToBack();
                frm.ShowDialog(this);
            }

            ActivateButton(sender, (Image)Properties.Resources.Attendance_Active);
        }
        public void loadAttendance()
        {
            // Check if Invoke is required (if we're not on the UI thread)
            if (pnl_formLoader.InvokeRequired)
            {
                // Use Invoke to marshal the call to the UI thread
                pnl_formLoader.Invoke(new Action(loadAttendance));
            }
            else
            {
                // We're on the UI thread, so it's safe to update the control
                this.pnl_formLoader.Controls.Clear();
                AttendanceSummary attendanceSummaryForm = new AttendanceSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                attendanceSummaryForm.FormBorderStyle = FormBorderStyle.None;
                this.pnl_formLoader.Controls.Add(attendanceSummaryForm);
                attendanceSummaryForm.Show();
            }
        }

        private void btn_arrivals_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Clock_Active);

            this.pnl_formLoader.Controls.Clear();
            Arrivals attendanceSummaryForm = new Arrivals() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            attendanceSummaryForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(attendanceSummaryForm);
            attendanceSummaryForm.Show();
        }

        private void btn_frequentAbsent_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Calendar_Delete_Active);

            this.pnl_formLoader.Controls.Clear();
            FrequentAbsence frequentAbsence = new FrequentAbsence() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frequentAbsence.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(frequentAbsence);
            frequentAbsence.Show();
        }

        private void btn_leaveRequest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Inquiry_Active);

            this.pnl_formLoader.Controls.Clear();
            LeaveRequestsForm leaveRequestsForm = new LeaveRequestsForm(new Action(updateUnreadedRequests)) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            leaveRequestsForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(leaveRequestsForm);
            leaveRequestsForm.Show();
        }

        private void ActivateButton(object btnSender, Image img)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(210, 219, 253);
                    currentButton.ForeColor = ColorTranslator.FromHtml("#4C94FF");
                    currentButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    currentButton.Image = img;
                    currentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 219, 253);
                    currentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 219, 253);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control ctrl in pnl_sideBar.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                {
                    Button? previousBtn = ctrl as Button;
                    if (previousBtn != null)
                    {
                        previousBtn.BackColor = Color.White;
                        previousBtn.ForeColor = Color.FromArgb(93, 114, 133);
                        previousBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        previousBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
                        previousBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
                        if (previousBtn.Name == "btn_dashboard")
                            previousBtn.Image = (Image)Properties.Resources.Home;
                        else if (previousBtn.Name == "btn_employees")
                            previousBtn.Image = (Image)Properties.Resources.Management;
                        else if (previousBtn.Name == "btn_schedules")
                            previousBtn.Image = (Image)Properties.Resources.Planner;
                        else if (previousBtn.Name == "btn_attendance")
                            previousBtn.Image = (Image)Properties.Resources.Attendance;
                        else if (previousBtn.Name == "btn_arrivals")
                            previousBtn.Image = (Image)Properties.Resources.Clock;
                        else if (previousBtn.Name == "btn_frequentAbsent")
                            previousBtn.Image = (Image)Properties.Resources.Calendar_Delete;
                        else if (previousBtn.Name == "btn_leaveRequest")
                            previousBtn.Image = (Image)Properties.Resources.Inquiry;
                    }
                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            GlobalData.RegisterEmployee = null;
            GlobalData.startForm.Show();
            this.Close();
        }

        private void lbl_employeeName_Click(object sender, EventArgs e)
        {
            showProfileForm();
        }
        private void profileImage_Click(object sender, EventArgs e)
        {
            showProfileForm();
        }

        private void showProfileForm()
        {
            DisableButton();
            currentButton = null;
            this.pnl_formLoader.Controls.Clear();
            EmployeeProfileForm employeeProfileForm = new EmployeeProfileForm(new Action(updateUserInfo)) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            employeeProfileForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(employeeProfileForm);
            employeeProfileForm.Show();
        }

        private void updateUserInfo()
        {
            if (GlobalData.RegisterEmployee.ProfileImage == null)
            {
                profileImage.Image = Image.FromFile("../../../../Images/profileImage.png"); // Load an image
            }
            else
            {
                Image img = GlobalData.ByteArrayToImage(GlobalData.RegisterEmployee.ProfileImage);
                profileImage.Image = img;
            }
            lbl_employeeName.Text = GlobalData.RegisterEmployee.Name;
            lbl_employeeName.Location = new Point(pnl_sideBar.Width / 2 - lbl_employeeName.Width / 2, 133);
        }
        
        private void updateUnreadedRequests()
        {
            int unreadedRequests = leaveRequestsService.CountOfUnreadedRequests();
            if(unreadedRequests > 0)
            {
                cbtn_unreadedRequests.Visible = true;
                cbtn_unreadedRequests.Text = unreadedRequests.ToString();
            }
            else
            {
                cbtn_unreadedRequests.Visible = false;
            }
        }
    }
}
