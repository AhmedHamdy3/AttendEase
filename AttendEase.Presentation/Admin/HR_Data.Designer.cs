namespace AttendEase.Presentation.Admin
{
    partial class HR_Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HR_Data));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            pictureBox9 = new PictureBox();
            lbl_HR = new Label();
            dgv_HRData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HRData).BeginInit();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(24, 20);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // lbl_HR
            // 
            lbl_HR.AutoSize = true;
            lbl_HR.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_HR.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_HR.Location = new Point(12, 70);
            lbl_HR.Name = "lbl_HR";
            lbl_HR.Size = new Size(169, 51);
            lbl_HR.TabIndex = 17;
            lbl_HR.Text = "HR Data";
            // 
            // dgv_HRData
            // 
            dataGridViewCellStyle7.BackColor = Color.Salmon;
            dgv_HRData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgv_HRData.BackgroundColor = Color.FromArgb(243, 248, 252);
            dgv_HRData.BorderStyle = BorderStyle.None;
            dgv_HRData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_HRData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgv_HRData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.Green;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgv_HRData.DefaultCellStyle = dataGridViewCellStyle9;
            dgv_HRData.Location = new Point(12, 142);
            dgv_HRData.Name = "dgv_HRData";
            dgv_HRData.ReadOnly = true;
            dgv_HRData.Size = new Size(814, 398);
            dgv_HRData.TabIndex = 20;
            // 
            // HR_Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(834, 552);
            Controls.Add(dgv_HRData);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_HR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HR_Data";
            Text = "HR_Data";
            Load += HR_Data_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_HRData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_HR;
        private DataGridView dgv_HRData;
    }
}