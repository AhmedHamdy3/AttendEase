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
            cbtn_save = new CustomControls.CustomButton();
            cbtn_updateProfileImage = new CustomControls.CustomButton();
            pb_profileImage = new PictureBox();
            pnl_editInfo = new Panel();
            cbtn_editCancel = new CustomControls.CustomButton();
            pnl_showInfo = new Panel();
            lbl_address = new Label();
            lbl_gender = new Label();
            lbl_phone = new Label();
            lbl_email = new Label();
            lbl_name = new Label();
            cbtn_changePassword = new CustomControls.CustomButton();
            cbtn_editProfile = new CustomControls.CustomButton();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pnl_changePassword = new Panel();
            btn_showCurrent = new Button();
            btn_showNew = new Button();
            btn_showConfirm = new Button();
            ctxt_currentPassword = new CustomControls.CustomTextBox();
            ctxt_newPassword = new CustomControls.CustomTextBox();
            ctxt_confirmPassword = new CustomControls.CustomTextBox();
            cbtn_cancelPassword = new CustomControls.CustomButton();
            label20 = new Label();
            cbtn_savePassword = new CustomControls.CustomButton();
            label18 = new Label();
            label19 = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).BeginInit();
            pnl_editInfo.SuspendLayout();
            pnl_showInfo.SuspendLayout();
            pnl_changePassword.SuspendLayout();
            SuspendLayout();
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
            ccb_gender.Location = new Point(123, 300);
            ccb_gender.MinimumSize = new Size(200, 30);
            ccb_gender.Name = "ccb_gender";
            ccb_gender.Padding = new Padding(1);
            ccb_gender.Size = new Size(338, 47);
            ccb_gender.TabIndex = 25;
            // 
            // ctxt_address
            // 
            ctxt_address.BackColor = Color.White;
            ctxt_address.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_address.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_address.BorderSize = 1;
            ctxt_address.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_address.Location = new Point(123, 391);
            ctxt_address.Multiline = false;
            ctxt_address.Name = "ctxt_address";
            ctxt_address.Padding = new Padding(13);
            ctxt_address.PasswordChar = false;
            ctxt_address.Size = new Size(338, 47);
            ctxt_address.TabIndex = 24;
            ctxt_address.UnderlinedStyle = false;
            // 
            // ctxt_phone
            // 
            ctxt_phone.BackColor = Color.White;
            ctxt_phone.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_phone.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_phone.BorderSize = 1;
            ctxt_phone.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_phone.Location = new Point(123, 209);
            ctxt_phone.Multiline = false;
            ctxt_phone.Name = "ctxt_phone";
            ctxt_phone.Padding = new Padding(13);
            ctxt_phone.PasswordChar = false;
            ctxt_phone.Size = new Size(338, 47);
            ctxt_phone.TabIndex = 23;
            ctxt_phone.UnderlinedStyle = false;
            // 
            // ctxt_email
            // 
            ctxt_email.BackColor = Color.White;
            ctxt_email.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_email.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_email.BorderSize = 1;
            ctxt_email.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_email.Location = new Point(123, 118);
            ctxt_email.Multiline = false;
            ctxt_email.Name = "ctxt_email";
            ctxt_email.Padding = new Padding(13);
            ctxt_email.PasswordChar = false;
            ctxt_email.Size = new Size(338, 47);
            ctxt_email.TabIndex = 22;
            ctxt_email.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(25, 41);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 18;
            label4.Text = "Full Name";
            // 
            // ctxt_name
            // 
            ctxt_name.BackColor = Color.White;
            ctxt_name.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_name.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_name.BorderSize = 1;
            ctxt_name.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_name.Location = new Point(123, 27);
            ctxt_name.Multiline = false;
            ctxt_name.Name = "ctxt_name";
            ctxt_name.Padding = new Padding(13);
            ctxt_name.PasswordChar = false;
            ctxt_name.Size = new Size(338, 47);
            ctxt_name.TabIndex = 21;
            ctxt_name.UnderlinedStyle = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(25, 132);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 20;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(25, 223);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 19;
            label5.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 314);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 17;
            label3.Text = "Gender";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(25, 405);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 16;
            label1.Text = "Address";
            // 
            // cbtn_save
            // 
            cbtn_save.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_save.BorderColor = Color.Black;
            cbtn_save.BorderRadius = 8;
            cbtn_save.BorderSize = 0;
            cbtn_save.Cursor = Cursors.Hand;
            cbtn_save.FlatAppearance.BorderSize = 0;
            cbtn_save.FlatStyle = FlatStyle.Flat;
            cbtn_save.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_save.ForeColor = Color.White;
            cbtn_save.Location = new Point(25, 496);
            cbtn_save.Name = "cbtn_save";
            cbtn_save.Size = new Size(177, 50);
            cbtn_save.TabIndex = 26;
            cbtn_save.Text = "Save";
            cbtn_save.UseVisualStyleBackColor = false;
            cbtn_save.Click += cbtn_save_Click;
            // 
            // cbtn_updateProfileImage
            // 
            cbtn_updateProfileImage.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_updateProfileImage.BorderColor = Color.Black;
            cbtn_updateProfileImage.BorderRadius = 8;
            cbtn_updateProfileImage.BorderSize = 0;
            cbtn_updateProfileImage.Cursor = Cursors.Hand;
            cbtn_updateProfileImage.FlatAppearance.BorderSize = 0;
            cbtn_updateProfileImage.FlatStyle = FlatStyle.Flat;
            cbtn_updateProfileImage.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_updateProfileImage.ForeColor = Color.White;
            cbtn_updateProfileImage.Image = Properties.Resources.Camera;
            cbtn_updateProfileImage.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_updateProfileImage.Location = new Point(81, 615);
            cbtn_updateProfileImage.Name = "cbtn_updateProfileImage";
            cbtn_updateProfileImage.Padding = new Padding(40, 0, 0, 0);
            cbtn_updateProfileImage.Size = new Size(254, 50);
            cbtn_updateProfileImage.TabIndex = 27;
            cbtn_updateProfileImage.Text = "         Update Photo";
            cbtn_updateProfileImage.TextAlign = ContentAlignment.MiddleLeft;
            cbtn_updateProfileImage.UseVisualStyleBackColor = false;
            cbtn_updateProfileImage.Click += cbtn_updateProfileImage_Click;
            // 
            // pb_profileImage
            // 
            pb_profileImage.Location = new Point(64, 235);
            pb_profileImage.Name = "pb_profileImage";
            pb_profileImage.Size = new Size(285, 285);
            pb_profileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_profileImage.TabIndex = 28;
            pb_profileImage.TabStop = false;
            // 
            // pnl_editInfo
            // 
            pnl_editInfo.Controls.Add(cbtn_editCancel);
            pnl_editInfo.Controls.Add(cbtn_save);
            pnl_editInfo.Controls.Add(label1);
            pnl_editInfo.Controls.Add(label3);
            pnl_editInfo.Controls.Add(label5);
            pnl_editInfo.Controls.Add(label6);
            pnl_editInfo.Controls.Add(ctxt_name);
            pnl_editInfo.Controls.Add(ctxt_email);
            pnl_editInfo.Controls.Add(ctxt_phone);
            pnl_editInfo.Controls.Add(ccb_gender);
            pnl_editInfo.Controls.Add(ctxt_address);
            pnl_editInfo.Controls.Add(label4);
            pnl_editInfo.Location = new Point(420, 119);
            pnl_editInfo.Name = "pnl_editInfo";
            pnl_editInfo.Size = new Size(489, 591);
            pnl_editInfo.TabIndex = 29;
            pnl_editInfo.Visible = false;
            // 
            // cbtn_editCancel
            // 
            cbtn_editCancel.BackColor = Color.Transparent;
            cbtn_editCancel.BorderColor = Color.FromArgb(70, 95, 241);
            cbtn_editCancel.BorderRadius = 8;
            cbtn_editCancel.BorderSize = 1;
            cbtn_editCancel.Cursor = Cursors.Hand;
            cbtn_editCancel.FlatAppearance.BorderSize = 0;
            cbtn_editCancel.FlatStyle = FlatStyle.Flat;
            cbtn_editCancel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_editCancel.ForeColor = Color.FromArgb(70, 95, 241);
            cbtn_editCancel.Location = new Point(208, 496);
            cbtn_editCancel.Name = "cbtn_editCancel";
            cbtn_editCancel.Size = new Size(177, 50);
            cbtn_editCancel.TabIndex = 27;
            cbtn_editCancel.Text = "Cancel";
            cbtn_editCancel.UseVisualStyleBackColor = false;
            cbtn_editCancel.Click += cbtn_editCancel_Click;
            // 
            // pnl_showInfo
            // 
            pnl_showInfo.Controls.Add(lbl_address);
            pnl_showInfo.Controls.Add(lbl_gender);
            pnl_showInfo.Controls.Add(lbl_phone);
            pnl_showInfo.Controls.Add(lbl_email);
            pnl_showInfo.Controls.Add(lbl_name);
            pnl_showInfo.Controls.Add(cbtn_changePassword);
            pnl_showInfo.Controls.Add(cbtn_editProfile);
            pnl_showInfo.Controls.Add(label2);
            pnl_showInfo.Controls.Add(label7);
            pnl_showInfo.Controls.Add(label8);
            pnl_showInfo.Controls.Add(label9);
            pnl_showInfo.Controls.Add(label10);
            pnl_showInfo.Location = new Point(420, 119);
            pnl_showInfo.Name = "pnl_showInfo";
            pnl_showInfo.Size = new Size(489, 591);
            pnl_showInfo.TabIndex = 30;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbl_address.ForeColor = SystemColors.ControlDarkDark;
            lbl_address.Location = new Point(42, 426);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(0, 25);
            lbl_address.TabIndex = 32;
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbl_gender.ForeColor = SystemColors.ControlDarkDark;
            lbl_gender.Location = new Point(42, 335);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(0, 25);
            lbl_gender.TabIndex = 31;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbl_phone.ForeColor = SystemColors.ControlDarkDark;
            lbl_phone.Location = new Point(42, 244);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(0, 25);
            lbl_phone.TabIndex = 30;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbl_email.ForeColor = SystemColors.ControlDarkDark;
            lbl_email.Location = new Point(42, 153);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(0, 25);
            lbl_email.TabIndex = 29;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lbl_name.ForeColor = SystemColors.ControlDarkDark;
            lbl_name.Location = new Point(42, 62);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(0, 25);
            lbl_name.TabIndex = 28;
            // 
            // cbtn_changePassword
            // 
            cbtn_changePassword.BackColor = Color.Transparent;
            cbtn_changePassword.BorderColor = Color.FromArgb(70, 95, 241);
            cbtn_changePassword.BorderRadius = 8;
            cbtn_changePassword.BorderSize = 1;
            cbtn_changePassword.Cursor = Cursors.Hand;
            cbtn_changePassword.FlatAppearance.BorderSize = 0;
            cbtn_changePassword.FlatStyle = FlatStyle.Flat;
            cbtn_changePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_changePassword.ForeColor = Color.FromArgb(70, 95, 241);
            cbtn_changePassword.Location = new Point(221, 496);
            cbtn_changePassword.Name = "cbtn_changePassword";
            cbtn_changePassword.Size = new Size(218, 50);
            cbtn_changePassword.TabIndex = 27;
            cbtn_changePassword.Text = "Change Password";
            cbtn_changePassword.UseVisualStyleBackColor = false;
            cbtn_changePassword.Click += cbtn_changePassword_Click;
            // 
            // cbtn_editProfile
            // 
            cbtn_editProfile.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_editProfile.BorderColor = Color.Black;
            cbtn_editProfile.BorderRadius = 8;
            cbtn_editProfile.BorderSize = 0;
            cbtn_editProfile.Cursor = Cursors.Hand;
            cbtn_editProfile.FlatAppearance.BorderSize = 0;
            cbtn_editProfile.FlatStyle = FlatStyle.Flat;
            cbtn_editProfile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_editProfile.ForeColor = Color.White;
            cbtn_editProfile.Location = new Point(25, 496);
            cbtn_editProfile.Name = "cbtn_editProfile";
            cbtn_editProfile.Size = new Size(190, 50);
            cbtn_editProfile.TabIndex = 26;
            cbtn_editProfile.Text = "Edit Profile";
            cbtn_editProfile.UseVisualStyleBackColor = false;
            cbtn_editProfile.Click += cbtn_editProfile_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 405);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 16;
            label2.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(25, 315);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 17;
            label7.Text = "Gender";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(25, 223);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 19;
            label8.Text = "Phone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(25, 132);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 20;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(25, 41);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 18;
            label10.Text = "Full Name";
            // 
            // pnl_changePassword
            // 
            pnl_changePassword.Controls.Add(btn_showCurrent);
            pnl_changePassword.Controls.Add(btn_showNew);
            pnl_changePassword.Controls.Add(btn_showConfirm);
            pnl_changePassword.Controls.Add(ctxt_currentPassword);
            pnl_changePassword.Controls.Add(ctxt_newPassword);
            pnl_changePassword.Controls.Add(ctxt_confirmPassword);
            pnl_changePassword.Controls.Add(cbtn_cancelPassword);
            pnl_changePassword.Controls.Add(label20);
            pnl_changePassword.Controls.Add(cbtn_savePassword);
            pnl_changePassword.Controls.Add(label18);
            pnl_changePassword.Controls.Add(label19);
            pnl_changePassword.Location = new Point(420, 119);
            pnl_changePassword.Name = "pnl_changePassword";
            pnl_changePassword.Size = new Size(489, 591);
            pnl_changePassword.TabIndex = 33;
            pnl_changePassword.Visible = false;
            // 
            // btn_showCurrent
            // 
            btn_showCurrent.BackColor = Color.Transparent;
            btn_showCurrent.Cursor = Cursors.Hand;
            btn_showCurrent.FlatAppearance.BorderSize = 0;
            btn_showCurrent.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_showCurrent.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_showCurrent.FlatStyle = FlatStyle.Flat;
            btn_showCurrent.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_showCurrent.ForeColor = Color.FromArgb(38, 32, 59);
            btn_showCurrent.Image = Properties.Resources.Eye1;
            btn_showCurrent.ImageAlign = ContentAlignment.MiddleLeft;
            btn_showCurrent.Location = new Point(378, 95);
            btn_showCurrent.Name = "btn_showCurrent";
            btn_showCurrent.Size = new Size(76, 29);
            btn_showCurrent.TabIndex = 41;
            btn_showCurrent.Text = "     Show";
            btn_showCurrent.TextAlign = ContentAlignment.MiddleLeft;
            btn_showCurrent.UseVisualStyleBackColor = false;
            btn_showCurrent.Click += btn_showCurrent_Click;
            // 
            // btn_showNew
            // 
            btn_showNew.BackColor = Color.Transparent;
            btn_showNew.Cursor = Cursors.Hand;
            btn_showNew.FlatAppearance.BorderSize = 0;
            btn_showNew.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_showNew.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_showNew.FlatStyle = FlatStyle.Flat;
            btn_showNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_showNew.ForeColor = Color.FromArgb(38, 32, 59);
            btn_showNew.Image = Properties.Resources.Eye1;
            btn_showNew.ImageAlign = ContentAlignment.MiddleLeft;
            btn_showNew.Location = new Point(378, 209);
            btn_showNew.Name = "btn_showNew";
            btn_showNew.Size = new Size(76, 29);
            btn_showNew.TabIndex = 40;
            btn_showNew.Text = "     Show";
            btn_showNew.TextAlign = ContentAlignment.MiddleLeft;
            btn_showNew.UseVisualStyleBackColor = false;
            btn_showNew.Click += btn_showNew_Click;
            // 
            // btn_showConfirm
            // 
            btn_showConfirm.BackColor = Color.Transparent;
            btn_showConfirm.Cursor = Cursors.Hand;
            btn_showConfirm.FlatAppearance.BorderSize = 0;
            btn_showConfirm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_showConfirm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_showConfirm.FlatStyle = FlatStyle.Flat;
            btn_showConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_showConfirm.ForeColor = Color.FromArgb(38, 32, 59);
            btn_showConfirm.Image = Properties.Resources.Eye1;
            btn_showConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btn_showConfirm.Location = new Point(378, 320);
            btn_showConfirm.Name = "btn_showConfirm";
            btn_showConfirm.Size = new Size(76, 29);
            btn_showConfirm.TabIndex = 39;
            btn_showConfirm.Text = "     Show";
            btn_showConfirm.TextAlign = ContentAlignment.MiddleLeft;
            btn_showConfirm.UseVisualStyleBackColor = false;
            btn_showConfirm.Click += btn_showConfirm_Click;
            // 
            // ctxt_currentPassword
            // 
            ctxt_currentPassword.BackColor = Color.White;
            ctxt_currentPassword.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_currentPassword.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_currentPassword.BorderSize = 1;
            ctxt_currentPassword.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_currentPassword.Location = new Point(29, 130);
            ctxt_currentPassword.Multiline = false;
            ctxt_currentPassword.Name = "ctxt_currentPassword";
            ctxt_currentPassword.Padding = new Padding(13);
            ctxt_currentPassword.PasswordChar = true;
            ctxt_currentPassword.Size = new Size(425, 47);
            ctxt_currentPassword.TabIndex = 38;
            ctxt_currentPassword.UnderlinedStyle = false;
            // 
            // ctxt_newPassword
            // 
            ctxt_newPassword.BackColor = Color.White;
            ctxt_newPassword.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_newPassword.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_newPassword.BorderSize = 1;
            ctxt_newPassword.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_newPassword.Location = new Point(29, 241);
            ctxt_newPassword.Multiline = false;
            ctxt_newPassword.Name = "ctxt_newPassword";
            ctxt_newPassword.Padding = new Padding(13);
            ctxt_newPassword.PasswordChar = true;
            ctxt_newPassword.Size = new Size(425, 47);
            ctxt_newPassword.TabIndex = 37;
            ctxt_newPassword.UnderlinedStyle = false;
            // 
            // ctxt_confirmPassword
            // 
            ctxt_confirmPassword.BackColor = Color.White;
            ctxt_confirmPassword.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_confirmPassword.BorderFocusColor = Color.FromArgb(252, 252, 252);
            ctxt_confirmPassword.BorderSize = 1;
            ctxt_confirmPassword.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_confirmPassword.Location = new Point(29, 352);
            ctxt_confirmPassword.Multiline = false;
            ctxt_confirmPassword.Name = "ctxt_confirmPassword";
            ctxt_confirmPassword.Padding = new Padding(13);
            ctxt_confirmPassword.PasswordChar = true;
            ctxt_confirmPassword.Size = new Size(425, 47);
            ctxt_confirmPassword.TabIndex = 36;
            ctxt_confirmPassword.UnderlinedStyle = false;
            // 
            // cbtn_cancelPassword
            // 
            cbtn_cancelPassword.BackColor = Color.Transparent;
            cbtn_cancelPassword.BorderColor = Color.FromArgb(70, 95, 241);
            cbtn_cancelPassword.BorderRadius = 8;
            cbtn_cancelPassword.BorderSize = 1;
            cbtn_cancelPassword.Cursor = Cursors.Hand;
            cbtn_cancelPassword.FlatAppearance.BorderSize = 0;
            cbtn_cancelPassword.FlatStyle = FlatStyle.Flat;
            cbtn_cancelPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_cancelPassword.ForeColor = Color.FromArgb(70, 95, 241);
            cbtn_cancelPassword.Location = new Point(221, 496);
            cbtn_cancelPassword.Name = "cbtn_cancelPassword";
            cbtn_cancelPassword.Size = new Size(177, 50);
            cbtn_cancelPassword.TabIndex = 35;
            cbtn_cancelPassword.Text = "Cancel";
            cbtn_cancelPassword.UseVisualStyleBackColor = false;
            cbtn_cancelPassword.Click += cbtn_cancelPassword_Click;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label20.Location = new Point(25, 214);
            label20.Name = "label20";
            label20.Size = new Size(112, 20);
            label20.TabIndex = 18;
            label20.Text = "New Password";
            // 
            // cbtn_savePassword
            // 
            cbtn_savePassword.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_savePassword.BorderColor = Color.Black;
            cbtn_savePassword.BorderRadius = 8;
            cbtn_savePassword.BorderSize = 0;
            cbtn_savePassword.Cursor = Cursors.Hand;
            cbtn_savePassword.FlatAppearance.BorderSize = 0;
            cbtn_savePassword.FlatStyle = FlatStyle.Flat;
            cbtn_savePassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_savePassword.ForeColor = Color.White;
            cbtn_savePassword.Location = new Point(38, 496);
            cbtn_savePassword.Name = "cbtn_savePassword";
            cbtn_savePassword.Size = new Size(177, 50);
            cbtn_savePassword.TabIndex = 34;
            cbtn_savePassword.Text = "Save";
            cbtn_savePassword.UseVisualStyleBackColor = false;
            cbtn_savePassword.Click += cbtn_savePassword_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label18.Location = new Point(29, 324);
            label18.Name = "label18";
            label18.Size = new Size(137, 20);
            label18.TabIndex = 19;
            label18.Text = "Confirm Password";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label19.Location = new Point(25, 104);
            label19.Name = "label19";
            label19.Size = new Size(133, 20);
            label19.TabIndex = 20;
            label19.Text = "Current Password";
            // 
            // EmployeeProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(cbtn_updateProfileImage);
            Controls.Add(pb_profileImage);
            Controls.Add(pnl_editInfo);
            Controls.Add(pnl_changePassword);
            Controls.Add(pnl_showInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeProfileForm";
            Text = "EmployeeProfileForm";
            Load += EmployeeProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)pb_profileImage).EndInit();
            pnl_editInfo.ResumeLayout(false);
            pnl_editInfo.PerformLayout();
            pnl_showInfo.ResumeLayout(false);
            pnl_showInfo.PerformLayout();
            pnl_changePassword.ResumeLayout(false);
            pnl_changePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_back;
        private CustomControls.CustomComboBox ccb_gender;
        private CustomControls.CustomTextBox ctxt_address;
        private CustomControls.CustomTextBox ctxt_phone;
        private CustomControls.CustomTextBox ctxt_email;
        private Label label4;
        private CustomControls.CustomTextBox ctxt_name;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label1;
        private CustomControls.CustomButton cbtn_save;
        private CustomControls.CustomButton cbtn_updateProfileImage;
        private PictureBox pb_profileImage;
        private Panel pnl_editInfo;
        private CustomControls.CustomButton cbtn_editCancel;
        private Panel pnl_showInfo;
        private Label label12;
        private Label lbl_name;
        private CustomControls.CustomButton cbtn_changePassword;
        private CustomControls.CustomButton cbtn_editProfile;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label lbl_address;
        private Label lbl_gender;
        private Label lbl_phone;
        private Label lbl_email;
        private Panel pnl_changePassword;
        private Label label18;
        private Label label19;
        private Label label20;
        private CustomControls.CustomButton cbtn_cancelPassword;
        private CustomControls.CustomButton cbtn_savePassword;
        private CustomControls.CustomTextBox ctxt_currentPassword;
        private CustomControls.CustomTextBox ctxt_newPassword;
        private CustomControls.CustomTextBox ctxt_confirmPassword;
        private Button btn_showCurrent;
        private Button btn_showNew;
        private Button btn_showConfirm;
    }
}