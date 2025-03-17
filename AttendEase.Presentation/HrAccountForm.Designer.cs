namespace AttendEase.Presentation
{
    partial class HrAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrAccountForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            picEye1 = new PictureBox();
            btn_show1 = new Label();
            txt_phone = new CustomControls.CustomTextBox();
            txt_email = new CustomControls.CustomTextBox();
            txt_name = new CustomControls.CustomTextBox();
            txt_pass = new CustomControls.CustomTextBox();
            txt_confirm = new CustomControls.CustomTextBox();
            btn_updateProfile = new Button();
            btn_uploadImg = new Button();
            pic_hr = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picEye1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_hr).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(picEye1);
            panel1.Controls.Add(btn_show1);
            panel1.Controls.Add(txt_phone);
            panel1.Controls.Add(txt_email);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_pass);
            panel1.Controls.Add(txt_confirm);
            panel1.Controls.Add(btn_updateProfile);
            panel1.Controls.Add(btn_uploadImg);
            panel1.Controls.Add(pic_hr);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(93, 114, 133);
            panel1.Location = new Point(3, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 622);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Eye;
            pictureBox1.Location = new Point(357, 262);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(12, 9);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 57;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(38, 32, 59);
            label6.Location = new Point(370, 260);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 56;
            label6.Text = "Show";
            // 
            // picEye1
            // 
            picEye1.Cursor = Cursors.Hand;
            picEye1.Image = Properties.Resources.Eye;
            picEye1.Location = new Point(357, 325);
            picEye1.Margin = new Padding(2);
            picEye1.Name = "picEye1";
            picEye1.Size = new Size(12, 9);
            picEye1.SizeMode = PictureBoxSizeMode.StretchImage;
            picEye1.TabIndex = 55;
            picEye1.TabStop = false;
            // 
            // btn_show1
            // 
            btn_show1.AutoSize = true;
            btn_show1.Cursor = Cursors.Hand;
            btn_show1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_show1.ForeColor = Color.FromArgb(38, 32, 59);
            btn_show1.Location = new Point(370, 322);
            btn_show1.Margin = new Padding(2, 0, 2, 0);
            btn_show1.Name = "btn_show1";
            btn_show1.Size = new Size(38, 15);
            btn_show1.TabIndex = 54;
            btn_show1.Text = "Show";
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.White;
            txt_phone.BorderColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_phone.BorderSize = 1;
            txt_phone.Font = new Font("Segoe UI", 11F);
            txt_phone.ForeColor = Color.FromArgb(38, 32, 59);
            txt_phone.Location = new Point(102, 402);
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
            txt_email.Location = new Point(102, 153);
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
            txt_name.Location = new Point(102, 215);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Multiline = false;
            txt_name.Name = "txt_name";
            txt_name.Padding = new Padding(11, 10, 11, 10);
            txt_name.PasswordChar = false;
            txt_name.Size = new Size(310, 41);
            txt_name.TabIndex = 28;
            txt_name.UnderlinedStyle = false;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.White;
            txt_pass.BorderColor = Color.FromArgb(181, 191, 249);
            txt_pass.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_pass.BorderSize = 1;
            txt_pass.Font = new Font("Segoe UI", 11F);
            txt_pass.ForeColor = Color.FromArgb(38, 32, 59);
            txt_pass.Location = new Point(102, 278);
            txt_pass.Margin = new Padding(3, 2, 3, 2);
            txt_pass.Multiline = false;
            txt_pass.Name = "txt_pass";
            txt_pass.Padding = new Padding(11, 10, 11, 10);
            txt_pass.PasswordChar = false;
            txt_pass.Size = new Size(310, 41);
            txt_pass.TabIndex = 27;
            txt_pass.UnderlinedStyle = false;
            // 
            // txt_confirm
            // 
            txt_confirm.BackColor = Color.White;
            txt_confirm.BorderColor = Color.FromArgb(181, 191, 249);
            txt_confirm.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_confirm.BorderSize = 1;
            txt_confirm.Font = new Font("Segoe UI", 11F);
            txt_confirm.ForeColor = Color.FromArgb(38, 32, 59);
            txt_confirm.Location = new Point(102, 340);
            txt_confirm.Margin = new Padding(3, 2, 3, 2);
            txt_confirm.Multiline = false;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Padding = new Padding(11, 10, 11, 10);
            txt_confirm.PasswordChar = false;
            txt_confirm.Size = new Size(310, 41);
            txt_confirm.TabIndex = 26;
            txt_confirm.UnderlinedStyle = false;
            // 
            // btn_updateProfile
            // 
            btn_updateProfile.BackColor = Color.FromArgb(243, 248, 252);
            btn_updateProfile.FlatAppearance.BorderSize = 2;
            btn_updateProfile.FlatStyle = FlatStyle.Flat;
            btn_updateProfile.Font = new Font("Segoe UI", 12F);
            btn_updateProfile.ForeColor = Color.FromArgb(0, 126, 249);
            btn_updateProfile.Location = new Point(261, 495);
            btn_updateProfile.Margin = new Padding(4, 3, 4, 3);
            btn_updateProfile.Name = "btn_updateProfile";
            btn_updateProfile.Size = new Size(340, 35);
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
            btn_uploadImg.Location = new Point(491, 364);
            btn_uploadImg.Margin = new Padding(4, 3, 4, 3);
            btn_uploadImg.Name = "btn_uploadImg";
            btn_uploadImg.Size = new Size(244, 40);
            btn_uploadImg.TabIndex = 24;
            btn_uploadImg.Text = "Upload Photo";
            btn_uploadImg.UseVisualStyleBackColor = false;
            btn_uploadImg.Click += btn_uploadImg_Click;
            // 
            // pic_hr
            // 
            pic_hr.Image = (Image)resources.GetObject("pic_hr.Image");
            pic_hr.Location = new Point(516, 193);
            pic_hr.Margin = new Padding(4, 3, 4, 3);
            pic_hr.Name = "pic_hr";
            pic_hr.Size = new Size(184, 155);
            pic_hr.SizeMode = PictureBoxSizeMode.Zoom;
            pic_hr.TabIndex = 23;
            pic_hr.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.ForeColor = Color.FromArgb(93, 114, 133);
            label5.Location = new Point(102, 381);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 19;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.FromArgb(93, 114, 133);
            label4.Location = new Point(102, 319);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 20);
            label4.TabIndex = 18;
            label4.Text = "Confirm Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.ForeColor = Color.FromArgb(93, 114, 133);
            label3.Location = new Point(102, 256);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 17;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.FromArgb(93, 114, 133);
            label2.Location = new Point(102, 194);
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
            label1.Location = new Point(102, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 13;
            label1.Text = "Email";
            // 
            // HrAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1122, 591);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "HrAccountForm";
            Text = "HrAccountForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picEye1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_hr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_updateProfile;
        private Button btn_uploadImg;
        private PictureBox pic_hr;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CustomControls.CustomTextBox txt_email;
        private CustomControls.CustomTextBox txt_name;
        private CustomControls.CustomTextBox txt_pass;
        private CustomControls.CustomTextBox txt_confirm;
        private CustomControls.CustomTextBox txt_phone;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox picEye1;
        private Label btn_show1;
    }
}