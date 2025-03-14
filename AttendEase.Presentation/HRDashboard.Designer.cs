namespace AttendEase.Presentation
{
    partial class HRDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HRDashboard));
            panel1 = new Panel();
            pnl_sideBar = new Panel();
            cbtn_unreadedRequests = new CustomControls.CustomButton();
            btn_logout = new CustomControls.CustomButton();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btn_employees = new Button();
            btn_schedules = new Button();
            btn_attendance = new Button();
            btn_arrivals = new Button();
            btn_frequentAbsent = new Button();
            btn_leaveRequest = new Button();
            btn_dashboard = new Button();
            lbl_subTitle = new Label();
            lbl_employeeName = new Label();
            panel3 = new Panel();
            pnl_formLoader = new Panel();
            panel1.SuspendLayout();
            pnl_sideBar.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 233, 234);
            panel1.Controls.Add(pnl_sideBar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 856);
            panel1.TabIndex = 0;
            // 
            // pnl_sideBar
            // 
            pnl_sideBar.BackColor = Color.White;
            pnl_sideBar.Controls.Add(cbtn_unreadedRequests);
            pnl_sideBar.Controls.Add(btn_logout);
            pnl_sideBar.Controls.Add(flowLayoutPanel8);
            pnl_sideBar.Controls.Add(btn_employees);
            pnl_sideBar.Controls.Add(btn_schedules);
            pnl_sideBar.Controls.Add(btn_attendance);
            pnl_sideBar.Controls.Add(btn_arrivals);
            pnl_sideBar.Controls.Add(btn_frequentAbsent);
            pnl_sideBar.Controls.Add(btn_leaveRequest);
            pnl_sideBar.Controls.Add(btn_dashboard);
            pnl_sideBar.Controls.Add(lbl_subTitle);
            pnl_sideBar.Controls.Add(lbl_employeeName);
            pnl_sideBar.Location = new Point(0, 0);
            pnl_sideBar.Name = "pnl_sideBar";
            pnl_sideBar.Size = new Size(300, 853);
            pnl_sideBar.TabIndex = 1;
            // 
            // cbtn_unreadedRequests
            // 
            cbtn_unreadedRequests.BackColor = Color.FromArgb(233, 245, 254);
            cbtn_unreadedRequests.BorderColor = Color.Black;
            cbtn_unreadedRequests.BorderRadius = 6;
            cbtn_unreadedRequests.BorderSize = 0;
            cbtn_unreadedRequests.FlatAppearance.BorderSize = 0;
            cbtn_unreadedRequests.FlatAppearance.MouseDownBackColor = Color.FromArgb(233, 245, 254);
            cbtn_unreadedRequests.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 245, 254);
            cbtn_unreadedRequests.FlatStyle = FlatStyle.Flat;
            cbtn_unreadedRequests.ForeColor = Color.FromArgb(30, 37, 43);
            cbtn_unreadedRequests.Location = new Point(233, 573);
            cbtn_unreadedRequests.Name = "cbtn_unreadedRequests";
            cbtn_unreadedRequests.Size = new Size(40, 40);
            cbtn_unreadedRequests.TabIndex = 0;
            cbtn_unreadedRequests.UseVisualStyleBackColor = false;
            cbtn_unreadedRequests.Visible = false;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(102, 122, 138);
            btn_logout.BorderColor = Color.Black;
            btn_logout.BorderRadius = 0;
            btn_logout.BorderSize = 0;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_logout.ForeColor = Color.White;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.ImageAlign = ContentAlignment.MiddleLeft;
            btn_logout.Location = new Point(20, 775);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(12, 0, 0, 0);
            btn_logout.Size = new Size(260, 44);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "       Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = Color.WhiteSmoke;
            flowLayoutPanel8.Location = new Point(20, 213);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(260, 2);
            flowLayoutPanel8.TabIndex = 3;
            // 
            // btn_employees
            // 
            btn_employees.Cursor = Cursors.Hand;
            btn_employees.FlatAppearance.BorderSize = 0;
            btn_employees.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_employees.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_employees.FlatStyle = FlatStyle.Flat;
            btn_employees.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_employees.ForeColor = Color.FromArgb(93, 114, 133);
            btn_employees.Image = (Image)resources.GetObject("btn_employees.Image");
            btn_employees.ImageAlign = ContentAlignment.MiddleLeft;
            btn_employees.Location = new Point(20, 298);
            btn_employees.Name = "btn_employees";
            btn_employees.Padding = new Padding(12, 0, 0, 0);
            btn_employees.Size = new Size(260, 48);
            btn_employees.TabIndex = 15;
            btn_employees.Text = "   Employees";
            btn_employees.TextAlign = ContentAlignment.MiddleLeft;
            btn_employees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_employees.UseVisualStyleBackColor = true;
            btn_employees.Click += btn_employees_Click;
            // 
            // btn_schedules
            // 
            btn_schedules.Cursor = Cursors.Hand;
            btn_schedules.FlatAppearance.BorderSize = 0;
            btn_schedules.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_schedules.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_schedules.FlatStyle = FlatStyle.Flat;
            btn_schedules.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_schedules.ForeColor = Color.FromArgb(93, 114, 133);
            btn_schedules.Image = Properties.Resources.Planner1;
            btn_schedules.ImageAlign = ContentAlignment.MiddleLeft;
            btn_schedules.Location = new Point(20, 351);
            btn_schedules.Name = "btn_schedules";
            btn_schedules.Padding = new Padding(12, 0, 0, 0);
            btn_schedules.Size = new Size(260, 48);
            btn_schedules.TabIndex = 16;
            btn_schedules.Text = "   Schedules";
            btn_schedules.TextAlign = ContentAlignment.MiddleLeft;
            btn_schedules.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_schedules.UseVisualStyleBackColor = true;
            btn_schedules.Click += btn_schedules_Click;
            // 
            // btn_attendance
            // 
            btn_attendance.Cursor = Cursors.Hand;
            btn_attendance.FlatAppearance.BorderSize = 0;
            btn_attendance.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_attendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_attendance.FlatStyle = FlatStyle.Flat;
            btn_attendance.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_attendance.ForeColor = Color.FromArgb(93, 114, 133);
            btn_attendance.Image = (Image)resources.GetObject("btn_attendance.Image");
            btn_attendance.ImageAlign = ContentAlignment.MiddleLeft;
            btn_attendance.Location = new Point(20, 405);
            btn_attendance.Name = "btn_attendance";
            btn_attendance.Padding = new Padding(12, 0, 0, 0);
            btn_attendance.Size = new Size(260, 48);
            btn_attendance.TabIndex = 18;
            btn_attendance.Text = "   Attendance";
            btn_attendance.TextAlign = ContentAlignment.MiddleLeft;
            btn_attendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_attendance.UseVisualStyleBackColor = true;
            btn_attendance.Click += btn_attendance_Click;
            // 
            // btn_arrivals
            // 
            btn_arrivals.Cursor = Cursors.Hand;
            btn_arrivals.FlatAppearance.BorderSize = 0;
            btn_arrivals.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_arrivals.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_arrivals.FlatStyle = FlatStyle.Flat;
            btn_arrivals.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_arrivals.ForeColor = Color.FromArgb(93, 114, 133);
            btn_arrivals.Image = (Image)resources.GetObject("btn_arrivals.Image");
            btn_arrivals.ImageAlign = ContentAlignment.MiddleLeft;
            btn_arrivals.Location = new Point(20, 459);
            btn_arrivals.Name = "btn_arrivals";
            btn_arrivals.Padding = new Padding(12, 0, 0, 0);
            btn_arrivals.Size = new Size(260, 48);
            btn_arrivals.TabIndex = 19;
            btn_arrivals.Text = "   Arrivals";
            btn_arrivals.TextAlign = ContentAlignment.MiddleLeft;
            btn_arrivals.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_arrivals.UseVisualStyleBackColor = true;
            btn_arrivals.Click += btn_arrivals_Click;
            // 
            // btn_frequentAbsent
            // 
            btn_frequentAbsent.Cursor = Cursors.Hand;
            btn_frequentAbsent.FlatAppearance.BorderSize = 0;
            btn_frequentAbsent.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_frequentAbsent.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_frequentAbsent.FlatStyle = FlatStyle.Flat;
            btn_frequentAbsent.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_frequentAbsent.ForeColor = Color.FromArgb(93, 114, 133);
            btn_frequentAbsent.Image = Properties.Resources.Calendar_Delete;
            btn_frequentAbsent.ImageAlign = ContentAlignment.MiddleLeft;
            btn_frequentAbsent.Location = new Point(20, 513);
            btn_frequentAbsent.Name = "btn_frequentAbsent";
            btn_frequentAbsent.Padding = new Padding(12, 0, 0, 0);
            btn_frequentAbsent.Size = new Size(260, 48);
            btn_frequentAbsent.TabIndex = 20;
            btn_frequentAbsent.Text = "   Frequent Absence";
            btn_frequentAbsent.TextAlign = ContentAlignment.MiddleLeft;
            btn_frequentAbsent.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_frequentAbsent.UseVisualStyleBackColor = true;
            btn_frequentAbsent.Click += btn_frequentAbsent_Click;
            // 
            // btn_leaveRequest
            // 
            btn_leaveRequest.Cursor = Cursors.Hand;
            btn_leaveRequest.FlatAppearance.BorderSize = 0;
            btn_leaveRequest.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_leaveRequest.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_leaveRequest.FlatStyle = FlatStyle.Flat;
            btn_leaveRequest.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_leaveRequest.ForeColor = Color.FromArgb(93, 114, 133);
            btn_leaveRequest.Image = Properties.Resources.Inquiry;
            btn_leaveRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btn_leaveRequest.Location = new Point(20, 569);
            btn_leaveRequest.Name = "btn_leaveRequest";
            btn_leaveRequest.Padding = new Padding(12, 0, 0, 0);
            btn_leaveRequest.Size = new Size(260, 48);
            btn_leaveRequest.TabIndex = 17;
            btn_leaveRequest.Text = "   Leave Requests";
            btn_leaveRequest.TextAlign = ContentAlignment.MiddleLeft;
            btn_leaveRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_leaveRequest.UseVisualStyleBackColor = true;
            btn_leaveRequest.Click += btn_leaveRequest_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Cursor = Cursors.Hand;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_dashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_dashboard.ForeColor = Color.FromArgb(93, 114, 133);
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(20, 244);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(12, 0, 0, 0);
            btn_dashboard.Size = new Size(260, 48);
            btn_dashboard.TabIndex = 14;
            btn_dashboard.Text = "   Dashboard";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // lbl_subTitle
            // 
            lbl_subTitle.AutoSize = true;
            lbl_subTitle.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_subTitle.Location = new Point(81, 174);
            lbl_subTitle.Name = "lbl_subTitle";
            lbl_subTitle.Size = new Size(166, 20);
            lbl_subTitle.TabIndex = 1;
            lbl_subTitle.Text = "Employee Subtitle Here";
            // 
            // lbl_employeeName
            // 
            lbl_employeeName.AutoSize = true;
            lbl_employeeName.Cursor = Cursors.Hand;
            lbl_employeeName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_employeeName.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_employeeName.Location = new Point(94, 133);
            lbl_employeeName.Name = "lbl_employeeName";
            lbl_employeeName.Size = new Size(114, 46);
            lbl_employeeName.TabIndex = 0;
            lbl_employeeName.Text = "Name";
            lbl_employeeName.Click += lbl_employeeName_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(234, 242, 239);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 856);
            panel3.TabIndex = 0;
            // 
            // pnl_formLoader
            // 
            pnl_formLoader.Location = new Point(309, 0);
            pnl_formLoader.Name = "pnl_formLoader";
            pnl_formLoader.Size = new Size(972, 853);
            pnl_formLoader.TabIndex = 13;
            // 
            // HRDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1282, 853);
            Controls.Add(pnl_formLoader);
            Controls.Add(panel3);
            Name = "HRDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HRDashboard";
            Load += HRDashboard_Load;
            panel1.ResumeLayout(false);
            pnl_sideBar.ResumeLayout(false);
            pnl_sideBar.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel pnl_sideBar;
        private Panel panel3;
        private Label lbl_employeeName;
        private Label lbl_subTitle;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel8;
        private Panel pnl_formLoader;
        private Button btn_dashboard;
        private Button btn_schedules;
        private Button btn_employees;
        private Button btn_frequentAbsent;
        private Button btn_arrivals;
        private Button btn_attendance;
        private Button btn_leaveRequest;
        private CustomControls.CustomButton btn_logout;
        private CustomControls.CustomButton cbtn_unreadedRequests;
    }
}