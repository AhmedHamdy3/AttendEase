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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendEase.Presentation.Admin
{
    public partial class Control_HRs : Form
    {
        EmployeeDisplayService employeeDisplayService;
        int id = 0;
        public Control_HRs()
        {
            InitializeComponent();
            var configBuilder = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json")
                         .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            employeeDisplayService = new EmployeeDisplayService(connectionString);
        }

        private void btn_manageHRs_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            HR_Data hR_Data_form = new HR_Data() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hR_Data_form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(hR_Data_form);
            hR_Data_form.Show();
        }
        public void SetHRData(int empId, string name, string email, string jobTitle, string phone, string empType, string dept, string schedule)
        {
            id = empId;
            txt_name.Text = name;
            txt_email.Text = email;
            txt_jobTitle.Text = jobTitle;
            txt_phone.Text = phone;
            cb_empTypee.Text = empType;
            cb_deptt.Text = dept;
            cb_schedulee.Text = schedule;
        }

        public void SetHRData(string name, string email, string jobTitle, string phone, List<string> empType, List<dynamic> dept, List<dynamic> schedule)
        {
            txt_name.Text = name;
            txt_email.Text = email;
            txt_jobTitle.Text = jobTitle;
            txt_phone.Text = phone;
            cb_empTypee.DataSource = empType.Distinct().ToList();
            cb_deptt.DataSource = dept.Distinct().ToList();
            cb_deptt.DisplayMember = "Name";
            cb_deptt.ValueMember = "Id";
            cb_schedulee.DataSource = schedule.Distinct().ToList();
            cb_schedulee.DisplayMember = "Name";
            cb_schedulee.ValueMember = "Id";


        }

        public void SetHRData(List<string> empType, List<dynamic> dept, List<dynamic> schedule)
        {
            cb_empTypee.DataSource = empType.Distinct().ToList();
            cb_deptt.DataSource = dept.Distinct().ToList();
            cb_deptt.DisplayMember = "Name";
            cb_deptt.ValueMember = "Id";
            cb_schedulee.DataSource = schedule.Distinct().ToList();
            cb_schedulee.DisplayMember = "Name";
            cb_schedulee.ValueMember = "Id";

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            List<string> emails = employeeDisplayService.displayEmployees().Select(e => e.Email).ToList() ;
            if (emails.Contains(txt_email.Text))
                MessageBox.Show("This Email Already Exists");
            else
            {
                employeeDisplayService.AddEmployee(txt_name.Text, txt_jobTitle.Text, txt_email.Text, txt_phone.Text, (int)cb_deptt.SelectedValue!, cb_empTypee.Text, (int)cb_schedulee.SelectedValue!);
                txt_name.Text = txt_email.Text = txt_jobTitle.Text = txt_phone.Text = cb_deptt.Text = cb_empTypee.Text = cb_schedulee.Text = "";
                MessageBox.Show("Added Successfully");
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            employeeDisplayService.UpdateEmplyee(id, txt_name.Text, txt_jobTitle.Text, txt_email.Text, txt_phone.Text, (int)cb_deptt.SelectedValue!, cb_empTypee.Text, (int)cb_schedulee.SelectedValue!);
            txt_name.Text = txt_email.Text = txt_jobTitle.Text = txt_phone.Text = cb_deptt.Text = cb_empTypee.Text = cb_schedulee.Text = "";
            MessageBox.Show("Updated Successfully");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            employeeDisplayService.DeleteEmplyee(id);
            txt_name.Text = txt_email.Text = txt_jobTitle.Text = txt_phone.Text = cb_deptt.Text = cb_empTypee.Text = cb_schedulee.Text = "";
            MessageBox.Show("Deleted Successfully");

        }
    }
}
