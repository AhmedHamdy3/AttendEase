using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation
{
    public partial class DashboardPanelForm : Form
    {
        int CurrentId = GlobalData.EmployeeId;
        AttendEaseContext context;
        AttendanceService attendanceService;
     
        public DashboardPanelForm()
        {
            InitializeComponent();

            context = new AttendEaseContext();

            var configBuilder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;



            attendanceService = new AttendanceService(connectionString);

            if (attendanceService.HasCheckedIn(CurrentId) == true)
            {
                btn_checkin.Enabled = false;
            }
            if (attendanceService.HasCheckedOut(CurrentId) == true)
            {
                btn_checkout.Enabled = false;
            }
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            attendanceService.HrCheckIn(CurrentId);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            attendanceService.HrCheckOut(CurrentId);

        }

        private void btn_qr_Click(object sender, EventArgs e)
        {
            QrReaderForm frm= new QrReaderForm();
            frm.ShowDialog();

           
        }
    }
}
