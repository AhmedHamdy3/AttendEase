namespace AttendEase.Presentation
{
    partial class Arrivals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrivals));
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            btn_back = new Button();
            cdtp_endDate = new CustomControls.CustomDateTimePicker();
            cdtp_startDate = new CustomControls.CustomDateTimePicker();
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
            pictureBox9.TabIndex = 17;
            pictureBox9.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(12, 87);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(194, 62);
            lbl_title.TabIndex = 16;
            lbl_title.Text = "Arrivals";
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
            btn_back.Size = new Size(163, 29);
            btn_back.TabIndex = 23;
            btn_back.Text = "      Back to Arrivals";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click;
            // 
            // cdtp_endDate
            // 
            cdtp_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_endDate.BorderSize = 0;
            cdtp_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_endDate.Location = new Point(439, 171);
            cdtp_endDate.MinimumSize = new Size(0, 46);
            cdtp_endDate.Name = "cdtp_endDate";
            cdtp_endDate.Size = new Size(355, 46);
            cdtp_endDate.SkinColor = Color.White;
            cdtp_endDate.TabIndex = 35;
            cdtp_endDate.TextColor = Color.FromArgb(10, 22, 41);
            cdtp_endDate.ValueChanged += cdtp_endDate_ValueChanged;
            // 
            // cdtp_startDate
            // 
            cdtp_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_startDate.BorderSize = 0;
            cdtp_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_startDate.Location = new Point(30, 171);
            cdtp_startDate.MinimumSize = new Size(0, 46);
            cdtp_startDate.Name = "cdtp_startDate";
            cdtp_startDate.Size = new Size(355, 46);
            cdtp_startDate.SkinColor = Color.White;
            cdtp_startDate.TabIndex = 34;
            cdtp_startDate.TextColor = Color.FromArgb(10, 22, 41);
            cdtp_startDate.ValueChanged += cdtp_startDate_ValueChanged;
            // 
            // Arrivals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(cdtp_endDate);
            Controls.Add(cdtp_startDate);
            Controls.Add(btn_back);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Arrivals";
            Text = "Arrivals";
            Load += Arrivals_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_title;
        private Button btn_back;
        private CustomControls.CustomDateTimePicker cdtp_endDate;
        private CustomControls.CustomDateTimePicker cdtp_startDate;
    }
}