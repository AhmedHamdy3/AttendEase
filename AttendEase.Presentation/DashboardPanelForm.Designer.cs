namespace AttendEase.Presentation
{
    partial class DashboardPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardPanelForm));
            pnl_dashboard = new Panel();
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            panel6 = new Panel();
            btn_checkin = new Button();
            btn_checkout = new Button();
            panel7 = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            monthCalendar1 = new MonthCalendar();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            btn_qr = new Button();
            panel8 = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pnl_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pnl_dashboard
            // 
            pnl_dashboard.Controls.Add(pictureBox9);
            pnl_dashboard.Controls.Add(lbl_title);
            pnl_dashboard.Controls.Add(panel6);
            pnl_dashboard.Controls.Add(panel7);
            pnl_dashboard.Controls.Add(panel5);
            pnl_dashboard.Controls.Add(panel4);
            pnl_dashboard.Controls.Add(panel8);
            pnl_dashboard.Location = new Point(0, 12);
            pnl_dashboard.Name = "pnl_dashboard";
            pnl_dashboard.Size = new Size(970, 829);
            pnl_dashboard.TabIndex = 1;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(19, 20);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 27;
            pictureBox9.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(4, 81);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(267, 62);
            lbl_title.TabIndex = 26;
            lbl_title.Text = "Dashboard";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(243, 248, 252);
            panel6.Controls.Add(btn_checkin);
            panel6.Controls.Add(btn_checkout);
            panel6.Location = new Point(451, 239);
            panel6.Name = "panel6";
            panel6.Size = new Size(459, 209);
            panel6.TabIndex = 24;
            // 
            // btn_checkin
            // 
            btn_checkin.FlatAppearance.BorderSize = 2;
            btn_checkin.FlatStyle = FlatStyle.Flat;
            btn_checkin.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_checkin.ForeColor = Color.FromArgb(0, 126, 249);
            btn_checkin.Location = new Point(31, 25);
            btn_checkin.Name = "btn_checkin";
            btn_checkin.Size = new Size(358, 58);
            btn_checkin.TabIndex = 1;
            btn_checkin.Text = "Check In";
            btn_checkin.UseVisualStyleBackColor = true;
            btn_checkin.Click += btn_checkin_Click;
            // 
            // btn_checkout
            // 
            btn_checkout.FlatAppearance.BorderSize = 2;
            btn_checkout.FlatStyle = FlatStyle.Flat;
            btn_checkout.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_checkout.ForeColor = Color.FromArgb(0, 126, 249);
            btn_checkout.Location = new Point(31, 120);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(358, 58);
            btn_checkout.TabIndex = 0;
            btn_checkout.Text = "Check Out";
            btn_checkout.UseVisualStyleBackColor = true;
            btn_checkout.Click += button2_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(243, 248, 252);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(505, 468);
            panel7.Name = "panel7";
            panel7.Size = new Size(425, 75);
            panel7.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(6, 20);
            label2.Name = "label2";
            label2.Size = new Size(416, 29);
            label2.TabIndex = 1;
            label2.Text = "Quick Check-In, Smooth Check-out.\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(60, 10);
            label1.Name = "label1";
            label1.Size = new Size(0, 26);
            label1.TabIndex = 1;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(243, 248, 252);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(monthCalendar1);
            panel5.Location = new Point(19, 469);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 340);
            panel5.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(46, 272);
            label4.Name = "label4";
            label4.Size = new Size(390, 39);
            label4.TabIndex = 1;
            label4.Text = "Track, Improve, Success";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthCalendar1.Location = new Point(105, 37);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(243, 248, 252);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(btn_qr);
            panel4.Location = new Point(504, 549);
            panel4.Name = "panel4";
            panel4.Size = new Size(426, 260);
            panel4.TabIndex = 22;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(126, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(172, 147);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_qr
            // 
            btn_qr.FlatAppearance.BorderSize = 2;
            btn_qr.FlatStyle = FlatStyle.Flat;
            btn_qr.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_qr.ForeColor = Color.FromArgb(0, 126, 249);
            btn_qr.Location = new Point(39, 185);
            btn_qr.Name = "btn_qr";
            btn_qr.Size = new Size(358, 58);
            btn_qr.TabIndex = 2;
            btn_qr.Text = "Qr Reader";
            btn_qr.UseVisualStyleBackColor = true;
            btn_qr.Click += btn_qr_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(243, 248, 252);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(pictureBox3);
            panel8.Location = new Point(37, 196);
            panel8.Name = "panel8";
            panel8.Size = new Size(380, 247);
            panel8.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(42, 183);
            label5.Name = "label5";
            label5.Size = new Size(298, 52);
            label5.TabIndex = 0;
            label5.Text = "Empowering Your Workforce,\r\n One Click at a time.\r\n";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dashboard;
            pictureBox3.Location = new Point(28, 43);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(321, 123);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // DashboardPanelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(pnl_dashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardPanelForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardPanelForm";
            pnl_dashboard.ResumeLayout(false);
            pnl_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_dashboard;
        private PictureBox pictureBox9;
        private Label lbl_title;
        private Panel panel7;
        private Panel panel6;
        private Button btn_checkin;
        private Button btn_checkout;
        private Panel panel5;
        private Label label4;
        private MonthCalendar monthCalendar1;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Button btn_qr;
        private Panel panel8;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}