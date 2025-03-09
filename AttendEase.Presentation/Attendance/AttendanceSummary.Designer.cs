namespace AttendEase.Presentation.Attendance
{
    partial class AttendanceSummary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceSummary));
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            btn_cb_summaryType = new Button();
            cb_summaryType = new ComboBox();
            lbl_details_header = new Label();
            btn_back = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(27, 26);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 15;
            pictureBox9.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(12, 87);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(278, 62);
            lbl_title.TabIndex = 13;
            lbl_title.Text = "Attendance";
            // 
            // btn_cb_summaryType
            // 
            btn_cb_summaryType.BackColor = Color.White;
            btn_cb_summaryType.FlatAppearance.BorderSize = 0;
            btn_cb_summaryType.FlatAppearance.MouseDownBackColor = Color.White;
            btn_cb_summaryType.FlatAppearance.MouseOverBackColor = Color.White;
            btn_cb_summaryType.FlatStyle = FlatStyle.Flat;
            btn_cb_summaryType.ForeColor = SystemColors.ControlText;
            btn_cb_summaryType.Location = new Point(29, 171);
            btn_cb_summaryType.Name = "btn_cb_summaryType";
            btn_cb_summaryType.Size = new Size(355, 46);
            btn_cb_summaryType.TabIndex = 10;
            btn_cb_summaryType.UseVisualStyleBackColor = false;
            // 
            // cb_summaryType
            // 
            cb_summaryType.FlatStyle = FlatStyle.Flat;
            cb_summaryType.FormattingEnabled = true;
            cb_summaryType.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            cb_summaryType.Location = new Point(45, 180);
            cb_summaryType.Name = "cb_summaryType";
            cb_summaryType.Size = new Size(327, 28);
            cb_summaryType.TabIndex = 9;
            cb_summaryType.SelectedIndexChanged += cb_summarType_SelectedIndexChanged;
            // 
            // lbl_details_header
            // 
            lbl_details_header.AutoSize = true;
            lbl_details_header.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_details_header.Location = new Point(22, 107);
            lbl_details_header.Name = "lbl_details_header";
            lbl_details_header.Size = new Size(0, 38);
            lbl_details_header.TabIndex = 17;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.FromArgb(63, 140, 255);
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(29, 180);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(176, 29);
            btn_back.TabIndex = 24;
            btn_back.Text = "      Back to Attendance";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click;
            // 
            // AttendanceSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(btn_back);
            Controls.Add(lbl_details_header);
            Controls.Add(cb_summaryType);
            Controls.Add(btn_cb_summaryType);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceSummary";
            Text = "AttendanceSummary";
            Load += AttendanceSummary_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox9;
        private Label lbl_title;
        private Button btn_cb_summaryType;
        private ComboBox cb_summaryType;
        private Label lbl_details_header;
        private Button btn_back;
    }
}