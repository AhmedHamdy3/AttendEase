using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.CustomControls;
using Microsoft.Extensions.Configuration;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            table = new CustomTable(914, 539, 27, 222);
           
           
        }

        private void EmployeeDisplay_Load(object sender, EventArgs e)
        {
            this.Controls.Add(table.tablePanel);
            LoadEmployeesData();

        }

        private void btn_manageEmps_Click(object sender, EventArgs e)
        {
            toggleBtn();
        }

        private void btn_show1_Click_1(object sender, EventArgs e)
        {
            image1 = Image.FromFile(@"E:\\newShimaa\\EF-project\\AttendEase\\AttendEase.Presentation\\Resources\\Eye.png");
            image2 = Image.FromFile(@"E:\newShimaa\EF-project\AttendEase\AttendEase.Presentation\Resources\icons8-blind-30.png");



            if (isFirstImage)
            {
                picEye1.Image = image2;
                txt_pass.PasswordChar = true;
              
            }
            else
            {
                picEye1.Image = image1;
                txt_pass.PasswordChar = false;

            }
            isFirstImage = !isFirstImage;
        }

        private void btn_show2_Click_1(object sender, EventArgs e)
        {
            image1 = Image.FromFile(@"E:\\newShimaa\\EF-project\\AttendEase\\AttendEase.Presentation\\Resources\\Eye.png");
            image2 = Image.FromFile(@"E:\newShimaa\EF-project\AttendEase\AttendEase.Presentation\Resources\icons8-blind-30.png");




            if (isFirstImage)
            {
                picEye2.Image = image2;
                txt_confirm.PasswordChar = true;

            }
            else
            {
                picEye2.Image = image1;
                txt_confirm.PasswordChar = false;

            }
            isFirstImage = !isFirstImage;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            employeeDisplay.AddEmployee(txt_name.Text, txt_jobTitle.Text, txt_email.Text, txt_pass.Text, txt_phone.Text, (int)cb_deptt.SelectedValue, (string)cb_empTypee.SelectedValue, (int)cb_schedulee.SelectedValue);
            txt_name.Text = txt_jobTitle.Text = txt_email.Text = txt_pass.Text = txt_phone.Text = "";
            MessageBox.Show("Added");
            LoadEmployeesData();
        }

     
        private void btn_update_Click(object sender, EventArgs e)
        {
           employeeDisplay.UpdateEmplyee(id, txt_name.Text, txt_jobTitle.Text, txt_email.Text, txt_pass.Text, txt_phone.Text, (int)cb_deptt.SelectedValue, (string)cb_empTypee.SelectedValue, (int)cb_schedulee.SelectedValue);
            txt_name.Text = txt_jobTitle.Text = txt_email.Text = txt_pass.Text = txt_phone.Text = "";
            MessageBox.Show("Updated");
            LoadEmployeesData();
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            employeeDisplay.DeleteEmplyee(id);
            txt_name.Text = txt_jobTitle.Text = txt_email.Text = txt_pass.Text = txt_phone.Text = "";
            MessageBox.Show("Deleted");
            LoadEmployeesData();
        }





        #region helper methods

        private void LoadEmployeesData()
        {
            var EmployeesData = employeeDisplay.displayEmployees();
            table.fillTableV2(EmployeesData, new[] { "EmployeeId", "Name", "JobTitle", "Email", "Password", "Phone", "EmploymentType" }, GetRowData);


        }
        private void toggleBtn()
        {

            if (btn_manageEmp.Text == "          Manage Employees")
            {
                btn_manageEmp.Text = "Step Back";

                pnlCrudEmp.Show();


               cb_empTypee.DataSource = context.Employees.Select(x => x.EmploymentType).Distinct().ToList();


                var schedules = context.Schedules.ToList();
                cb_schedulee.DataSource = schedules;
                cb_schedulee.ValueMember = "ScheduleId";
                cb_schedulee.DisplayMember = "Name";
                var departments = context.Departments.ToList();
                cb_deptt.DataSource = departments;
                cb_deptt.ValueMember = "DepartmentId";
                cb_deptt.DisplayMember = "Name";

            }
            else
            {
                pnlCrudEmp.Hide();
                LoadEmployeesData();
                btn_manageEmp.Text = "          Manage Employees";


            }
        }
        private void GetRowData(int id)
        {

            this.id = id;
            pnlCrudEmp.Show();
            toggleBtn();
            var employee = employeeDisplay.getEmployeeById(id);
            txt_name.Text = employee.Name;
            txt_pass.Text = employee.Password;
            txt_email.Text = employee.Email;
            txt_jobTitle.Text = employee.JobTitle;
            txt_phone.Text = employee.Phone;
            cb_deptt.SelectedValue = employee.DepartmentId;
            cb_empTypee.SelectedItem = employee.EmploymentType;
            cb_schedulee.SelectedValue = employee.ScheduleId;

        }

        #endregion
    }
}
