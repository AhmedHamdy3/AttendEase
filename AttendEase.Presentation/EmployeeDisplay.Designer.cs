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
            pnlCrudEmp = new Panel();
            ccb_jobTitle = new CustomControls.CustomComboBox();
            label4 = new Label();
            ccb_schedule = new CustomControls.CustomComboBox();
            label6 = new Label();
            ccb_emplyeeType = new CustomControls.CustomComboBox();
            ccb_gender = new CustomControls.CustomComboBox();
            ctxt_address = new CustomControls.CustomTextBox();
            ccb_dept = new CustomControls.CustomComboBox();
            cbtn_update = new CustomControls.CustomButton();
            cbtn_add = new CustomControls.CustomButton();
            cbtn_delete = new CustomControls.CustomButton();
            ctxt_phone = new CustomControls.CustomTextBox();
            ctxt_email = new CustomControls.CustomTextBox();
            ctxt_name = new CustomControls.CustomTextBox();
            label5 = new Label();
            label8 = new Label();
            label11 = new Label();
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_back = new Button();
            csb_addEmployee = new CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnlCrudEmp.SuspendLayout();
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
            // pnlCrudEmp
            // 
            pnlCrudEmp.Controls.Add(ccb_jobTitle);
            pnlCrudEmp.Controls.Add(label4);
            pnlCrudEmp.Controls.Add(ccb_schedule);
            pnlCrudEmp.Controls.Add(label6);
            pnlCrudEmp.Controls.Add(ccb_emplyeeType);
            pnlCrudEmp.Controls.Add(ccb_gender);
            pnlCrudEmp.Controls.Add(ctxt_address);
            pnlCrudEmp.Controls.Add(ccb_dept);
            pnlCrudEmp.Controls.Add(cbtn_update);
            pnlCrudEmp.Controls.Add(cbtn_add);
            pnlCrudEmp.Controls.Add(cbtn_delete);
            pnlCrudEmp.Controls.Add(ctxt_phone);
            pnlCrudEmp.Controls.Add(ctxt_email);
            pnlCrudEmp.Controls.Add(ctxt_name);
            pnlCrudEmp.Controls.Add(label5);
            pnlCrudEmp.Controls.Add(label8);
            pnlCrudEmp.Controls.Add(label11);
            pnlCrudEmp.Controls.Add(label9);
            pnlCrudEmp.Controls.Add(label1);
            pnlCrudEmp.Controls.Add(label2);
            pnlCrudEmp.Controls.Add(label3);
            pnlCrudEmp.Font = new Font("Segoe UI", 11F);
            pnlCrudEmp.ForeColor = Color.DimGray;
            pnlCrudEmp.Location = new Point(27, 222);
            pnlCrudEmp.Margin = new Padding(2);
            pnlCrudEmp.Name = "pnlCrudEmp";
            pnlCrudEmp.Size = new Size(914, 614);
            pnlCrudEmp.TabIndex = 19;
            // 
            // ccb_jobTitle
            // 
            ccb_jobTitle.BackColor = Color.White;
            ccb_jobTitle.BorderColor = Color.FromArgb(230, 230, 230);
            ccb_jobTitle.BorderSize = 1;
            ccb_jobTitle.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_jobTitle.Font = new Font("Segoe UI", 9F);
            ccb_jobTitle.ForeColor = Color.DimGray;
            ccb_jobTitle.IconColor = Color.FromArgb(10, 22, 41);
            ccb_jobTitle.Items.AddRange(new object[] { "Employee", "Hr" });
            ccb_jobTitle.ListBackColor = Color.White;
            ccb_jobTitle.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_jobTitle.Location = new Point(62, 147);
            ccb_jobTitle.MinimumSize = new Size(200, 30);
            ccb_jobTitle.Name = "ccb_jobTitle";
            ccb_jobTitle.Padding = new Padding(1);
            ccb_jobTitle.Size = new Size(354, 47);
            ccb_jobTitle.TabIndex = 111;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(62, 393);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 86;
            label4.Text = "Address";
            // 
            // ccb_schedule
            // 
            ccb_schedule.BackColor = Color.White;
            ccb_schedule.BorderColor = Color.FromArgb(230, 230, 230);
            ccb_schedule.BorderSize = 1;
            ccb_schedule.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_schedule.Font = new Font("Segoe UI", 9F);
            ccb_schedule.ForeColor = Color.DimGray;
            ccb_schedule.IconColor = Color.FromArgb(10, 22, 41);
            ccb_schedule.ListBackColor = Color.White;
            ccb_schedule.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_schedule.Location = new Point(499, 323);
            ccb_schedule.MinimumSize = new Size(200, 30);
            ccb_schedule.Name = "ccb_schedule";
            ccb_schedule.Padding = new Padding(1);
            ccb_schedule.Size = new Size(354, 47);
            ccb_schedule.TabIndex = 110;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(61, 299);
            label6.Name = "label6";
            label6.Size = new Size(66, 23);
            label6.TabIndex = 87;
            label6.Text = "Gender";
            // 
            // ccb_emplyeeType
            // 
            ccb_emplyeeType.BackColor = Color.White;
            ccb_emplyeeType.BorderColor = Color.FromArgb(230, 230, 230);
            ccb_emplyeeType.BorderSize = 1;
            ccb_emplyeeType.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_emplyeeType.Font = new Font("Segoe UI", 9F);
            ccb_emplyeeType.ForeColor = Color.DimGray;
            ccb_emplyeeType.IconColor = Color.FromArgb(10, 22, 41);
            ccb_emplyeeType.Items.AddRange(new object[] { "Full Time", "Part Time", "Remote" });
            ccb_emplyeeType.ListBackColor = Color.White;
            ccb_emplyeeType.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_emplyeeType.Location = new Point(499, 235);
            ccb_emplyeeType.MinimumSize = new Size(200, 30);
            ccb_emplyeeType.Name = "ccb_emplyeeType";
            ccb_emplyeeType.Padding = new Padding(1);
            ccb_emplyeeType.Size = new Size(354, 47);
            ccb_emplyeeType.TabIndex = 109;
            // 
            // ccb_gender
            // 
            ccb_gender.BackColor = Color.White;
            ccb_gender.BorderColor = Color.FromArgb(230, 230, 230);
            ccb_gender.BorderSize = 1;
            ccb_gender.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_gender.Font = new Font("Segoe UI", 9F);
            ccb_gender.ForeColor = Color.DimGray;
            ccb_gender.IconColor = Color.FromArgb(10, 22, 41);
            ccb_gender.Items.AddRange(new object[] { "Male", "Female" });
            ccb_gender.ListBackColor = Color.White;
            ccb_gender.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_gender.Location = new Point(62, 323);
            ccb_gender.MinimumSize = new Size(200, 30);
            ccb_gender.Name = "ccb_gender";
            ccb_gender.Padding = new Padding(1);
            ccb_gender.Size = new Size(354, 47);
            ccb_gender.TabIndex = 89;
            // 
            // ctxt_address
            // 
            ctxt_address.BackColor = Color.White;
            ctxt_address.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_address.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_address.BorderSize = 1;
            ctxt_address.Font = new Font("Segoe UI", 9F);
            ctxt_address.ForeColor = Color.DimGray;
            ctxt_address.Location = new Point(61, 419);
            ctxt_address.Multiline = false;
            ctxt_address.Name = "ctxt_address";
            ctxt_address.Padding = new Padding(13);
            ctxt_address.PasswordChar = false;
            ctxt_address.Size = new Size(351, 47);
            ctxt_address.TabIndex = 88;
            ctxt_address.UnderlinedStyle = false;
            // 
            // ccb_dept
            // 
            ccb_dept.BackColor = Color.White;
            ccb_dept.BorderColor = Color.FromArgb(230, 230, 230);
            ccb_dept.BorderSize = 1;
            ccb_dept.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_dept.Font = new Font("Segoe UI", 9F);
            ccb_dept.ForeColor = Color.DimGray;
            ccb_dept.IconColor = Color.FromArgb(10, 22, 41);
            ccb_dept.ListBackColor = Color.White;
            ccb_dept.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_dept.Location = new Point(499, 147);
            ccb_dept.MinimumSize = new Size(200, 30);
            ccb_dept.Name = "ccb_dept";
            ccb_dept.Padding = new Padding(1);
            ccb_dept.Size = new Size(354, 47);
            ccb_dept.TabIndex = 108;
            // 
            // cbtn_update
            // 
            cbtn_update.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_update.BorderColor = Color.Black;
            cbtn_update.BorderRadius = 10;
            cbtn_update.BorderSize = 0;
            cbtn_update.Cursor = Cursors.Hand;
            cbtn_update.FlatAppearance.BorderSize = 0;
            cbtn_update.FlatStyle = FlatStyle.Flat;
            cbtn_update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_update.ForeColor = Color.White;
            cbtn_update.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_update.Location = new Point(482, 525);
            cbtn_update.Name = "cbtn_update";
            cbtn_update.Size = new Size(213, 50);
            cbtn_update.TabIndex = 107;
            cbtn_update.Text = "Update";
            cbtn_update.UseVisualStyleBackColor = false;
            cbtn_update.Click += cbtn_update_Click;
            // 
            // cbtn_add
            // 
            cbtn_add.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_add.BorderColor = Color.Black;
            cbtn_add.BorderRadius = 10;
            cbtn_add.BorderSize = 0;
            cbtn_add.Cursor = Cursors.Hand;
            cbtn_add.FlatAppearance.BorderSize = 0;
            cbtn_add.FlatStyle = FlatStyle.Flat;
            cbtn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_add.ForeColor = Color.White;
            cbtn_add.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_add.Location = new Point(346, 525);
            cbtn_add.Name = "cbtn_add";
            cbtn_add.Size = new Size(213, 50);
            cbtn_add.TabIndex = 106;
            cbtn_add.Text = "Add";
            cbtn_add.UseVisualStyleBackColor = false;
            cbtn_add.Click += cbtn_add_Click;
            // 
            // cbtn_delete
            // 
            cbtn_delete.BackColor = Color.FromArgb(192, 0, 0);
            cbtn_delete.BorderColor = Color.Black;
            cbtn_delete.BorderRadius = 10;
            cbtn_delete.BorderSize = 0;
            cbtn_delete.Cursor = Cursors.Hand;
            cbtn_delete.FlatAppearance.BorderSize = 0;
            cbtn_delete.FlatStyle = FlatStyle.Flat;
            cbtn_delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_delete.ForeColor = Color.White;
            cbtn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_delete.Location = new Point(199, 525);
            cbtn_delete.Name = "cbtn_delete";
            cbtn_delete.Size = new Size(213, 50);
            cbtn_delete.TabIndex = 86;
            cbtn_delete.Text = "Delete";
            cbtn_delete.UseVisualStyleBackColor = false;
            cbtn_delete.Click += cbtn_delete_Click;
            // 
            // ctxt_phone
            // 
            ctxt_phone.BackColor = Color.White;
            ctxt_phone.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_phone.BorderFocusColor = Color.FromArgb(230, 230, 230);
            ctxt_phone.BorderSize = 1;
            ctxt_phone.Font = new Font("Segoe UI", 9F);
            ctxt_phone.ForeColor = Color.DimGray;
            ctxt_phone.Location = new Point(499, 59);
            ctxt_phone.Multiline = false;
            ctxt_phone.Name = "ctxt_phone";
            ctxt_phone.Padding = new Padding(13);
            ctxt_phone.PasswordChar = false;
            ctxt_phone.Size = new Size(355, 47);
            ctxt_phone.TabIndex = 101;
            ctxt_phone.UnderlinedStyle = false;
            // 
            // ctxt_email
            // 
            ctxt_email.BackColor = Color.White;
            ctxt_email.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_email.BorderFocusColor = Color.FromArgb(230, 230, 230);
            ctxt_email.BorderSize = 1;
            ctxt_email.Font = new Font("Segoe UI", 9F);
            ctxt_email.ForeColor = Color.DimGray;
            ctxt_email.Location = new Point(62, 235);
            ctxt_email.Multiline = false;
            ctxt_email.Name = "ctxt_email";
            ctxt_email.Padding = new Padding(13);
            ctxt_email.PasswordChar = false;
            ctxt_email.Size = new Size(355, 47);
            ctxt_email.TabIndex = 99;
            ctxt_email.UnderlinedStyle = false;
            // 
            // ctxt_name
            // 
            ctxt_name.BackColor = Color.White;
            ctxt_name.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_name.BorderFocusColor = Color.FromArgb(230, 230, 230);
            ctxt_name.BorderSize = 1;
            ctxt_name.Font = new Font("Segoe UI", 9F);
            ctxt_name.ForeColor = Color.DimGray;
            ctxt_name.Location = new Point(62, 59);
            ctxt_name.Multiline = false;
            ctxt_name.Name = "ctxt_name";
            ctxt_name.Padding = new Padding(13);
            ctxt_name.PasswordChar = false;
            ctxt_name.Size = new Size(354, 47);
            ctxt_name.TabIndex = 84;
            ctxt_name.UnderlinedStyle = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(499, 120);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(102, 23);
            label5.TabIndex = 97;
            label5.Text = "Department";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(499, 296);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(79, 23);
            label8.TabIndex = 96;
            label8.Text = "Schedule";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(499, 208);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(148, 23);
            label11.TabIndex = 95;
            label11.Text = "Employment Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(499, 32);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 23);
            label9.TabIndex = 90;
            label9.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(62, 120);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 93;
            label1.Text = "Job Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(62, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 86;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(62, 208);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 87;
            label3.Text = "Email";
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
            btn_back.Location = new Point(27, 194);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(190, 29);
            btn_back.TabIndex = 84;
            btn_back.Text = "      Back to Employees";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click;
            // 
            // csb_addEmployee
            // 
            csb_addEmployee.BackColor = Color.FromArgb(70, 95, 241);
            csb_addEmployee.BorderColor = Color.Black;
            csb_addEmployee.BorderRadius = 10;
            csb_addEmployee.BorderSize = 0;
            csb_addEmployee.Cursor = Cursors.Hand;
            csb_addEmployee.FlatAppearance.BorderSize = 0;
            csb_addEmployee.FlatStyle = FlatStyle.Flat;
            csb_addEmployee.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            csb_addEmployee.ForeColor = Color.White;
            csb_addEmployee.Image = (Image)resources.GetObject("csb_addEmployee.Image");
            csb_addEmployee.ImageAlign = ContentAlignment.MiddleLeft;
            csb_addEmployee.Location = new Point(696, 155);
            csb_addEmployee.Name = "csb_addEmployee";
            csb_addEmployee.Padding = new Padding(25, 0, 0, 0);
            csb_addEmployee.Size = new Size(218, 50);
            csb_addEmployee.TabIndex = 85;
            csb_addEmployee.Text = "  Add Employee";
            csb_addEmployee.UseVisualStyleBackColor = false;
            csb_addEmployee.Click += csb_addEmployee_Click;
            // 
            // EmployeeDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(csb_addEmployee);
            Controls.Add(btn_back);
            Controls.Add(pnlCrudEmp);
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
            pnlCrudEmp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_title;
        private Panel pnlCrudEmp;
        private ComboBox cb_empType;
        private ComboBox cb_schedule;
        private ComboBox cb_dept;
        private Button btn_back;
        private CustomControls.CustomButton csb_addEmployee;
        private CustomControls.CustomButton cbtn_update;
        private CustomControls.CustomButton cbtn_add;
        private CustomControls.CustomButton cbtn_delete;
        private CustomControls.CustomTextBox ctxt_phone;
        private CustomControls.CustomTextBox ctxt_email;
        private CustomControls.CustomTextBox ctxt_name;
        private Label label5;
        private Label label8;
        private Label label11;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private CustomControls.CustomComboBox ccb_schedule;
        private CustomControls.CustomComboBox ccb_emplyeeType;
        private CustomControls.CustomComboBox ccb_dept;
        private Label label4;
        private Label label6;
        private CustomControls.CustomComboBox ccb_gender;
        private CustomControls.CustomTextBox ctxt_address;
        private CustomControls.CustomComboBox ccb_jobTitle;
        //private ComboBox cb_dept;
        //private CustomControls.CustomComboBox cb_dept;
        //private CustomControls.CustomComboBox cb_schedule;
        //private CustomControls.CustomComboBox cb_empType;
    }
}