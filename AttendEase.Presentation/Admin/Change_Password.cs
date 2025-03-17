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
    public partial class Change_Password : Form
    {
        int CurrentId = GlobalData.RegisterEmployee.EmployeeId;
        EmployeeDisplayService employeeDisplayService;
        public Change_Password()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            employeeDisplayService = new EmployeeDisplayService(connectionString);
        }
        private void show_currentPass_Click(object sender, EventArgs e)
        {
            txt_currentPass.PasswordChar = false;
        }
        private void show_pass_Click(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = false;
        }

        private void show_confirm_Click(object sender, EventArgs e)
        {
            txt_confirm.PasswordChar = false;
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Admin_EditProfile_Form admin_EditProfile_Form = new Admin_EditProfile_Form() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            admin_EditProfile_Form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(admin_EditProfile_Form);
            admin_EditProfile_Form.Show();
        }

        private void btn_resetPass_Click(object sender, EventArgs e)
        {
            if (txt_currentPass.Text != employeeDisplayService.getEmployeeById(CurrentId).Password!.ToString())
                MessageBox.Show("Your old password is not correct");
            else if (txt_pass.Text != txt_confirm.Text)
                MessageBox.Show("New Password not matching");
            else
            {
                employeeDisplayService.UpdateEmplyeePass(CurrentId, txt_pass.Text);
                txt_pass.Text=txt_currentPass.Text=txt_confirm.Text="";
                MessageBox.Show("Password Changed");
            }

        }
    }
}

