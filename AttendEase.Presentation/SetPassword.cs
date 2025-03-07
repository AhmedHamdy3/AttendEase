using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation
{
    public partial class SetPassword : Form
    {
        private readonly AttendanceService attendanceService;
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
    }
}
