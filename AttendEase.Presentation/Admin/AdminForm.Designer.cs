namespace AttendEase.Presentation.Admin
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            pnl_formLoader = new Panel();
            panel1 = new Panel();
            pnl_sideBar = new Panel();
            btn_HRs = new Button();
            btn_logout = new CustomControls.CustomButton();
            flowLayoutPanel8 = new FlowLayoutPanel();
            btn_dashboard = new Button();
            lbl_subtitle = new Label();
            lbl_employeeName = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            pnl_sideBar.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_formLoader
            // 
            pnl_formLoader.BackColor = Color.FromArgb(243, 248, 252);
            pnl_formLoader.Location = new Point(271, -2);
            pnl_formLoader.Margin = new Padding(3, 2, 3, 2);
            pnl_formLoader.Name = "pnl_formLoader";
            pnl_formLoader.Size = new Size(850, 640);
            pnl_formLoader.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 233, 234);
            panel1.Controls.Add(pnl_sideBar);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 642);
            panel1.TabIndex = 0;
            // 
            // pnl_sideBar
            // 
            pnl_sideBar.BackColor = Color.White;
            pnl_sideBar.Controls.Add(btn_HRs);
            pnl_sideBar.Controls.Add(btn_logout);
            pnl_sideBar.Controls.Add(flowLayoutPanel8);
            pnl_sideBar.Controls.Add(btn_dashboard);
            pnl_sideBar.Controls.Add(lbl_subtitle);
            pnl_sideBar.Controls.Add(lbl_employeeName);
            pnl_sideBar.Location = new Point(0, 38);
            pnl_sideBar.Margin = new Padding(3, 2, 3, 2);
            pnl_sideBar.Name = "pnl_sideBar";
            pnl_sideBar.Size = new Size(262, 640);
            pnl_sideBar.TabIndex = 1;
            // 
            // btn_HRs
            // 
            btn_HRs.Cursor = Cursors.Hand;
            btn_HRs.FlatAppearance.BorderSize = 0;
            btn_HRs.FlatAppearance.MouseDownBackColor = Color.FromArgb(236, 240, 255);
            btn_HRs.FlatAppearance.MouseOverBackColor = Color.FromArgb(236, 240, 255);
            btn_HRs.FlatStyle = FlatStyle.Flat;
            btn_HRs.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btn_HRs.ForeColor = Color.FromArgb(93, 114, 133);
            btn_HRs.Image = (Image)resources.GetObject("btn_HRs.Image");
            btn_HRs.ImageAlign = ContentAlignment.MiddleLeft;
            btn_HRs.Location = new Point(18, 224);
            btn_HRs.Margin = new Padding(3, 2, 3, 2);
            btn_HRs.Name = "btn_HRs";
            btn_HRs.Padding = new Padding(10, 0, 0, 0);
            btn_HRs.Size = new Size(228, 36);
            btn_HRs.TabIndex = 16;
            btn_HRs.Text = "    Employees Data";
            btn_HRs.TextAlign = ContentAlignment.MiddleLeft;
            btn_HRs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_HRs.UseVisualStyleBackColor = true;
            btn_HRs.Click += btn_HRs_Click;
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
            btn_logout.Location = new Point(18, 569);
            btn_logout.Margin = new Padding(3, 2, 3, 2);
            btn_logout.Name = "btn_logout";
            btn_logout.Padding = new Padding(10, 0, 0, 0);
            btn_logout.Size = new Size(228, 33);
            btn_logout.TabIndex = 0;
            btn_logout.Text = "       Logout";
            btn_logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.BackColor = Color.WhiteSmoke;
            flowLayoutPanel8.Location = new Point(18, 160);
            flowLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(228, 2);
            flowLayoutPanel8.TabIndex = 3;
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
            btn_dashboard.Location = new Point(18, 183);
            btn_dashboard.Margin = new Padding(3, 2, 3, 2);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(10, 0, 0, 0);
            btn_dashboard.Size = new Size(228, 36);
            btn_dashboard.TabIndex = 14;
            btn_dashboard.Text = "   Edit Profile";
            btn_dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // lbl_subtitle
            // 
            lbl_subtitle.AutoSize = true;
            lbl_subtitle.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_subtitle.Location = new Point(71, 130);
            lbl_subtitle.Name = "lbl_subtitle";
            lbl_subtitle.Size = new Size(111, 15);
            lbl_subtitle.TabIndex = 1;
            lbl_subtitle.Text = "Some user text here";
            // 
            // lbl_employeeName
            // 
            lbl_employeeName.AutoSize = true;
            lbl_employeeName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_employeeName.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_employeeName.Location = new Point(82, 100);
            lbl_employeeName.Name = "lbl_employeeName";
            lbl_employeeName.Size = new Size(93, 37);
            lbl_employeeName.TabIndex = 0;
            lbl_employeeName.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(234, 242, 239);
            panel3.Controls.Add(panel1);
            panel3.Location = new Point(1, -40);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 642);
            panel3.TabIndex = 16;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 610);
            Controls.Add(pnl_formLoader);
            Controls.Add(panel3);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
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
        private Button btn_dashboard;
        private Label lbl_subtitle;
        private Label lbl_employeeName;
        private Panel panel3;
        private Button btn_HRs;
    }
}