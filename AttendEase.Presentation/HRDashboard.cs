using AttendEase.BusinessLogic;
using AttendEase.Presentation.Attendance;
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
    public partial class HRDashboard : Form
    {
        AttendanceService attendanceService;
        ProfileImage profileImage;
        public HRDashboard()
        {
            InitializeComponent();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            bl_arrivals.Visible = true;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            bl_arrivals.Visible = false;
        }

        private void HRDashboard_Load(object sender, EventArgs e)
        {
            #region Set The Profile Image
            profileImage = new ProfileImage();
            profileImage.Size = new Size(100, 100); // Must be square for a perfect circle
            profileImage.Location = new Point(100, 30); // Center it on the form
            profileImage.BorderStyle = BorderStyle.None; // Remove border
            profileImage.SizeMode = PictureBoxSizeMode.StretchImage; // Stretch image to fit
            profileImage.Image = Image.FromFile("../../../../Images/profileImage.png"); // Load an image

            // Add the CircularPictureBox to the form
            this.Controls.Add(profileImage);

            profileImage.BringToFront();
            #endregion

        }

        #region Navbar Click 
        private void pb_dashboard_Click(object sender, EventArgs e)
        {
            pb_dashboard.SendToBack();
            pb_arrivals_active.SendToBack();
            pb_attendance_active.SendToBack();
            pb_employees_active.SendToBack();
            pb_frequent_absent_active.SendToBack();
            pb_leave_request_active.SendToBack();
            pb_schedule_active.SendToBack();


        }

        private void pb_employees_Click(object sender, EventArgs e)
        {
            pb_dashboard_active.SendToBack();
            pb_arrivals_active.SendToBack();
            pb_attendance_active.SendToBack();
            pb_employees.SendToBack();
            pb_frequent_absent_active.SendToBack();
            pb_leave_request_active.SendToBack();
            pb_schedule_active.SendToBack();
        }

        private void pb_schedule_Click(object sender, EventArgs e)
        {
            pb_dashboard_active.SendToBack();
            pb_arrivals_active.SendToBack();
            pb_attendance_active.SendToBack();
            pb_employees_active.SendToBack();
            pb_frequent_absent_active.SendToBack();
            pb_leave_request_active.SendToBack();
            pb_schedule.SendToBack();
        }

        private void pb_attendance_Click(object sender, EventArgs e)
        {
            pb_dashboard_active.SendToBack();
            pb_arrivals_active.SendToBack();
            pb_attendance.SendToBack();
            pb_employees_active.SendToBack();
            pb_frequent_absent_active.SendToBack();
            pb_leave_request_active.SendToBack();
            pb_schedule_active.SendToBack();

            this.pnl_formLoader.Controls.Clear();
            AttendanceSummary attendanceSummaryForm = new AttendanceSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            attendanceSummaryForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(attendanceSummaryForm);
            attendanceSummaryForm.Show();
        }

        private void pb_arrivals_Click(object sender, EventArgs e)
        {
            pb_dashboard_active.SendToBack();
            pb_arrivals.SendToBack();
            pb_attendance_active.SendToBack();
            pb_employees_active.SendToBack();
            pb_frequent_absent_active.SendToBack();
            pb_leave_request_active.SendToBack();
            pb_schedule_active.SendToBack();

            this.pnl_formLoader.Controls.Clear();
            Arrivals attendanceSummaryForm = new Arrivals() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            attendanceSummaryForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(attendanceSummaryForm);
            attendanceSummaryForm.Show();
        }

        private void pb_frequent_absent_Click(object sender, EventArgs e)
        {
            pb_dashboard_active.SendToBack();
            pb_arrivals_active.SendToBack();
            pb_attendance_active.SendToBack();
            pb_employees_active.SendToBack();
            pb_frequent_absent.SendToBack();
            pb_leave_request_active.SendToBack();
            pb_schedule_active.SendToBack();
        }

        private void pb_leave_request_Click(object sender, EventArgs e)
        {
            pb_dashboard_active.SendToBack();
            pb_arrivals_active.SendToBack();
            pb_attendance_active.SendToBack();
            pb_employees_active.SendToBack();
            pb_frequent_absent_active.SendToBack();
            pb_leave_request.SendToBack();
            pb_schedule_active.SendToBack();
        }
        #endregion

        #region Navbar Hover
        private void pb_dashboard_MouseHover(object sender, EventArgs e)
        {
            bl_dashboard.Visible = true;
        }

        private void pb_dashboard_MouseLeave(object sender, EventArgs e)
        {
            bl_dashboard.Visible = false;
        }

        private void pb_employees_MouseHover(object sender, EventArgs e)
        {
            bl_employees.Visible = true;
        }

        private void pb_employees_MouseLeave(object sender, EventArgs e)
        {
            bl_employees.Visible = false;
        }

        private void pb_schedule_MouseHover(object sender, EventArgs e)
        {
            bl_schedule.Visible = true;
        }

        private void pb_schedule_MouseLeave(object sender, EventArgs e)
        {
            bl_schedule.Visible = false;
        }

        private void pb_attendance_MouseHover(object sender, EventArgs e)
        {
            bl_attendance.Visible = true;
        }

        private void pb_attendance_MouseLeave(object sender, EventArgs e)
        {
            bl_attendance.Visible = false;
        }

        private void pb_arrivals_MouseHover(object sender, EventArgs e)
        {
            bl_arrivals.Visible = true;
        }

        private void pb_arrivals_MouseLeave(object sender, EventArgs e)
        {
            bl_arrivals.Visible = false;
        }

        private void pb_frequent_absent_MouseHover(object sender, EventArgs e)
        {
            bl_frequent_absent.Visible = true;
        }

        private void pb_frequent_absent_MouseLeave(object sender, EventArgs e)
        {
            bl_frequent_absent.Visible = false;
        }

        private void pb_leave_request_MouseHover(object sender, EventArgs e)
        {
            bl_leave_requests.Visible = true;
        }

        private void pb_leave_request_MouseLeave(object sender, EventArgs e)
        {
            bl_leave_requests.Visible = false;
        }
        #endregion

    }
}
