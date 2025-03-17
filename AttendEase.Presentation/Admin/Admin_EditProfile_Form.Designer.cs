namespace AttendEase.Presentation.Admin
{
    partial class Admin_EditProfile_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_EditProfile_Form));
            txt_phone = new CustomControls.CustomTextBox();
            txt_email = new CustomControls.CustomTextBox();
            txt_name = new CustomControls.CustomTextBox();
            btn_updateProfile = new Button();
            btn_uploadImg = new Button();
            pic_admin = new PictureBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btn_changePassword = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_admin).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.White;
            txt_phone.BorderColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderSize = 1;
            txt_phone.Font = new Font("Segoe UI", 11F);
            txt_phone.ForeColor = Color.FromArgb(38, 32, 59);
            txt_phone.Location = new Point(102, 281);
            txt_phone.Margin = new Padding(3, 2, 3, 2);
            txt_phone.Multiline = false;
            txt_phone.Name = "txt_phone";
            txt_phone.Padding = new Padding(11, 10, 11, 10);
            txt_phone.PasswordChar = false;
            txt_phone.Size = new Size(310, 41);
            txt_phone.TabIndex = 30;
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
            txt_email.Location = new Point(105, 106);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Multiline = false;
            txt_email.Name = "txt_email";
            txt_email.Padding = new Padding(11, 10, 11, 10);
            txt_email.PasswordChar = false;
            txt_email.Size = new Size(310, 41);
            txt_email.TabIndex = 29;
            txt_email.UnderlinedStyle = false;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.White;
            txt_name.BorderColor = Color.FromArgb(181, 191, 249);
            txt_name.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_name.BorderSize = 1;
            txt_name.Font = new Font("Segoe UI", 11F);
            txt_name.ForeColor = Color.FromArgb(38, 32, 59);
            txt_name.Location = new Point(102, 194);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Multiline = false;
            txt_name.Name = "txt_name";
            txt_name.Padding = new Padding(11, 10, 11, 10);
            txt_name.PasswordChar = false;
            txt_name.Size = new Size(310, 41);
            txt_name.TabIndex = 28;
            txt_name.UnderlinedStyle = false;
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.BackColor = Color.FromArgb(243, 248, 252);
            btn_updateProfile.FlatAppearance.BorderSize = 2;
            btn_updateProfile.FlatStyle = FlatStyle.Flat;
            btn_updateProfile.Font = new Font("Segoe UI", 12F);
            btn_updateProfile.ForeColor = Color.FromArgb(0, 126, 249);
            btn_updateProfile.Location = new Point(102, 420);
            btn_updateProfile.Margin = new Padding(4, 3, 4, 3);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(174, 38);
            btn_updateProfile.TabIndex = 25;
            btn_updateProfile.Text = "Update Profile";
            btn_updateProfile.UseVisualStyleBackColor = false;
            btn_updateProfile.Click += btn_updateProfile_Click;
            // 
            // btn_uploadImg
            // 
            btn_uploadImg.BackColor = Color.FromArgb(243, 248, 252);
            btn_uploadImg.FlatAppearance.BorderSize = 2;
            btn_uploadImg.FlatStyle = FlatStyle.Flat;
            btn_uploadImg.Font = new Font("Segoe UI", 12F);
            btn_uploadImg.ForeColor = Color.FromArgb(0, 126, 249);
            btn_uploadImg.Location = new Point(476, 277);
            btn_uploadImg.Margin = new Padding(4, 3, 4, 3);
            btn_uploadImg.Name = "btn_uploadImg";
            btn_uploadImg.Size = new Size(244, 40);
            btn_uploadImg.TabIndex = 24;
            btn_uploadImg.Text = "Upload Photo";
            btn_uploadImg.UseVisualStyleBackColor = false;
            btn_uploadImg.Click += btn_uploadImg_Click;
            // 
            // pic_admin
            // 
            pic_admin.Image = (Image)resources.GetObject("pic_admin.Image");
            pic_admin.Location = new Point(501, 106);
            pic_admin.Margin = new Padding(4, 3, 4, 3);
            pic_admin.Name = "pic_admin";
            pic_admin.Size = new Size(184, 155);
            pic_admin.SizeMode = PictureBoxSizeMode.Zoom;
            pic_admin.TabIndex = 23;
            pic_admin.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.FromArgb(93, 114, 133);
            label5.Location = new Point(102, 260);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 19;
            label5.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.FromArgb(93, 114, 133);
            label2.Location = new Point(102, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 14;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F);
            label1.ForeColor = Color.FromArgb(93, 114, 133);
            label1.Location = new Point(105, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_changePassword);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(btn_updateProfile);
            panel1.Controls.Add(btn_uploadImg);
            panel1.Controls.Add(pic_admin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(93, 114, 133);
            panel1.Location = new Point(-1, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 576);
            panel1.TabIndex = 1;
            // 
            // btn_changePassword
            // 
            btn_changePassword.BackColor = Color.FromArgb(243, 248, 252);
            btn_changePassword.FlatAppearance.BorderSize = 2;
            btn_changePassword.FlatStyle = FlatStyle.Flat;
            btn_changePassword.Font = new Font("Segoe UI", 12F);
            btn_changePassword.ForeColor = Color.FromArgb(0, 126, 249);
            btn_changePassword.Location = new Point(336, 420);
            btn_changePassword.Margin = new Padding(4, 3, 4, 3);
            btn_changePassword.Name = "btn_changePassword";
            btn_changePassword.Size = new Size(174, 38);
            btn_changePassword.TabIndex = 58;
            btn_changePassword.Text = "Change Password";
            btn_changePassword.UseVisualStyleBackColor = false;
            btn_changePassword.Click += btn_changePassword_Click;
            // 
            // Admin_EditProfile_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1106, 564);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_EditProfile_Form";
            Text = "Admin_EditProfile_Form";
            Load += Admin_EditProfile_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pic_admin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CustomControls.CustomTextBox txt_phone;
        private CustomControls.CustomTextBox txt_email;
        private CustomControls.CustomTextBox txt_name;
        private Button btn_updateProfile;
        private Button btn_uploadImg;
        private PictureBox pic_admin;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button btn_changePassword;
    }
}