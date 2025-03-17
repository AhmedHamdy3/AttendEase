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
using AttendEase.Presentation.CustomControls;
using AttendEase.Presentation.Scedual;
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation.Admin
{
    public partial class AdminForm : Form
    {
        int currentId = GlobalData.RegisterEmployee.EmployeeId;
        ProfileImage profileImage;

        EmployeeDisplayService employeeDisplayService;

        public AdminForm()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json")
                         .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            employeeDisplayService = new EmployeeDisplayService(connectionString);
        }

        private void btn_HRs_Click(object sender, EventArgs e)
        {
            this.pnl_formLoader.Controls.Clear();
            HR_Data hR_Data_form = new HR_Data() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hR_Data_form.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(hR_Data_form);
            hR_Data_form.Show();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.pnl_formLoader.Controls.Clear();
            Admin_EditProfile_Form admin_EditProfile_Form = new Admin_EditProfile_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            admin_EditProfile_Form.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(admin_EditProfile_Form);
            admin_EditProfile_Form.Show();
        }
     


        private void AdminForm_Load(object sender, EventArgs e)
        {
            #region Set The Profile Image
            profileImage = new ProfileImage();
            profileImage.Size = new Size(100, 100); // Must be square for a perfect circle
            profileImage.Location = new Point(100, 30); // Center it on the form
            profileImage.BorderStyle = BorderStyle.None; // Remove border
            profileImage.SizeMode = PictureBoxSizeMode.StretchImage; // Stretch image to fit
            profileImage.Cursor = Cursors.Hand;
            //profileImage.Click += profileImage_Click;
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
            lbl_subtitle.Text = GlobalData.RegisterEmployee.SubTitle ?? "";
            lbl_subtitle.Location = new Point(pnl_sideBar.Width / 2 - lbl_subtitle.Width / 2, lbl_subtitle.Location.Y);

            //btn_dashboard.PerformClick();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            SignInForm signInForm = new SignInForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            signInForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(signInForm);
            signInForm.Show();
        }
       
    }
}

