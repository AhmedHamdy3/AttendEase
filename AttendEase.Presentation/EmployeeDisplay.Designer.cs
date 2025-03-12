namespace AttendEase.Presentation
{
    partial class EmployeeDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDisplay));
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            btn_manageEmp = new Button();
            pnlCrudEmp = new Panel();
            panel1 = new Panel();
            cb_deptt = new ComboBox();
            cb_empTypee = new ComboBox();
            cb_schedulee = new ComboBox();
            txt_pass = new CustomControls.CustomTextBox();
            txt_phone = new CustomControls.CustomTextBox();
            txt_confirm = new CustomControls.CustomTextBox();
            txt_email = new CustomControls.CustomTextBox();
            txt_jobTitle = new CustomControls.CustomTextBox();
            txt_name = new CustomControls.CustomTextBox();
            label5 = new Label();
            label8 = new Label();
            label11 = new Label();
            label9 = new Label();
            label7 = new Label();
            label1 = new Label();
            picEye2 = new PictureBox();
            btn_show2 = new Label();
            picEye1 = new PictureBox();
            btn_show1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_update = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnlCrudEmp.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEye2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEye1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            lbl_title.Size = new Size(262, 62);
            lbl_title.TabIndex = 16;
            lbl_title.Text = "Employees";
            // 
            // btn_manageEmp
            // 
            btn_manageEmp.Cursor = Cursors.Hand;
            btn_manageEmp.FlatAppearance.BorderSize = 0;
            btn_manageEmp.FlatStyle = FlatStyle.Flat;
            btn_manageEmp.Font = new Font("Segoe UI", 11F);
            btn_manageEmp.ForeColor = SystemColors.MenuHighlight;
            btn_manageEmp.Location = new Point(27, 167);
            btn_manageEmp.Name = "btn_manageEmp";
            btn_manageEmp.Size = new Size(296, 50);
            btn_manageEmp.TabIndex = 18;
            btn_manageEmp.Text = "          Manage Employees";
            btn_manageEmp.UseVisualStyleBackColor = true;
            btn_manageEmp.Click += btn_manageEmps_Click;
            // 
            // pnlCrudEmp
            // 
            pnlCrudEmp.Controls.Add(panel1);
            pnlCrudEmp.Controls.Add(btn_update);
            pnlCrudEmp.Controls.Add(btn_delete);
            pnlCrudEmp.Controls.Add(btn_add);
            pnlCrudEmp.Font = new Font("Segoe UI", 11F);
            pnlCrudEmp.Location = new Point(27, 222);
            pnlCrudEmp.Margin = new Padding(2);
            pnlCrudEmp.Name = "pnlCrudEmp";
            pnlCrudEmp.Size = new Size(914, 653);
            pnlCrudEmp.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 229, 235);
            panel1.Controls.Add(cb_deptt);
            panel1.Controls.Add(cb_empTypee);
            panel1.Controls.Add(cb_schedulee);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_confirm);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_jobTitle);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(picEye2);
            panel1.Controls.Add(btn_show2);
            panel1.Controls.Add(picEye1);
            panel1.Controls.Add(btn_show1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(908, 512);
            panel1.TabIndex = 50;
            // 
            // cb_deptt
            // 
            cb_deptt.Font = new Font("Segoe UI", 13F);
            cb_deptt.FormattingEnabled = true;
            cb_deptt.Location = new Point(538, 152);
            cb_deptt.Name = "cb_deptt";
            cb_deptt.Size = new Size(355, 38);
            cb_deptt.TabIndex = 83;
            // 
            // cb_empTypee
            // 
            cb_empTypee.Font = new Font("Segoe UI", 13F);
            cb_empTypee.FormattingEnabled = true;
            cb_empTypee.Location = new Point(538, 231);
            cb_empTypee.Name = "cb_empTypee";
            cb_empTypee.Size = new Size(355, 38);
            cb_empTypee.TabIndex = 82;
            // 
            // cb_schedulee
            // 
            cb_schedulee.Font = new Font("Segoe UI", 13F);
            cb_schedulee.FormattingEnabled = true;
            cb_schedulee.Location = new Point(538, 311);
            cb_schedulee.Name = "cb_schedulee";
            cb_schedulee.Size = new Size(355, 38);
            cb_schedulee.TabIndex = 81;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.White;
            txt_pass.BorderColor = Color.FromArgb(181, 191, 249);
            txt_pass.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_pass.BorderSize = 1;
            txt_pass.Font = new Font("Segoe UI", 11F);
            txt_pass.ForeColor = Color.FromArgb(38, 32, 59);
            txt_pass.Location = new Point(54, 327);
            txt_pass.Multiline = false;
            txt_pass.Name = "txt_pass";
            txt_pass.Padding = new Padding(13);
            txt_pass.PasswordChar = false;
            txt_pass.Size = new Size(355, 52);
            txt_pass.TabIndex = 79;
            txt_pass.UnderlinedStyle = false;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.White;
            txt_phone.BorderColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderSize = 1;
            txt_phone.Font = new Font("Segoe UI", 11F);
            txt_phone.ForeColor = Color.FromArgb(38, 32, 59);
            txt_phone.Location = new Point(538, 63);
            txt_phone.Multiline = false;
            txt_phone.Name = "txt_phone";
            txt_phone.Padding = new Padding(13);
            txt_phone.PasswordChar = false;
            txt_phone.Size = new Size(355, 52);
            txt_phone.TabIndex = 78;
            txt_phone.UnderlinedStyle = false;
            // 
            // txt_confirm
            // 
            txt_confirm.BackColor = Color.White;
            txt_confirm.BorderColor = Color.FromArgb(181, 191, 249);
            txt_confirm.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_confirm.BorderSize = 1;
            txt_confirm.Font = new Font("Segoe UI", 11F);
            txt_confirm.ForeColor = Color.FromArgb(38, 32, 59);
            txt_confirm.Location = new Point(54, 415);
            txt_confirm.Multiline = false;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Padding = new Padding(13);
            txt_confirm.PasswordChar = false;
            txt_confirm.Size = new Size(355, 52);
            txt_confirm.TabIndex = 77;
            txt_confirm.UnderlinedStyle = false;
            // 
            // txt_email
            // 
            txt_email.BackColor = Color.White;
            txt_email.BorderColor = Color.FromArgb(181, 191, 249);
            txt_email.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_email.BorderSize = 1;
            txt_email.Font = new Font("Segoe UI", 11F);
            txt_email.ForeColor = Color.FromArgb(38, 32, 59);
            txt_email.Location = new Point(54, 239);
            txt_email.Multiline = false;
            txt_email.Name = "txt_email";
            txt_email.Padding = new Padding(13);
            txt_email.PasswordChar = false;
            txt_email.Size = new Size(355, 52);
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
            txt_jobTitle.Location = new Point(54, 151);
            txt_jobTitle.Multiline = false;
            txt_jobTitle.Name = "txt_jobTitle";
            txt_jobTitle.Padding = new Padding(13);
            txt_jobTitle.PasswordChar = false;
            txt_jobTitle.Size = new Size(355, 52);
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
            txt_name.Location = new Point(54, 63);
            txt_name.Multiline = false;
            txt_name.Name = "txt_name";
            txt_name.Padding = new Padding(13);
            txt_name.PasswordChar = false;
            txt_name.Size = new Size(354, 52);
            txt_name.TabIndex = 21;
            txt_name.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.ForeColor = Color.FromArgb(38, 32, 59);
            label5.Location = new Point(538, 117);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(142, 32);
            label5.TabIndex = 74;
            label5.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.ForeColor = Color.FromArgb(38, 32, 59);
            label8.Location = new Point(538, 276);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 32);
            label8.TabIndex = 65;
            label8.Text = "Schedule";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14F);
            label11.ForeColor = Color.FromArgb(38, 32, 59);
            label11.Location = new Point(538, 196);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(207, 32);
            label11.TabIndex = 64;
            label11.Text = "Employment Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.ForeColor = Color.FromArgb(38, 32, 59);
            label9.Location = new Point(538, 29);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(82, 32);
            label9.TabIndex = 57;
            label9.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.FromArgb(38, 32, 59);
            label7.Location = new Point(54, 293);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(111, 32);
            label7.TabIndex = 63;
            label7.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.FromArgb(38, 32, 59);
            label1.Location = new Point(54, 117);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 62;
            label1.Text = "Job Title";
            // 
            // picEye2
            // 
            picEye2.Cursor = Cursors.Hand;
            picEye2.Image = Properties.Resources.Eye;
            picEye2.Location = new Point(346, 396);
            picEye2.Margin = new Padding(2);
            picEye2.Name = "picEye2";
            picEye2.Size = new Size(14, 12);
            picEye2.SizeMode = PictureBoxSizeMode.StretchImage;
            picEye2.TabIndex = 61;
            picEye2.TabStop = false;
            // 
            // btn_show2
            // 
            btn_show2.AutoSize = true;
            btn_show2.Cursor = Cursors.Hand;
            btn_show2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_show2.ForeColor = Color.FromArgb(38, 32, 59);
            btn_show2.Location = new Point(361, 393);
            btn_show2.Margin = new Padding(2, 0, 2, 0);
            btn_show2.Name = "btn_show2";
            btn_show2.Size = new Size(47, 20);
            btn_show2.TabIndex = 59;
            btn_show2.Text = "Show";
            btn_show2.Click += btn_show2_Click_1;
            // 
            // picEye1
            // 
            picEye1.Cursor = Cursors.Hand;
            picEye1.Image = Properties.Resources.Eye;
            picEye1.Location = new Point(347, 306);
            picEye1.Margin = new Padding(2);
            picEye1.Name = "picEye1";
            picEye1.Size = new Size(14, 12);
            picEye1.SizeMode = PictureBoxSizeMode.StretchImage;
            picEye1.TabIndex = 53;
            picEye1.TabStop = false;
            // 
            // btn_show1
            // 
            btn_show1.AutoSize = true;
            btn_show1.Cursor = Cursors.Hand;
            btn_show1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_show1.ForeColor = Color.FromArgb(38, 32, 59);
            btn_show1.Location = new Point(362, 303);
            btn_show1.Margin = new Padding(2, 0, 2, 0);
            btn_show1.Name = "btn_show1";
            btn_show1.Size = new Size(47, 20);
            btn_show1.TabIndex = 47;
            btn_show1.Text = "Show";
            btn_show1.Click += btn_show1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.FromArgb(38, 32, 59);
            label4.Location = new Point(54, 381);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(204, 32);
            label4.TabIndex = 50;
            label4.Text = "Confirm Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.FromArgb(38, 32, 59);
            label2.Location = new Point(54, 29);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 48;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.FromArgb(38, 32, 59);
            label3.Location = new Point(54, 205);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 49;
            label3.Text = "Email";
            // 
            // btn_update
            // 
            btn_update.BackColor = SystemColors.HotTrack;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(81, 540);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(213, 43);
            btn_update.TabIndex = 49;
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
            btn_delete.Location = new Point(593, 540);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(213, 43);
            btn_delete.TabIndex = 48;
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
            btn_add.Location = new Point(337, 540);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(213, 43);
            btn_add.TabIndex = 47;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // EmployeeDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1300, 900);
            Controls.Add(pictureBox1);
            Controls.Add(pnlCrudEmp);
            Controls.Add(btn_manageEmp);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_title);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeDisplay";
            Load += EmployeeDisplay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnlCrudEmp.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEye2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEye1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_title;
        private Button btn_manageEmp;
        private Panel pnlCrudEmp;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ComboBox cb_empType;
        private ComboBox cb_schedule;
        private Label label8;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label1;
        private PictureBox picEye2;
        private Label btn_show2;
        private PictureBox picEye1;
        private Label btn_show1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private ComboBox cb_dept;
        private CustomControls.CustomTextBox txt_pass;
        private CustomControls.CustomTextBox txt_phone;
        private CustomControls.CustomTextBox txt_confirm;
        private CustomControls.CustomTextBox txt_email;
        private CustomControls.CustomTextBox txt_jobTitle;
        private CustomControls.CustomTextBox txt_name;
      //  private ComboBox cb_empType;
        private ComboBox cb_schedulee;
        private ComboBox cb_deptt;
        private ComboBox cb_empTypee;
        //private ComboBox cb_dept;
        //private CustomControls.CustomComboBox cb_dept;
        //private CustomControls.CustomComboBox cb_schedule;
        //private CustomControls.CustomComboBox cb_empType;
    }
}