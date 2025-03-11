using AttendEase.BusinessLogic;
using AttendEase.Presentation.Attendance;
using AttendEase.Presentation.CustomControls;
using AttendEase.Presentation.Properties;
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
        ProfileImage profileImage;
        public HRDashboard()
        {
            InitializeComponent();
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

            // Add the name of the employee
            //lbl_employeeName.Text = GlobalData.RegisterEmployee.Name;
            lbl_employeeName.Location = new Point(pnl_sideBar.Width / 2 - lbl_employeeName.Width / 2, 133);

            btn_dashboard.PerformClick();

        }


        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Home_Active);
        }

        private void btn_employees_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Management_Active);
        }

        private void btn_schedules_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Calendar_Active);
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Attendance_Active);

            this.pnl_formLoader.Controls.Clear();
            AttendanceSummary attendanceSummaryForm = new AttendanceSummary() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            attendanceSummaryForm.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(attendanceSummaryForm);
            attendanceSummaryForm.Show();
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
    }
}
