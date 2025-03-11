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
            lbl_details_header = new Label();
            btn_back = new Button();
            ccb_summaryType = new CustomControls.CustomComboBox();
            cbtn_exportPdf = new CustomControls.CustomButton();
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
            // ccb_summaryType
            // 
            ccb_summaryType.BackColor = Color.White;
            ccb_summaryType.BorderColor = Color.White;
            ccb_summaryType.BorderSize = 0;
            ccb_summaryType.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_summaryType.Font = new Font("Segoe UI", 9F);
            ccb_summaryType.ForeColor = Color.DimGray;
            ccb_summaryType.IconColor = Color.FromArgb(10, 22, 41);
            ccb_summaryType.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            ccb_summaryType.ListBackColor = Color.White;
            ccb_summaryType.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_summaryType.Location = new Point(29, 171);
            ccb_summaryType.MinimumSize = new Size(200, 30);
            ccb_summaryType.Name = "ccb_summaryType";
            ccb_summaryType.Size = new Size(355, 46);
            ccb_summaryType.TabIndex = 25;
            ccb_summaryType.OnSelectedIndexChanged += ccb_summaryType_OnSelectedIndexChanged;
            // 
            // cbtn_exportPdf
            // 
            cbtn_exportPdf.BackColor = Color.Pink;
            cbtn_exportPdf.BorderRadius = 10;
            cbtn_exportPdf.Cursor = Cursors.Hand;
            cbtn_exportPdf.FlatAppearance.BorderSize = 0;
            cbtn_exportPdf.FlatStyle = FlatStyle.Flat;
            cbtn_exportPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_exportPdf.ForeColor = Color.White;
            cbtn_exportPdf.Location = new Point(624, 26);
            cbtn_exportPdf.Name = "cbtn_exportPdf";
            cbtn_exportPdf.Size = new Size(313, 50);
            cbtn_exportPdf.TabIndex = 26;
            cbtn_exportPdf.Text = "customButton1";
            cbtn_exportPdf.UseVisualStyleBackColor = false;
            cbtn_exportPdf.Click += cbtn_exportPdf_Click;
            // 
            // AttendanceSummary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(cbtn_exportPdf);
            Controls.Add(ccb_summaryType);
            Controls.Add(btn_back);
            Controls.Add(lbl_details_header);
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
        private Label lbl_details_header;
        private Button btn_back;
        private CustomControls.CustomComboBox ccb_summaryType;
        private CustomControls.CustomButton cbtn_exportPdf;
    }
}