namespace AttendEase.Presentation
{
    partial class EmployeeProfileForm
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
            Panel panel6;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeProfileForm));
            cbtn_save = new CustomControls.CustomButton();
            ccb_gender = new CustomControls.CustomComboBox();
            ctxt_address = new CustomControls.CustomTextBox();
            ctxt_phone = new CustomControls.CustomTextBox();
            ctxt_email = new CustomControls.CustomTextBox();
            label4 = new Label();
            ctxt_name = new CustomControls.CustomTextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            cbtn_updateProfileImage = new CustomControls.CustomButton();
            pb_profileImage = new PictureBox();
            panel11 = new Panel();
            btn_back = new Button();
            panel6 = new Panel();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).BeginInit();
            SuspendLayout();
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(cbtn_save);
            panel6.Controls.Add(ccb_gender);
            panel6.Controls.Add(ctxt_address);
            panel6.Controls.Add(ctxt_phone);
            panel6.Controls.Add(ctxt_email);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(ctxt_name);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label3);
            panel6.Controls.Add(label1);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(564, 615);
            panel6.TabIndex = 10;
            // 
            // cbtn_save
            // 
            cbtn_save.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_save.BorderRadius = 8;
            cbtn_save.FlatAppearance.BorderSize = 0;
            cbtn_save.FlatStyle = FlatStyle.Flat;
            cbtn_save.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_save.ForeColor = Color.White;
            cbtn_save.Location = new Point(167, 516);
            cbtn_save.Name = "cbtn_save";
            cbtn_save.Size = new Size(150, 50);
            cbtn_save.TabIndex = 15;
            cbtn_save.Text = "Save";
            cbtn_save.UseVisualStyleBackColor = false;
            cbtn_save.Click += cbtn_save_Click;
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
            ccb_gender.Location = new Point(167, 347);
            ccb_gender.MinimumSize = new Size(200, 30);
            ccb_gender.Name = "ccb_gender";
            ccb_gender.Padding = new Padding(1);
            ccb_gender.Size = new Size(380, 47);
            ccb_gender.TabIndex = 13;
            // 
            // ctxt_address
            // 
            ctxt_address.BackColor = Color.White;
            ctxt_address.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_address.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_address.BorderSize = 1;
            ctxt_address.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_address.Location = new Point(167, 451);
            ctxt_address.Multiline = false;
            ctxt_address.Name = "ctxt_address";
            ctxt_address.Padding = new Padding(13);
            ctxt_address.PasswordChar = false;
            ctxt_address.Size = new Size(380, 47);
            ctxt_address.TabIndex = 12;
            ctxt_address.UnderlinedStyle = false;
            // 
            // ctxt_phone
            // 
            ctxt_phone.BackColor = Color.White;
            ctxt_phone.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_phone.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_phone.BorderSize = 1;
            ctxt_phone.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_phone.Location = new Point(167, 243);
            ctxt_phone.Multiline = false;
            ctxt_phone.Name = "ctxt_phone";
            ctxt_phone.Padding = new Padding(13);
            ctxt_phone.PasswordChar = false;
            ctxt_phone.Size = new Size(380, 47);
            ctxt_phone.TabIndex = 10;
            ctxt_phone.UnderlinedStyle = false;
            // 
            // ctxt_email
            // 
            ctxt_email.BackColor = Color.White;
            ctxt_email.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_email.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_email.BorderSize = 1;
            ctxt_email.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_email.Location = new Point(167, 139);
            ctxt_email.Multiline = false;
            ctxt_email.Name = "ctxt_email";
            ctxt_email.Padding = new Padding(13);
            ctxt_email.PasswordChar = false;
            ctxt_email.Size = new Size(380, 47);
            ctxt_email.TabIndex = 9;
            ctxt_email.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(43, 49);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 3;
            label4.Text = "Full Name";
            // 
            // ctxt_name
            // 
            ctxt_name.BackColor = Color.White;
            ctxt_name.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_name.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_name.BorderSize = 1;
            ctxt_name.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_name.Location = new Point(167, 35);
            ctxt_name.Multiline = false;
            ctxt_name.Name = "ctxt_name";
            ctxt_name.Padding = new Padding(13);
            ctxt_name.PasswordChar = false;
            ctxt_name.Size = new Size(380, 47);
            ctxt_name.TabIndex = 8;
            ctxt_name.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(43, 153);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(43, 257);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(43, 361);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(43, 465);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "Address";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(234, 242, 239);
            panel7.Location = new Point(381, 196);
            panel7.Name = "panel7";
            panel7.Size = new Size(570, 620);
            panel7.TabIndex = 11;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(230, 233, 234);
            panel8.Controls.Add(panel6);
            panel8.Location = new Point(381, 195);
            panel8.Name = "panel8";
            panel8.Size = new Size(567, 618);
            panel8.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(230, 233, 234);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(17, 195);
            panel9.Name = "panel9";
            panel9.Size = new Size(356, 618);
            panel9.TabIndex = 12;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(cbtn_updateProfileImage);
            panel10.Controls.Add(pb_profileImage);
            panel10.Cursor = Cursors.Hand;
            panel10.Location = new Point(1, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(354, 615);
            panel10.TabIndex = 10;
            // 
            // cbtn_updateProfileImage
            // 
            cbtn_updateProfileImage.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_updateProfileImage.BorderRadius = 8;
            cbtn_updateProfileImage.FlatAppearance.BorderSize = 0;
            cbtn_updateProfileImage.FlatStyle = FlatStyle.Flat;
            cbtn_updateProfileImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_updateProfileImage.ForeColor = Color.White;
            cbtn_updateProfileImage.Image = Properties.Resources.Camera;
            cbtn_updateProfileImage.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_updateProfileImage.Location = new Point(49, 345);
            cbtn_updateProfileImage.Name = "cbtn_updateProfileImage";
            cbtn_updateProfileImage.Padding = new Padding(40, 0, 0, 0);
            cbtn_updateProfileImage.Size = new Size(254, 50);
            cbtn_updateProfileImage.TabIndex = 14;
            cbtn_updateProfileImage.Text = "         Update Image";
            cbtn_updateProfileImage.TextAlign = ContentAlignment.MiddleLeft;
            cbtn_updateProfileImage.UseVisualStyleBackColor = false;
            cbtn_updateProfileImage.Click += cbtn_updateProfileImage_Click;
            // 
            // pb_profileImage
            // 
            pb_profileImage.Location = new Point(35, 35);
            pb_profileImage.Name = "pb_profileImage";
            pb_profileImage.Size = new Size(285, 285);
            pb_profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_profileImage.TabIndex = 14;
            pb_profileImage.TabStop = false;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(234, 242, 239);
            panel11.Location = new Point(17, 196);
            panel11.Name = "panel11";
            panel11.Size = new Size(359, 620);
            panel11.TabIndex = 13;
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
            btn_back.Location = new Point(18, 148);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(92, 29);
            btn_back.TabIndex = 24;
            btn_back.Text = "      Back";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            // 
            // EmployeeProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(btn_back);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel9);
            Controls.Add(panel11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeProfileForm";
            Text = "EmployeeProfileForm";
            Load += EmployeeProfileForm_Load;
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CustomControls.CustomTextBox ctxt_name;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private CustomControls.CustomTextBox ctxt_address;
        private CustomControls.CustomTextBox ctxt_phone;
        private CustomControls.CustomTextBox ctxt_email;
        private CustomControls.CustomComboBox ccb_gender;
        private PictureBox pb_profileImage;
        private CustomControls.CustomButton cbtn_updateProfileImage;
        private CustomControls.CustomButton cbtn_save;
        private Button btn_back;
    }
}