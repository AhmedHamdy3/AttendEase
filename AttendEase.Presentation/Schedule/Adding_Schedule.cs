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
    public partial class Adding_Schedule : Form
    {
        ScheduleServices scheduleServices;
        public Adding_Schedule()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                               .AddJsonFile("appsettings.json")
                               .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            scheduleServices = new ScheduleServices(connectionString);
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Scedual_details scedual_Details_form = new Scedual_details() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            scedual_Details_form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(scedual_Details_form);
            scedual_Details_form.Show();
        }
        #region click on lables
        private void label3_Click(object sender, EventArgs e)
        {
            checkBox_satarday.Checked = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            checkBox_sunday.Checked = true;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            checkBox_monday.Checked = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            checkBox_tuesday.Checked = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            checkBox_wednesday.Checked = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            checkBox_thrusday.Checked = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            checkBox_friday.Checked = true;
        }
        #endregion

         

        private void btn_CreateSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(txt_description.Text))
            {
                MessageBox.Show("Please fill in the name and description.");
                return;
            }

            var start = new  List<DateTime>();
            var end   = new  List<DateTime>();
            var selectedDays = new List<string>();

            if (checkBox_satarday.Checked) 
            { 
                selectedDays.Add("Saturday");
                start.Add(dtp_attend_saturday.Value);
                end.Add(dtp_departure_saturday.Value); 
            }
            if (checkBox_sunday.Checked) 
            { 
                selectedDays.Add("Sunday");
                start.Add(dtp_attend_sunday.Value); 
                end.Add(dtp_departure_sunday.Value); 
            }
            if (checkBox_monday.Checked) 
            { 
                selectedDays.Add("Monday");
                start.Add(dtp_attend_monday.Value);
                end.Add(dtp_departure_monday.Value);
            }
            if (checkBox_tuesday.Checked) 
            { 
                selectedDays.Add("Tuesday");
                start.Add(dtp_attend_tuesday.Value);
                end.Add(dtp_departure_tuesday.Value);
            }
            if (checkBox_wednesday.Checked)
            {
                selectedDays.Add("Wednesday");
                start.Add(dtp_attend_wednesday.Value);
                end.Add(dtp_departure_wednesday.Value);
            }
            if (checkBox_thrusday.Checked)
            { 
                selectedDays.Add("Thursday");
                start.Add(dtp_attend_thrusday.Value); 
                end.Add(dtp_departure_thrusday.Value);
            }
            if (checkBox_friday.Checked)
            {
                selectedDays.Add("Friday");
                start.Add(dtp_attend_friday.Value); 
                end.Add(dtp_departure_friday.Value); 
            }

            if (!selectedDays.Any())
            {
                MessageBox.Show("Please choose at least one day!");
                return;
            }

            string name = txt_name.Text;
            string description = txt_description.Text;


            //int returned =
            scheduleServices.AddSchedule(name, description, start, end, selectedDays);
            //if (returned == 1)
            //{
                MessageBox.Show("Schedule Added Successfully!");
                txt_name.Clear();
                txt_description.Clear();
                checkBox_satarday.Checked = checkBox_sunday.Checked = checkBox_monday.Checked =
                checkBox_tuesday.Checked = checkBox_wednesday.Checked = checkBox_thrusday.Checked =
                checkBox_friday.Checked = false;
            //}
            //else if (returned == -1) 
            //{
            //    MessageBox.Show("This Schedule Already Exists");
            //}
        }
    }
}
