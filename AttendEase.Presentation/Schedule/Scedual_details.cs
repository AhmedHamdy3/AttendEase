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
            ccb_DayOfWeek.DataSource = new List<string>
            {
                "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"
            };

            // Background and Borders
            dgv_Schedule.BackgroundColor = Color.FromArgb(243, 248, 252); // Matches form background
            dgv_Schedule.BorderStyle = BorderStyle.None;
            dgv_Schedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Schedule.GridColor = Color.LightGray;

            // Column Headers Styling
            dgv_Schedule.EnableHeadersVisualStyles = false;
            dgv_Schedule.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // Pure white header background
            dgv_Schedule.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray; // Gray font color
            dgv_Schedule.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular); // Font size 16px, weight 400
            dgv_Schedule.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Schedule.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Rows Styling
            //dgv_Schedule.DefaultCellStyle.BackColor = Color.White; // Primary row color
            dgv_Schedule.DefaultCellStyle.ForeColor = Color.Black;
            dgv_Schedule.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_Schedule.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Disable row selection highlight effect (removes the blue color)
            dgv_Schedule.DefaultCellStyle.SelectionBackColor = Color.White;  // No background change on selection
            dgv_Schedule.DefaultCellStyle.SelectionForeColor = Color.Black;  // Keep text visible

            // Increase Row Height (More Spacing)
            dgv_Schedule.RowTemplate.Height = 50;

            // Alternating Row Style (Zebra Effect)
            //dgv_Schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(231, 237, 249); // Alternating row color
            dgv_Schedule.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row Headers Styling
            dgv_Schedule.RowHeadersVisible = false;

            // Auto-size columns to fit content
            dgv_Schedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Schedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Adjust header height
            dgv_Schedule.ColumnHeadersHeight = 30;

            dgv_Schedule.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgv_Schedule.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Gray;

            dgv_Schedule.RowPrePaint += (s, e) =>
            {
                if (e.RowIndex % 2 == 0) // Even index (0, 2, 4, etc.) -> Gray
                {
                    dgv_Schedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(231, 237, 249);
                }
                else // Odd index (1, 3, 5, etc.) -> White
                {
                    dgv_Schedule.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };

        }

        private void btn_AddSchedule_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Adding_Schedule adding_Schedule_form = new Adding_Schedule() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            adding_Schedule_form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(adding_Schedule_form);
            adding_Schedule_form.Show();


        }

        private void ccb_DayOfWeek_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ccb_DayOfWeek.SelectedItem != null)
            {
                dgv_Schedule.DataSource = scheduleServices.GetSchedule(ccb_DayOfWeek.SelectedItem.ToString());
                dgv_Schedule.ClearSelection(); // Optional: Removes default selection highlight

            }

        }
    }
}

