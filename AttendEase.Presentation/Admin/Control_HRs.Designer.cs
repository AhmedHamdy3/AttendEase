namespace AttendEase.Presentation.Admin
{
    partial class Control_HRs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_HRs));
            pictureBox9 = new PictureBox();
            lbl_HR = new Label();
            panel1 = new Panel();
            cb_deptt = new ComboBox();
            cb_empTypee = new ComboBox();
            cb_schedulee = new ComboBox();
            txt_phone = new CustomControls.CustomTextBox();
            txt_email = new CustomControls.CustomTextBox();
            txt_jobTitle = new CustomControls.CustomTextBox();
            txt_name = new CustomControls.CustomTextBox();
            label5 = new Label();
            label8 = new Label();
            label11 = new Label();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            btn_manageHRs = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox9.TabIndex = 20;
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
            lbl_HR.TabIndex = 19;
            lbl_HR.Text = "HR Data";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 229, 235);
            panel1.Controls.Add(cb_deptt);
            panel1.Controls.Add(cb_empTypee);
            panel1.Controls.Add(cb_schedulee);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_jobTitle);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(24, 196);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 290);
            panel1.TabIndex = 54;
            // 
            // cb_deptt
            // 
            cb_deptt.Font = new Font("Segoe UI", 13F);
            cb_deptt.FormattingEnabled = true;
            cb_deptt.Location = new Point(471, 114);
            cb_deptt.Margin = new Padding(3, 2, 3, 2);
            cb_deptt.Name = "cb_deptt";
            cb_deptt.Size = new Size(311, 31);
            cb_deptt.TabIndex = 83;
            // 
            // cb_empTypee
            // 
            cb_empTypee.Font = new Font("Segoe UI", 13F);
            cb_empTypee.FormattingEnabled = true;
            cb_empTypee.Location = new Point(471, 173);
            cb_empTypee.Margin = new Padding(3, 2, 3, 2);
            cb_empTypee.Name = "cb_empTypee";
            cb_empTypee.Size = new Size(311, 31);
            cb_empTypee.TabIndex = 82;
            // 
            // cb_schedulee
            // 
            cb_schedulee.Font = new Font("Segoe UI", 13F);
            cb_schedulee.FormattingEnabled = true;
            cb_schedulee.Location = new Point(471, 233);
            cb_schedulee.Margin = new Padding(3, 2, 3, 2);
            cb_schedulee.Name = "cb_schedulee";
            cb_schedulee.Size = new Size(311, 31);
            cb_schedulee.TabIndex = 81;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.White;
            txt_phone.BorderColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderSize = 1;
            txt_phone.Font = new Font("Segoe UI", 11F);
            txt_phone.ForeColor = Color.FromArgb(38, 32, 59);
            txt_phone.Location = new Point(471, 47);
            txt_phone.Margin = new Padding(3, 2, 3, 2);
            txt_phone.Multiline = false;
            txt_phone.Name = "txt_phone";
            txt_phone.Padding = new Padding(11, 10, 11, 10);
            txt_phone.PasswordChar = false;
            txt_phone.Size = new Size(311, 41);
            txt_phone.TabIndex = 78;
            txt_phone.UnderlinedStyle = false;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.BorderColor = Color.FromArgb(181, 191, 249);
            txt_email.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_email.BorderSize = 1;
            txt_email.Font = new Font("Segoe UI", 11F);
            txt_email.ForeColor = Color.FromArgb(38, 32, 59);
            txt_email.Location = new Point(31, 179);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Multiline = false;
            txt_email.Name = "txt_email";
            txt_email.Padding = new Padding(11, 10, 11, 10);
            txt_email.PasswordChar = false;
            txt_email.Size = new Size(311, 41);
            txt_email.TabIndex = 76;
            txt_email.UnderlinedStyle = false;
            // 
            // txt_jobTitle
            // 
            txt_jobTitle.BackColor = Color.White;
            txt_jobTitle.BorderColor = Color.FromArgb(181, 191, 249);
            txt_jobTitle.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_jobTitle.BorderSize = 1;
            txt_jobTitle.Font = new Font("Segoe UI", 11F);
            txt_jobTitle.ForeColor = Color.FromArgb(38, 32, 59);
            txt_jobTitle.Location = new Point(31, 113);
            txt_jobTitle.Margin = new Padding(3, 2, 3, 2);
            txt_jobTitle.Multiline = false;
            txt_jobTitle.Name = "txt_jobTitle";
            txt_jobTitle.Padding = new Padding(11, 10, 11, 10);
            txt_jobTitle.PasswordChar = false;
            txt_jobTitle.Size = new Size(311, 41);
            txt_jobTitle.TabIndex = 75;
            txt_jobTitle.UnderlinedStyle = false;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.White;
            txt_name.BorderColor = Color.FromArgb(181, 191, 249);
            txt_name.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_name.BorderSize = 1;
            txt_name.Font = new Font("Segoe UI", 11F);
            txt_name.ForeColor = Color.FromArgb(38, 32, 59);
            txt_name.Location = new Point(31, 47);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Multiline = false;
            txt_name.Name = "txt_name";
            txt_name.Padding = new Padding(11, 10, 11, 10);
            txt_name.PasswordChar = false;
            txt_name.Size = new Size(310, 41);
            txt_name.TabIndex = 21;
            txt_name.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.FromArgb(38, 32, 59);
            label5.Location = new Point(471, 88);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 25);
            label5.TabIndex = 74;
            label5.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.FromArgb(38, 32, 59);
            label8.Location = new Point(471, 207);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 65;
            label8.Text = "Schedule";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.ForeColor = Color.FromArgb(38, 32, 59);
            label11.Location = new Point(471, 147);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(161, 25);
            label11.TabIndex = 64;
            label11.Text = "Employment Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.FromArgb(38, 32, 59);
            label9.Location = new Point(471, 22);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 57;
            label9.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(38, 32, 59);
            label1.Location = new Point(31, 88);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 62;
            label1.Text = "Job Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(38, 32, 59);
            label2.Location = new Point(31, 22);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 48;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(38, 32, 59);
            label3.Location = new Point(31, 154);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 49;
            label3.Text = "Email";
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.HotTrack;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(101, 515);
            btn_update.Margin = new Padding(3, 2, 3, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(186, 32);
            btn_update.TabIndex = 53;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = SystemColors.HotTrack;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(549, 515);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(186, 32);
            btn_delete.TabIndex = 52;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = SystemColors.HotTrack;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(325, 515);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(186, 32);
            btn_add.TabIndex = 51;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_manageHRs
            // 
            btn_manageHRs.Cursor = Cursors.Hand;
            btn_manageHRs.FlatAppearance.BorderSize = 0;
            btn_manageHRs.FlatStyle = FlatStyle.Flat;
            btn_manageHRs.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btn_manageHRs.ForeColor = SystemColors.MenuHighlight;
            btn_manageHRs.Location = new Point(28, 123);
            btn_manageHRs.Margin = new Padding(3, 2, 3, 2);
            btn_manageHRs.Name = "btn_manageHRs";
            btn_manageHRs.Size = new Size(153, 47);
            btn_manageHRs.TabIndex = 84;
            btn_manageHRs.Text = "Back";
            btn_manageHRs.UseVisualStyleBackColor = true;
            btn_manageHRs.Click += btn_manageHRs_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 136);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 85;
            pictureBox1.TabStop = false;
            // 
            // Control_HRs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1138, 591);
            Controls.Add(pictureBox1);
            Controls.Add(btn_manageHRs);
            Controls.Add(panel1);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_HR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Control_HRs";
            Text = "Control_HRs";
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_HR;
        private Panel panel1;
        private ComboBox cb_deptt;
        private ComboBox cb_empTypee;
        private ComboBox cb_schedulee;
        private CustomControls.CustomTextBox txt_phone;
        private CustomControls.CustomTextBox txt_email;
        private CustomControls.CustomTextBox txt_jobTitle;
        private CustomControls.CustomTextBox txt_name;
        private Label label5;
        private Label label8;
        private Label label11;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_update;
        private Button btn_delete;
        private Button btn_add;
        private Button btn_manageHRs;
        private PictureBox pictureBox1;
    }
}