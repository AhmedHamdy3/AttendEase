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

namespace AttendEase.Presentation.Scedual
{
    public partial class Scedual_details : Form
    {
        ScheduleServices scheduleServices;
        public Scedual_details()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                               .AddJsonFile("appsettings.json")
                               .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            scheduleServices = new ScheduleServices(connectionString);
        }

        private void Scedual_details_Load(object sender, EventArgs e)
        {
            dgv_Schedule.DataSource = scheduleServices.GetSchedule();

            dgv_Schedule.BackgroundColor = Color.FromArgb(243, 248, 252); // Matches form background
            dgv_Schedule.BorderStyle = BorderStyle.None; // Clean border
            dgv_Schedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Schedule.GridColor = Color.LightGray;

            // Column Headers Styling
            dgv_Schedule.EnableHeadersVisualStyles = false;
            dgv_Schedule.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(200, 220, 240); // Subtle blue-gray
            dgv_Schedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv_Schedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv_Schedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Schedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center header text

            // Rows Styling
            dgv_Schedule.DefaultCellStyle.BackColor = Color.White; // Clean, professional look
            dgv_Schedule.DefaultCellStyle.ForeColor = Color.Black;
            dgv_Schedule.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_Schedule.DefaultCellStyle.SelectionBackColor = Color.FromArgb(120, 180, 240); // Soft blue selection
            dgv_Schedule.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv_Schedule.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Center cell text

            // Increase Row Height (More Spacing)
            dgv_Schedule.RowTemplate.Height = 50; // Adjust this value for more or less spacing

            // Alternating Row Style (Zebra Effect)
            dgv_Schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 240, 250); // Light blue-gray
            dgv_Schedule.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Ensure alternating rows are also centered

            // Row Headers Styling
            dgv_Schedule.RowHeadersVisible = false;

            // Auto-size columns to fit content
            dgv_Schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Schedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_Schedule.ColumnHeadersHeight = 40; // Adjust header height (default is around 23)

        }

        private void btn_AddSchedule_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Adding_Schedule adding_Schedule_form = new Adding_Schedule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            adding_Schedule_form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(adding_Schedule_form);
            adding_Schedule_form.Show();


        }
    }
}

