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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox9 = new PictureBox();
            lbl_HR = new Label();
            dgv_HRData = new DataGridView();
            btn_ControlHRs = new CustomControls.CustomButton();
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
            dataGridViewCellStyle1.BackColor = Color.Salmon;
            dgv_HRData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_HRData.BackgroundColor = Color.FromArgb(243, 248, 252);
            dgv_HRData.BorderStyle = BorderStyle.None;
            dgv_HRData.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_HRData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_HRData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Green;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_HRData.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_HRData.Location = new Point(12, 142);
            dgv_HRData.Name = "dgv_HRData";
            dgv_HRData.ReadOnly = true;
            dgv_HRData.Size = new Size(816, 418);
            dgv_HRData.TabIndex = 20;
            dgv_HRData.RowHeaderMouseDoubleClick += dgv_HRData_RowHeaderMouseDoubleClick_1;
            // 
            // btn_ControlHRs
            // 
            btn_ControlHRs.BackColor = Color.FromArgb(70, 95, 241);
            btn_ControlHRs.BorderRadius = 7;
            btn_ControlHRs.FlatAppearance.BorderSize = 0;
            btn_ControlHRs.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 95, 241);
            btn_ControlHRs.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 95, 241);
            btn_ControlHRs.FlatStyle = FlatStyle.Flat;
            btn_ControlHRs.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ControlHRs.ForeColor = Color.White;
            btn_ControlHRs.Location = new Point(654, 25);
            btn_ControlHRs.Name = "btn_ControlHRs";
            btn_ControlHRs.Size = new Size(174, 43);
            btn_ControlHRs.TabIndex = 21;
            btn_ControlHRs.Text = "Take Control";
            btn_ControlHRs.UseVisualStyleBackColor = false;
            btn_ControlHRs.Click += btn_ControlHRs_Click;
            // 
            // HR_Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(850, 591);
            Controls.Add(btn_ControlHRs);
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
        private CustomControls.CustomButton btn_ControlHRs;
    }
}