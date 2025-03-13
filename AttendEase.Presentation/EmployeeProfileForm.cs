using AttendEase.BusinessLogic;
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
    public partial class EmployeeProfileForm : Form
    {
        EmployeesService employeesService;
        //Action updateSidebarInfo;
        public EmployeeProfileForm()
        {
            InitializeComponent();

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
            ctxt_address.Text = GlobalData.RegisterEmployee.Address;
            ctxt_email.Text = GlobalData.RegisterEmployee.Email;
            ctxt_name.Text = GlobalData.RegisterEmployee.Name;
            ctxt_phone.Text = GlobalData.RegisterEmployee.Phone;
            ccb_gender.SelectedItem = GlobalData.RegisterEmployee.Gender;

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

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void cbtn_save_Click(object sender, EventArgs e)
        {
            var name = ctxt_name.Text;
            var email = ctxt_email.Text;
            var address = ctxt_address.Text;
            var phone = ctxt_phone.Text;
            var gender = ccb_gender.SelectedItem.ToString();
            employeesService.UpdateInfo(GlobalData.RegisterEmployee.EmployeeId, name, email, phone, gender, address);
            GlobalData.RegisterEmployee = employeesService.GetEmployee(GlobalData.RegisterEmployee.EmployeeId);
            MessageBox.Show("Data Updated Successfully");
            //updateSidebarInfo.Invoke();
        }
    }
}
