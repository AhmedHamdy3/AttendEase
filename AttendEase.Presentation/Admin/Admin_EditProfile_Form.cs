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
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation.Admin
{
    public partial class Admin_EditProfile_Form : Form
    {
        int CurrentId = GlobalData.RegisterEmployee.EmployeeId;
        EmployeeDisplayService employeeDisplayService;

        public Admin_EditProfile_Form()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json")
                         .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            employeeDisplayService = new EmployeeDisplayService(connectionString);
        }

        private void btn_updateProfile_Click(object sender, EventArgs e)
        {
            employeeDisplayService.UpdateEmplyee(CurrentId, txt_name.Text, txt_email.Text, txt_phone.Text);
            txt_name.Text=txt_email.Text=txt_phone.Text="";
            MessageBox.Show("Data Updated Successfully");
        }

        private void btn_uploadImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select Profile Picture";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pic_admin.Image = Image.FromFile(openFileDialog.FileName);

                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                    employeeDisplayService.SaveProfilePic(CurrentId, imageBytes);

                }

            }
        }

        private void Admin_EditProfile_Form_Load(object sender, EventArgs e)
        {
            txt_name.Text = employeeDisplayService.getEmployeeById(CurrentId).Name.ToString();
            txt_email.Text = employeeDisplayService.getEmployeeById(CurrentId).Email.ToString();
            txt_phone.Text = employeeDisplayService.getEmployeeById(CurrentId).Phone!.ToString();
     
        }

        private void btn_changePassword_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Change_Password change_Password = new Change_Password() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            change_Password.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(change_Password);
            change_Password.Show();
        }
    }
}
