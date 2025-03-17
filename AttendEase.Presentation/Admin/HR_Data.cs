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
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.Scedual;
using Microsoft.Extensions.Configuration;

namespace AttendEase.Presentation.Admin
{
    public partial class HR_Data : Form
    {
        EmployeesService employeesService;
        EmployeeDisplayService employeeDisplayService;
        DepartmentService departmentService;
        ScheduleServices scheduleServices;

        public HR_Data()
        {
            InitializeComponent();

            var configBuilder = new ConfigurationBuilder()
                           .AddJsonFile("appsettings.json")
                           .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            employeesService = new EmployeesService(connectionString);
            employeeDisplayService = new EmployeeDisplayService(connectionString);
            departmentService = new DepartmentService(connectionString);
            scheduleServices = new ScheduleServices(connectionString);  
        }
        private void HR_Data_Load(object sender, EventArgs e)
        {

            dgv_HRData.DataSource = employeesService.GetEmployess();

            // Background and Borders
            dgv_HRData.BackgroundColor = Color.FromArgb(243, 248, 252); // Matches form background
            dgv_HRData.BorderStyle = BorderStyle.None;
            dgv_HRData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_HRData.GridColor = Color.LightGray;

            // Column Headers Styling
            dgv_HRData.EnableHeadersVisualStyles = false;
            dgv_HRData.ColumnHeadersDefaultCellStyle.BackColor = Color.White; // Pure white header background
            dgv_HRData.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gray; // Gray font color
            dgv_HRData.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Regular); // Font size 16px, weight 400
            dgv_HRData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_HRData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Rows Styling
            //dgv_Schedule.DefaultCellStyle.BackColor = Color.White; // Primary row color
            dgv_HRData.DefaultCellStyle.ForeColor = Color.Black;
            dgv_HRData.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv_HRData.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Disable row selection highlight effect (removes the blue color)
            dgv_HRData.DefaultCellStyle.SelectionBackColor = Color.White;  // No background change on selection
            dgv_HRData.DefaultCellStyle.SelectionForeColor = Color.Black;  // Keep text visible

            // Increase Row Height (More Spacing)
            dgv_HRData.RowTemplate.Height = 50;

            // Alternating Row Style (Zebra Effect)
            //dgv_Schedule.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(231, 237, 249); // Alternating row color
            dgv_HRData.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row Headers Styling
            //dgv_HRData.RowHeadersVisible = false;

            // Auto-size columns to fit content
            dgv_HRData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_HRData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Adjust header height
            dgv_HRData.ColumnHeadersHeight = 30;

            dgv_HRData.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgv_HRData.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Gray;

            dgv_HRData.RowPrePaint += (s, e) =>
            {
                if (e.RowIndex % 2 == 0) // Even index (0, 2, 4, etc.) -> Gray
                {
                    dgv_HRData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(231, 237, 249);
                }
                else // Odd index (1, 3, 5, etc.) -> White
                {
                    dgv_HRData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            };
            // Row Headers Styling
            dgv_HRData.RowHeadersWidth = 20; // Adjust width for visibility
            dgv_HRData.RowHeadersDefaultCellStyle.BackColor = Color.White; // Background color of row headers
            dgv_HRData.RowHeadersDefaultCellStyle.ForeColor = Color.Gray; // Text color
            dgv_HRData.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Font style
            dgv_HRData.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Remove border for a clean look
            dgv_HRData.RowHeadersDefaultCellStyle.SelectionBackColor = Color.White; // Change blue highlight to white
            dgv_HRData.RowHeadersDefaultCellStyle.SelectionForeColor = Color.Black; // Ensure text remains visible


        }
        int selectedId;
        private void dgv_HRData_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
         
                selectedId = (int)dgv_HRData.CurrentRow.Cells["id"].Value!;
                var employee = employeeDisplayService.getEmployeeById(selectedId);
                var departments = departmentService.GetDepartments();
                var schedules = scheduleServices.GetSchedule();

                var employees = employeeDisplayService.displayEmployees();
                List<string> Employmenttype = employees.Select(e => e.EmploymentType).ToList();
                var departmentList = departments.Select(e => new { Id = e.DepartmentId, Name = e.Name }).Distinct().ToList();
                var scheduleList = schedules.Select(e => new { Id = e.ScheduleId, Name = e.Name }).Distinct().ToList();

                 this.Controls.Clear();
                Control_HRs control_HRs_form = new Control_HRs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                if (employee != null)

                {
                    control_HRs_form.SetHRData(Employmenttype, 
                        departmentList.Cast<dynamic>().ToList(),
                         scheduleList.Cast<dynamic>().ToList());
                    control_HRs_form.SetHRData(employee.EmployeeId, employee.Name, employee.Email, employee.JobTitle!, employee.Phone!, employee.EmploymentType, employee.Department.Name, employee.Schedule.Name);

                }
                control_HRs_form.FormBorderStyle = FormBorderStyle.None;
                this.Controls.Add(control_HRs_form);
                control_HRs_form.Show();

        }
        
        private void btn_ControlHRs_Click(object sender, EventArgs e)
        {

            var employees = employeeDisplayService.displayEmployees();
            var departments = departmentService.GetDepartments();
            var schedules = scheduleServices.GetSchedule();

            List<string> Employmenttype = employees.Select(e=>e.EmploymentType).ToList();
            var departmentList = departments.Select(e => new { Id = e.DepartmentId, Name = e.Name }).Distinct().ToList();
            var scheduleList = schedules.Select(e => new { Id = e.ScheduleId, Name = e.Name }).Distinct().ToList();

            this.Controls.Clear();
            Control_HRs control_HRs_form = new Control_HRs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


            control_HRs_form.SetHRData("", "", "","", Employmenttype,
                            departmentList.Cast<dynamic>().ToList(),
                            scheduleList.Cast<dynamic>().ToList());

            control_HRs_form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(control_HRs_form);
            control_HRs_form.Show();
        }
    }   
}
