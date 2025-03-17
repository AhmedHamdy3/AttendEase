using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.Admin;
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
    public partial class SignInForm : Form
    {
        private bool isVisiblePass = false;
        EmployeesService employeesService;
        public SignInForm()
        {
            InitializeComponent();
            GlobalData.signInForm = this;

            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            employeesService = new EmployeesService(connectionString);
        }

        private void csb_setPassword_Click(object sender, EventArgs e)
        {
            SetPassword setPassword = new SetPassword();
            setPassword.StartPosition = FormStartPosition.Manual;
            setPassword.Location = this.Location;
            setPassword.Show();
            this.Hide();
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisiblePass)
            {
                ctxt_password.PasswordChar = false;
                btn.Image = (Image)Properties.Resources.Invisible;
            }
            else
            {
                ctxt_password.PasswordChar = true;
                btn.Image = (Image)Properties.Resources.Eye1;
            }
            isVisiblePass = !isVisiblePass;
        }

        private void csb_signIn_Click(object sender, EventArgs e)
        {
            string email = ctxt_email.Text;
            string password = ctxt_password.Text;
            Employee? employee = employeesService.GetEmployee(email, password);
            if (employee != null)
            {
                GlobalData.RegisterEmployee = employee;
                if (employee.JobTitle == "HR")
                {
                    HRDashboard hrDashboard = new HRDashboard();
                    hrDashboard.StartPosition = FormStartPosition.Manual;
                    hrDashboard.Location = this.Location;
                    hrDashboard.Show();
                }
                else if (employee.JobTitle == "Employee")
                {
                    EmployeeMainForm employeeMainForm = new EmployeeMainForm();
                    employeeMainForm.StartPosition = FormStartPosition.Manual;
                    employeeMainForm.Location = this.Location;
                    employeeMainForm.Show();
                }
                else if (employee.JobTitle == "Admin")
                {
                    AdminForm admin= new AdminForm();
                    admin.StartPosition = FormStartPosition.Manual;
                    admin.Location = this.Location;
                    admin.Show();
                }
                ctxt_email.Text = ctxt_password.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email Or Password not correct");
            }
        }
    }
}
