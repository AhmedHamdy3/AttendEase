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
            dateTimePicker1 = new DateTimePicker();
            bottomBorderPanel1 = new CustomControls.BottomBorderPanel();
            btn_cb_summaryType = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(-1, -1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(357, 27);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2025, 3, 7, 0, 0, 0, 0);
            // 
            // bottomBorderPanel1
            // 
            bottomBorderPanel1.BackColor = Color.White;
            bottomBorderPanel1.Controls.Add(dateTimePicker1);
            bottomBorderPanel1.Location = new Point(29, 182);
            bottomBorderPanel1.Name = "bottomBorderPanel1";
            bottomBorderPanel1.Size = new Size(355, 24);
            bottomBorderPanel1.TabIndex = 19;
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
            btn_cb_summaryType.TabIndex = 20;
            btn_cb_summaryType.UseVisualStyleBackColor = false;
            // 
            // Arrivals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(bottomBorderPanel1);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_title);
            Controls.Add(btn_cb_summaryType);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Arrivals";
            Text = "Arrivals";
            Load += Arrivals_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            bottomBorderPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_title;
        private DateTimePicker dateTimePicker1;
        private CustomControls.BottomBorderPanel bottomBorderPanel1;
        private Button btn_cb_summaryType;
    }
}