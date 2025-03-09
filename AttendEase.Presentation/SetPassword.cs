using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.CustomControls;
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation
{
    public partial class SetPassword : Form
    {
        private readonly AttendanceService attendanceService;
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
            attendanceService = new AttendanceService(connectionString);
        }

        private void SetPassword_Load(object sender, EventArgs e)
        {
            var dailyAttendance = attendanceService.GetAttendanceInSpecificPeriod(new DateTime(2025, 02, 23), new DateTime(2025, 02, 27));
            //dataGridView1.DataSource = dailyAttendance;
        }


        private void csb_setPassword_Click(object sender, EventArgs e)
        {
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
    }
}
