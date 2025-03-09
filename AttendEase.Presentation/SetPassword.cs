using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.CustomControls;
using Microsoft.Extensions.Configuration;
using System.Text.RegularExpressions;

namespace AttendEase.Presentation
{
    public partial class SetPassword : Form
    {
        private readonly EmployeesService employeesService;
        private bool isVisiblePass = false;
        private bool isVisibleConf = false;

        public SetPassword()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            employeesService = new EmployeesService(connectionString);
        }

        private void SetPassword_Load(object sender, EventArgs e)
        {

        }


        private void csb_setPassword_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;
            string confirm = txt_confirm.Text;
            Employee employee = employeesService.GetEmployee(email);
            if (employee != null)
            {
                if (employee.Password != null)
                {
                    MessageBox.Show("You already set your password before\nGo to the login page");
                }
                else
                {
                    int flag = 1;
                    if (!Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
                    {
                        flag = 0;
                        MessageBox.Show("Password must be at least 8 characters long and include at least one uppercase letter, one lowercase letter, and one number.");
                    }
                    if (password != confirm)
                    {
                        flag = 0;
                        MessageBox.Show("Confirm Password is not correct.");
                    }
                    if (flag == 1) { 
                        employeesService.UpdatePassword(email, password);
                        MessageBox.Show("The password has been set successfully.");
                        csb_singIn.PerformClick();
                    }

                }
            }
            else
            {
                MessageBox.Show("There is no user with that email\nContact with HR");
            }
        }

        private void csb_singIn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.StartPosition = FormStartPosition.Manual;
            signInForm.Location = this.Location;
            signInForm.Show();
            this.Close();
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisiblePass)
            {
                txt_password.PasswordChar = '\0';
                btn.Image = (Image)Properties.Resources.Invisible;
            }
            else
            {
                txt_password.PasswordChar = '*';
                btn.Image = (Image)Properties.Resources.Eye1;
            }
            isVisiblePass = !isVisiblePass;
        }

        private void btn_showConfirm_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisibleConf)
            {
                txt_confirm.PasswordChar = '\0';
                btn.Image = (Image)Properties.Resources.Invisible;
            }
            else
            {
                txt_confirm.PasswordChar = '*';
                btn.Image = (Image)Properties.Resources.Eye1;
            }
            isVisibleConf = !isVisibleConf;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(txt_password.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$"))
            {
                lbl_passwordError.Text = "Password must be at least 8 characters long and include at\nleast one uppercase letter, one lowercase letter, and one number.";
            }
            else
            {
                lbl_passwordError.Text = "";
            }

        }

        private void txt_confirm_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text != txt_confirm.Text)
            {
                lbl_confirmError.Text = "Password & Confirm Password aren't matched";
            }
            else
            {
                lbl_confirmError.Text = "";
            }
        }
    }
}
