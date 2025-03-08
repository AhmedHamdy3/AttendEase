﻿using AttendEase.Presentation.CustomControls;
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
    public partial class EmployeeMainForm : Form
    {
        private Button currentButton;
        ProfileImage profileImage;

        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void EmployeeMainForm_Load(object sender, EventArgs e)
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

            lbl_employeeName.Text = GlobalData.RegisterEmployee.Name;
            lbl_employeeName.Location = new Point(pnl_sideBar.Width / 2 - lbl_employeeName.Width / 2, 133);

            // Add the name of the employee
            btn_dashboard.PerformClick();
        }
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Home_Active);

            this.pnl_formLoader.Controls.Clear();
            EmployeeDashboard employeeDashboard = new EmployeeDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            employeeDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(employeeDashboard);
            employeeDashboard.Show();
        }

        private void btn_leaveRequest_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, (Image)Properties.Resources.Inquiry_Active);

            this.pnl_formLoader.Controls.Clear();
            EmployeeLeaveRequests employeeLeaveRequests = new EmployeeLeaveRequests() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            employeeLeaveRequests.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(employeeLeaveRequests);
            employeeLeaveRequests.Show();
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
