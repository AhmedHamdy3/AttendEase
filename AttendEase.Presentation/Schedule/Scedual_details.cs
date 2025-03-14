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
using AttendEase.Presentation.CustomControls;
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation.Scedual
{
    public partial class Scedual_details : Form
    {
        ScheduleServices scheduleServices;
        CustomTable table;

        public Scedual_details()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                               .AddJsonFile("appsettings.json")
                               .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;


            scheduleServices = new ScheduleServices(connectionString);
            pnl_addSchedule.Hide();
        }

        private void Scedual_details_Load(object sender, EventArgs e)
        {
            table = new CustomTable(888, 570, 30, 240);
            showSchedules();
            this.Controls.Add(table.tablePanel);
        }
        private void showSchedules()
        {
            var schedules = scheduleServices.GetSchedules();
            table.fillTableV3(schedules, new[] { "Name", "Description" }, "Schedules", showSchedulesWorkDays);
        }

        private void showSchedulesWorkDays(int id)
        {
            var scheduleWorkDays = scheduleServices.GetScheduleWorkDays(id);
            ScheduleWorkDaysForm scheduleWorkDaysForm = new ScheduleWorkDaysForm(scheduleWorkDays);
            scheduleWorkDaysForm.ShowDialog();
        }

        private void btn_AddSchedule_Click(object sender, EventArgs e)
        {
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            pnl_addSchedule.Hide();
            btn_back.Hide();
            csb_addSchedule.Show();
            showSchedules();
            clearInputs(); 
        }

        private void csb_addSchedule_Click(object sender, EventArgs e)
        {
            pnl_addSchedule.Show();
            btn_back.Show();
            csb_addSchedule.Hide();
        }

        private void cbtn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ctxt_name.Text) || string.IsNullOrWhiteSpace(ctxt_description.Text))
            {
                MessageBox.Show("Please fill in the name and description.");
                return;
            }

            var start = new List<DateTime>();
            var end = new List<DateTime>();
            var selectedDays = new List<string>();

            if (chb_saturday.Checked)
            {
                selectedDays.Add("Saturday");
                start.Add(cdtp_saturday_startDate.Value);
                end.Add(cdtp_saturday_endDate.Value);
            }
            if (chb_sunday.Checked)
            {
                selectedDays.Add("Sunday");
                start.Add(cdtp_sunday_startDate.Value);
                end.Add(cdtp_sunday_endDate.Value);
            }
            if (chb_monday.Checked)
            {
                selectedDays.Add("Monday");
                start.Add(cdtp_monrday_startDate.Value);
                end.Add(cdtp_monrday_endDate.Value);
            }
            if (chb_tuesday.Checked)
            {
                selectedDays.Add("Tuesday");
                start.Add(cdtp_Tuesday_startDate.Value);
                end.Add(cdtp_Tuesday_endDate.Value);
            }
            if (chb_wednesday.Checked)
            {
                selectedDays.Add("Wednesday");
                start.Add(cdtp_wednesday_startDate.Value);
                end.Add(cdtp_wednesday_endDate.Value);
            }
            if (chb_thursday.Checked)
            {
                selectedDays.Add("Thursday");
                start.Add(cdtp_Thurday_startDate.Value);
                end.Add(cdtp_Thurday_endDate.Value);
            }
            if (chb_friday.Checked)
            {
                selectedDays.Add("Friday");
                start.Add(cdtp_friday_startDate.Value);
                end.Add(cdtp_friday_endDate.Value);
            }

            if (!selectedDays.Any())
            {
                MessageBox.Show("Please choose at least one day!");
                return;
            }

            string name = ctxt_name.Text;
            string description = ctxt_description.Text;
            scheduleServices.AddSchedule(name, description, start, end, selectedDays);
            
            MessageBox.Show("Schedule Added Successfully!");

            btn_back.PerformClick();
        }
        public void clearInputs()
        {
            ctxt_description.Text = ctxt_name.Text = "";
            chb_friday.Checked = chb_monday.Checked = chb_saturday.Checked = chb_saturday.Checked = chb_sunday.Checked =
                chb_thursday.Checked = chb_tuesday.Checked = chb_wednesday.Checked = false;
        }
    }
}

