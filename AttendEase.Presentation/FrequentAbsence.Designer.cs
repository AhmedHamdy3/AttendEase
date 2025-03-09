namespace AttendEase.Presentation
{
    partial class FrequentAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrequentAbsence));
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            dtp_startDate = new DateTimePicker();
            bottomBorderPanel2 = new CustomControls.BottomBorderPanel();
            dtp_endDate = new DateTimePicker();
            bottomBorderPanel1 = new CustomControls.BottomBorderPanel();
            btn_cb_summaryType = new Button();
            btn_back = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            bottomBorderPanel2.SuspendLayout();
            bottomBorderPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(27, 26);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(12, 87);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(420, 62);
            lbl_title.TabIndex = 24;
            lbl_title.Text = "Frequent Absence";
            // 
            // dtp_startDate
            // 
            dtp_startDate.Location = new Point(-1, -1);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(357, 27);
            dtp_startDate.TabIndex = 18;
            dtp_startDate.Value = new DateTime(2025, 3, 7, 0, 0, 0, 0);
            dtp_startDate.ValueChanged += dtp_startDate_ValueChanged;
            // 
            // bottomBorderPanel2
            // 
            bottomBorderPanel2.BackColor = Color.White;
            bottomBorderPanel2.Controls.Add(dtp_endDate);
            bottomBorderPanel2.Location = new Point(438, 181);
            bottomBorderPanel2.Name = "bottomBorderPanel2";
            bottomBorderPanel2.Size = new Size(355, 24);
            bottomBorderPanel2.TabIndex = 28;
            // 
            // dtp_endDate
            // 
            dtp_endDate.Location = new Point(-1, -1);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(357, 27);
            dtp_endDate.TabIndex = 18;
            dtp_endDate.Value = new DateTime(2025, 3, 7, 0, 0, 0, 0);
            dtp_endDate.ValueChanged += dtp_endDate_ValueChanged;
            // 
            // bottomBorderPanel1
            // 
            bottomBorderPanel1.BackColor = Color.White;
            bottomBorderPanel1.Controls.Add(dtp_startDate);
            bottomBorderPanel1.Location = new Point(29, 182);
            bottomBorderPanel1.Name = "bottomBorderPanel1";
            bottomBorderPanel1.Size = new Size(355, 24);
            bottomBorderPanel1.TabIndex = 26;
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
            btn_cb_summaryType.TabIndex = 27;
            btn_cb_summaryType.UseVisualStyleBackColor = false;
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
            btn_back.Location = new Point(29, 240);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(234, 29);
            btn_back.TabIndex = 30;
            btn_back.Text = "      Back to Frequent Absence";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(438, 170);
            button1.Name = "button1";
            button1.Size = new Size(355, 46);
            button1.TabIndex = 29;
            button1.UseVisualStyleBackColor = false;
            // 
            // FrequentAbsence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_title);
            Controls.Add(bottomBorderPanel2);
            Controls.Add(bottomBorderPanel1);
            Controls.Add(btn_cb_summaryType);
            Controls.Add(btn_back);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrequentAbsence";
            Text = "FrequentAbsence";
            Load += FrequentAbsence_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            bottomBorderPanel2.ResumeLayout(false);
            bottomBorderPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_title;
        private DateTimePicker dtp_startDate;
        private CustomControls.BottomBorderPanel bottomBorderPanel2;
        private DateTimePicker dtp_endDate;
        private CustomControls.BottomBorderPanel bottomBorderPanel1;
        private Button btn_cb_summaryType;
        private Button btn_back;
        private Button button1;
    }
}