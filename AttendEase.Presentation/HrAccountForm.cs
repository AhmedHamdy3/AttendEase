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
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation
{
    public partial class HrAccountForm : Form
    {
        int CurrentId=GlobalData.EmployeeId;
        AttendEaseContext context;
        EmployeeDisplayService employeeDisplayService;

        public HrAccountForm()
        {
            InitializeComponent();

            context = new AttendEaseContext();

            var configBuilder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            employeeDisplayService = new EmployeeDisplayService(connectionString);
        }

        private void btn_updateProfile_Click(object sender, EventArgs e)
        {
            employeeDisplayService.UpdateEmplyee(CurrentId, txt_name.Text, txt_email.Text, txt_pass.Text, txt_phone.Text);
        }

        private void btn_uploadImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Title = "Select Profile Picture";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog()==DialogResult.OK) {
                pic_hr.Image=Image.FromFile(openFileDialog.FileName);

                    byte[] imageBytes= File.ReadAllBytes(openFileDialog.FileName);

                    employeeDisplayService.SaveProfilePic(CurrentId, imageBytes);
                
                }
            
            }
        }
    }
}
