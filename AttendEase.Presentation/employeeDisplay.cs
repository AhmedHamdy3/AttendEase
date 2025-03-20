using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.Attendance;
using AttendEase.Presentation.CustomControls;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendEase.Presentation
{
    public partial class EmployeeDisplay : Form
    {
        AttendEaseContext context;
        EmployeeDisplayService employeeDisplay;
        CustomTable table;
        int id;
        bool isFirstImage = true;
        Image image1;
        Image image2;
        int flag = 0;

        public EmployeeDisplay()
        {
            InitializeComponent();
            context = new AttendEaseContext();

            var configBuilder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;
            employeeDisplay = new EmployeeDisplayService(connectionString);

            pnlCrudEmp.Hide();
            
            table = new CustomTable(888, 570, 30, 240);


        }

        private void EmployeeDisplay_Load(object sender, EventArgs e)
        {
            this.Controls.Add(table.tablePanel);
            LoadEmployeesData();

        }



        #region helper methods

        private void LoadEmployeesData()
        {
            var EmployeesData = employeeDisplay.displayOnlyEmployees();
            table.fillTableV3(EmployeesData, new[] { "Id", "Name", "Job Title", "Email", "Phone", "Type" }, "Employees", GetRowData);
        }
        private void GetRowData(int id)
        {

            this.id = id;
            pnlCrudEmp.Show();
            var employee = employeeDisplay.getEmployeeById(id);
            var departments = context.Departments.Select(department => new { department.DepartmentId,department.Name}).ToList();
            var schedules = context.Schedules.Select(schedule => new { schedule.ScheduleId,schedule.Name }).ToList();
            ccb_schedule.DataSource = schedules;
            ccb_schedule.DisplayMember = "Name";
            ccb_schedule.ValueMember = "ScheduleId";
            ccb_dept.DataSource = departments;
            ccb_dept.DisplayMember = "Name";
            ccb_dept.ValueMember = "DepartmentId";

            ctxt_name.Text = employee.Name;
            if (employee.JobTitle != null)
                ccb_jobTitle.SelectedItem = employee.JobTitle ?? "";
            else ccb_jobTitle.SelectedIndex = -1;
            ctxt_email.Text = employee.Email;
            if(employee.Gender != null)
                ccb_gender.SelectedItem = employee.Gender ?? "";
            else ccb_gender.SelectedIndex = -1;

            ctxt_address.Text = employee.Address ?? "";
            ctxt_phone.Text = employee.Phone ?? "";
            ccb_dept.SelectedItem = employee.Department.Name;
            if(employee.EmploymentType != null)
                ccb_emplyeeType.SelectedItem = employee.EmploymentType ?? "";
            else ccb_emplyeeType.SelectedIndex = -1;

            ccb_schedule.SelectedItem = employee.Schedule.Name;

            btn_back.Visible = true;
            csb_addEmployee.Visible = false;

            cbtn_add.Visible = false;
            cbtn_update.Visible = true;
            cbtn_delete.Visible = true;
        }

        #endregion

        private void btn_back_Click(object sender, EventArgs e)
        {
            btn_back.Visible = false;
            csb_addEmployee.Visible = true;
            pnlCrudEmp.Hide();
            LoadEmployeesData();
            clearInputs();
        }

        private void csb_addEmployee_Click(object sender, EventArgs e)
        {
            pnlCrudEmp.Show();



            var departments = context.Departments.Select(department => new { department.DepartmentId, department.Name }).ToList();
            var schedules = context.Schedules.Select(schedule => new { schedule.ScheduleId, schedule.Name }).ToList();
            ccb_schedule.DataSource = schedules;
            ccb_schedule.DisplayMember = "Name";
            ccb_schedule.ValueMember = "ScheduleId";
            ccb_dept.DataSource = departments;
            ccb_dept.DisplayMember = "Name";
            ccb_dept.ValueMember = "DepartmentId";

            ccb_dept.SelectedIndex = -1;
            ccb_schedule.SelectedIndex = -1;

            btn_back.Visible = true;
            csb_addEmployee.Visible = false;

            cbtn_add.Visible = true;
            cbtn_delete.Visible = false;
            cbtn_update.Visible = false;
        }

        private void cbtn_delete_Click(object sender, EventArgs e)
        {
            employeeDisplay.DeleteEmplyee(id);
            MessageBox.Show("Deleted");
            LoadEmployeesData();
            btn_back.PerformClick();
            clearInputs();
        }

        private void cbtn_add_Click(object sender, EventArgs e)
        {
           
           
                ValidateInputs();
            if (flag == 0) {
                employeeDisplay.AddEmployee(ctxt_name.Text, ccb_jobTitle.SelectedItem?.ToString(), ctxt_email.Text, ccb_gender.SelectedItem?.ToString(), ctxt_address.Text, ctxt_phone.Text, (int)ccb_dept.SelectedValue, ccb_emplyeeType.SelectedItem?.ToString(), (int)ccb_schedule.SelectedValue);
                MessageBox.Show("Added");
                LoadEmployeesData();
                btn_back.PerformClick();
                clearInputs();
            }

        }

        private void cbtn_update_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"{ccb_emplyeeType.SelectedItem.ToString()}");

            ValidateUpdates();
            if (flag == 0)
            {

                employeeDisplay.UpdateEmplyee(id, ctxt_name.Text, ccb_jobTitle.SelectedItem?.ToString(), ctxt_email.Text, ccb_gender?.SelectedItem?.ToString(), ctxt_address?.Text, ctxt_phone?.Text, (int)ccb_dept.SelectedValue, ccb_emplyeeType.SelectedItem?.ToString(), (int)ccb_schedule.SelectedValue);
                MessageBox.Show("Updated");
                LoadEmployeesData();
                btn_back.PerformClick();
                clearInputs();
            }
         
        }
        private void clearInputs()
        {
            ctxt_address.Text = ctxt_email.Text = ctxt_name.Text = ctxt_phone.Text = "";
            ccb_emplyeeType.SelectedIndex = ccb_dept.SelectedIndex = ccb_gender.SelectedIndex = ccb_jobTitle.SelectedIndex = ccb_schedule.SelectedIndex = -1;
        }

        private void ValidateInputs()
        {
            flag = 0;

            if (employeeDisplay.getEmployeeByEmail(ctxt_email.Text) != null)
            {
         
                MessageBox.Show("Email already exists.");
                flag = 1;
                return;

            }

            if (!Regex.IsMatch(ctxt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                
                MessageBox.Show("Email Format is not valid.");

                flag = 1;
                return;

            }


            if (!Regex.IsMatch(ctxt_phone.Text, @"^01\d{0,18}$"))
            {
               
                MessageBox.Show("Phone must be 21 digits and starts with 01.");

                flag = 1;
                return;


            }
        }

        private void ValidateUpdates()
        {
            flag = 0;


            if (!Regex.IsMatch(ctxt_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email Format is not valid.");

                flag = 1;
                return;

            }

          



            if (!Regex.IsMatch(ctxt_phone.Text, @"^01\d{0,18}$"))
            {
                MessageBox.Show($"Phone must be 21 digits and starts with 01.");
                flag = 1;
                return;


            }
        }
    }
}
