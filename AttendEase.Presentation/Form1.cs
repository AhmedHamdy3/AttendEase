using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation
{
    public partial class Form1 : Form
    {
        private readonly AttendanceService attendanceService;
        public Form1()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            attendanceService = new AttendanceService(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var dailyAttendance = attendanceService.getLast10DaysAttendanceSummary(0);
            dataGridView1.DataSource = dailyAttendance;
        }
    }
}
