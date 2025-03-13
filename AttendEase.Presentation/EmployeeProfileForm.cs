using AttendEase.BusinessLogic;
using AttendEase.Presentation.CustomControls;
using Azure;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AttendEase.Presentation
{
    public partial class EmployeeProfileForm : Form
    {
        EmployeesService employeesService;
        Action updateSidebarInfo;
        private bool isVisiblePass = false;
        private bool isVisibleNew = false;
        private bool isVisibleConf = false;

        public EmployeeProfileForm(Action updateSidebarInfo)
        {
            InitializeComponent();
            this.updateSidebarInfo = updateSidebarInfo;

            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            employeesService = new EmployeesService(connectionString);

        }

        private void EmployeeProfileForm_Load(object sender, EventArgs e)
        {
            if (GlobalData.RegisterEmployee.ProfileImage == null)
            {
                pb_profileImage.Image = Image.FromFile("../../../../Images/profileImage.png"); // Load an image
            }
            else
            {
                Image img = GlobalData.ByteArrayToImage(GlobalData.RegisterEmployee.ProfileImage);
                pb_profileImage.Image = img;
            }
            updateInfo();
        }

        private void updateInfo()
        {
            ctxt_address.Text = lbl_address.Text = GlobalData.RegisterEmployee.Address;
            ctxt_email.Text = lbl_email.Text = GlobalData.RegisterEmployee.Email;
            ctxt_name.Text = lbl_name.Text = GlobalData.RegisterEmployee.Name;
            ctxt_phone.Text = lbl_phone.Text = GlobalData.RegisterEmployee.Phone;
            ccb_gender.SelectedItem = lbl_gender.Text = GlobalData.RegisterEmployee.Gender;
            updateSidebarInfo();

        }

        private void cbtn_editProfile_Click(object sender, EventArgs e)
        {
            pnl_showInfo.Visible = false;
            pnl_editInfo.Visible = true;
        }

        private void cbtn_changePassword_Click(object sender, EventArgs e)
        {
            pnl_showInfo.Visible = false;
            pnl_changePassword.Visible = true;
        }

        private void cbtn_cancelPassword_Click(object sender, EventArgs e)
        {
            pnl_showInfo.Visible = true;
            pnl_changePassword.Visible = false;
            ctxt_newPassword.Text = ctxt_currentPassword.Text = ctxt_confirmPassword.Text = "";
        }

        private void cbtn_savePassword_Click(object sender, EventArgs e)
        {

            string oldPassword = ctxt_currentPassword.Text;
            string newPassword = ctxt_newPassword.Text;
            string confirmPassword = ctxt_confirmPassword.Text;

            if (GlobalData.RegisterEmployee.Password.ToString() == oldPassword)
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("New Password & Confirm Password are not the same");
                }
                else
                {
                    if (!Regex.IsMatch(newPassword, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                    {
                        MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, and one number.");
                    }
                    else
                    {
                        employeesService.UpdatePassword(GlobalData.RegisterEmployee.EmployeeId, newPassword);
                        MessageBox.Show("Password Updated");
                        pnl_showInfo.Visible = true;
                        pnl_changePassword.Visible = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("The old Password is not correct");
            }
        }

        private void cbtn_save_Click(object sender, EventArgs e)
        {
            var name = ctxt_name.Text;
            var email = ctxt_email.Text;
            var address = ctxt_address.Text;
            var phone = ctxt_phone.Text;
            var gender = ccb_gender.SelectedItem?.ToString();
            try
            {
                int flag = 1;
                if (!Regex.IsMatch(name, @"^[a-zA-Z0-9 ]{3,}$"))
                {
                    flag = 0;
                    MessageBox.Show("Username must be at least 3 characters long and contain only letters and numbers");
                }

                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    flag = 0;
                    MessageBox.Show("Please enter a valid email address (e.g., example@mail.com).");

                }
                if (!Regex.IsMatch(phone, @"^(01[0125][0-9]{8})$"))
                {
                    flag = 0;
                    MessageBox.Show("Invalid Phone Number");
                }
                if (flag == 1)
                {
                    employeesService.UpdateInfo(GlobalData.RegisterEmployee.EmployeeId, name, email, phone, gender, address);
                    GlobalData.RegisterEmployee = employeesService.GetEmployee(GlobalData.RegisterEmployee.EmployeeId);
                    MessageBox.Show("Data Updated Successfully");
                    updateInfo();
                    pnl_editInfo.Visible = false;
                    pnl_showInfo.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }
        }

        private void cbtn_editCancel_Click(object sender, EventArgs e)
        {
            pnl_editInfo.Visible = false;
            pnl_showInfo.Visible = true;
        }

        private void btn_showCurrent_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisiblePass)
            {
                ctxt_currentPassword.PasswordChar = false;
                btn.Image = (Image)Properties.Resources.Invisible;
            }
            else
            {
                ctxt_currentPassword.PasswordChar = true;
                btn.Image = (Image)Properties.Resources.Eye1;
            }
            isVisiblePass = !isVisiblePass;
        }

        private void btn_showNew_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisibleNew)
            {
                ctxt_newPassword.PasswordChar = false;
                btn.Image = (Image)Properties.Resources.Invisible;
            }
            else
            {
                ctxt_newPassword.PasswordChar = true;
                btn.Image = (Image)Properties.Resources.Eye1;
            }
            isVisibleNew = !isVisibleNew;
        }

        private void btn_showConfirm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisibleConf)
            {
                ctxt_confirmPassword.PasswordChar = false;
                btn.Image = (Image)Properties.Resources.Invisible;
            }
            else
            {
                ctxt_confirmPassword.PasswordChar = true;
                btn.Image = (Image)Properties.Resources.Eye1;
            }
            isVisibleConf = !isVisibleConf;
        }

        private void cbtn_updateProfileImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the file filter to show only image files
                openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1; // Default to image files
                openFileDialog.RestoreDirectory = true; // Restore the previous directory
                openFileDialog.Title = "Upload Image"; // Dialog title

                // Show the OpenFileDialog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Get the selected file path
                        string filePath = openFileDialog.FileName;

                        // Convert the image to a byte array
                        byte[] imageBytes = GlobalData.ImageToByteArray(Image.FromFile(filePath));

                        // Save the image to the database
                        employeesService.UpdateProfileImage(GlobalData.RegisterEmployee.EmployeeId, imageBytes); // Replace "JohnDoe" with the actual username

                        // Load the image into the PictureBox
                        pb_profileImage.Image = Image.FromFile(filePath);

                        GlobalData.RegisterEmployee = employeesService.GetEmployee(GlobalData.RegisterEmployee.EmployeeId);
                        updateSidebarInfo();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
