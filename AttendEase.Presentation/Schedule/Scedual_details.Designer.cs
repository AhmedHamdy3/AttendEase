namespace AttendEase.Presentation.Scedual
{
    partial class Scedual_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scedual_details));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbl_schedule = new Label();
            pictureBox9 = new PictureBox();
            dgv_Schedule = new DataGridView();
            btn_AddSchedule = new CustomControls.CustomButton();
            ccb_DayOfWeek = new CustomControls.CustomComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Schedule).BeginInit();
            SuspendLayout();
            // 
            // lbl_schedule
            // 
            lbl_schedule.AutoSize = true;
            lbl_schedule.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_schedule.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_schedule.Location = new Point(12, 70);
            lbl_schedule.Name = "lbl_schedule";
            lbl_schedule.Size = new Size(184, 51);
            lbl_schedule.TabIndex = 13;
            lbl_schedule.Text = "Schedule";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(24, 20);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // dgv_Schedule
            // 
            dataGridViewCellStyle1.BackColor = Color.Salmon;
            dgv_Schedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Schedule.BackgroundColor = Color.FromArgb(243, 248, 252);
            dgv_Schedule.BorderStyle = BorderStyle.None;
            dgv_Schedule.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Schedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Schedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Schedule.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Schedule.Location = new Point(24, 181);
            dgv_Schedule.Name = "dgv_Schedule";
            dgv_Schedule.ReadOnly = true;
            dgv_Schedule.Size = new Size(814, 398);
            dgv_Schedule.TabIndex = 19;
            // 
            // btn_AddSchedule
            // 
            btn_AddSchedule.BackColor = Color.FromArgb(70, 95, 241);
            btn_AddSchedule.BorderRadius = 7;
            btn_AddSchedule.FlatAppearance.BorderSize = 0;
            btn_AddSchedule.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 95, 241);
            btn_AddSchedule.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 95, 241);
            btn_AddSchedule.FlatStyle = FlatStyle.Flat;
            btn_AddSchedule.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddSchedule.ForeColor = Color.White;
            btn_AddSchedule.Location = new Point(635, 70);
            btn_AddSchedule.Name = "btn_AddSchedule";
            btn_AddSchedule.Size = new Size(174, 43);
            btn_AddSchedule.TabIndex = 20;
            btn_AddSchedule.Text = "Add Schedule";
            btn_AddSchedule.UseVisualStyleBackColor = false;
            btn_AddSchedule.Click += btn_AddSchedule_Click;
            // 
            // ccb_DayOfWeek
            // 
            ccb_DayOfWeek.BackColor = Color.White;
            ccb_DayOfWeek.BorderColor = Color.White;
            ccb_DayOfWeek.BorderSize = 0;
            ccb_DayOfWeek.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_DayOfWeek.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ccb_DayOfWeek.ForeColor = Color.Black;
            ccb_DayOfWeek.IconColor = Color.FromArgb(10, 22, 41);
            ccb_DayOfWeek.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            ccb_DayOfWeek.ListBackColor = Color.White;
            ccb_DayOfWeek.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_DayOfWeek.Location = new Point(24, 123);
            ccb_DayOfWeek.Margin = new Padding(3, 2, 3, 2);
            ccb_DayOfWeek.MinimumSize = new Size(175, 22);
            ccb_DayOfWeek.Name = "ccb_DayOfWeek";
            ccb_DayOfWeek.Size = new Size(175, 34);
            ccb_DayOfWeek.TabIndex = 26;
            ccb_DayOfWeek.OnSelectedIndexChanged += ccb_DayOfWeek_OnSelectedIndexChanged;
            // 
            // Scedual_details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(850, 591);
            Controls.Add(ccb_DayOfWeek);
            Controls.Add(btn_AddSchedule);
            Controls.Add(dgv_Schedule);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_schedule);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Scedual_details";
            Text = "Scedual_details";
            Load += Scedual_details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Schedule).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_schedule;
        private PictureBox pictureBox9;
        private ComboBox cb_summaryType;
        private DataGridView dgv_Schedule;
        private CustomControls.CustomButton btn_AddSchedule;
        private CustomControls.CustomComboBox ccb_DayOfWeek;
    }
}