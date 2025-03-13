namespace AttendEase.Presentation
{
    partial class EmployeeMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMainForm));
            pnl_formLoader = new Panel();
            panel1 = new Panel();
            pnl_sideBar = new Panel();
            btn_logout = new CustomControls.CustomButton();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btn_leaveRequest = new Button();
            btn_dashboard = new Button();
            label2 = new Label();
            lbl_employeeName = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            pnl_sideBar.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_formLoader
            // 
            pnl_formLoader.Location = new Point(310, -2);
            pnl_formLoader.Name = "pnl_formLoader";
            pnl_formLoader.Size = new Size(972, 853);
            pnl_formLoader.TabIndex = 15;
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
            pnl_sideBar.Controls.Add(btn_logout);
            pnl_sideBar.Controls.Add(flowLayoutPanel8);
            pnl_sideBar.Controls.Add(btn_leaveRequest);
            pnl_sideBar.Controls.Add(btn_dashboard);
            pnl_sideBar.Controls.Add(label2);
            pnl_sideBar.Controls.Add(lbl_employeeName);
            pnl_sideBar.Location = new Point(0, 0);
            pnl_sideBar.Name = "pnl_sideBar";
            pnl_sideBar.Size = new Size(300, 853);
            pnl_sideBar.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(102, 122, 138);
            btn_logout.BorderRadius = 0;
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
            btn_leaveRequest.Location = new Point(20, 298);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(93, 114, 133);
            label2.Location = new Point(81, 174);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 1;
            label2.Text = "Some user text here";
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
            panel3.Location = new Point(1, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(306, 856);
            panel3.TabIndex = 14;
            // 
            // EmployeeMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1282, 853);
            Controls.Add(pnl_formLoader);
            Controls.Add(panel3);
            Name = "EmployeeMainForm";
            Text = "EmployeeMainForm";
            Load += EmployeeMainForm_Load;
            panel1.ResumeLayout(false);
            pnl_sideBar.ResumeLayout(false);
            pnl_sideBar.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_formLoader;
        private Panel panel1;
        private Panel pnl_sideBar;
        private CustomControls.CustomButton btn_logout;
        private FlowLayoutPanel flowLayoutPanel8;
        private Button btn_leaveRequest;
        private Button btn_dashboard;
        private Label label2;
        private Label lbl_employeeName;
        private Panel panel3;
    }
}