namespace AttendEase.Presentation
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            pictureBox1 = new PictureBox();
            txt_password = new TextBox();
            panel5 = new Panel();
            panel2 = new Panel();
            pb_showPassword = new PictureBox();
            lbl_showPassword = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            txt_email = new TextBox();
            btn_signIn = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            btn_setPassword = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_signIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_setPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 803);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // txt_password
            // 
            txt_password.BorderStyle = BorderStyle.None;
            txt_password.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.FromArgb(38, 32, 59);
            txt_password.Location = new Point(14, 11);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(327, 24);
            txt_password.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txt_password);
            panel5.Location = new Point(1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(355, 46);
            panel5.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(pb_showPassword);
            panel2.Controls.Add(lbl_showPassword);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btn_signIn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_setPassword);
            panel2.Location = new Point(634, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 853);
            panel2.TabIndex = 4;
            // 
            // pb_showPassword
            // 
            pb_showPassword.Cursor = Cursors.Hand;
            pb_showPassword.Image = Properties.Resources.Eye;
            pb_showPassword.Location = new Point(397, 430);
            pb_showPassword.Name = "pb_showPassword";
            pb_showPassword.Size = new Size(18, 15);
            pb_showPassword.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_showPassword.TabIndex = 13;
            pb_showPassword.TabStop = false;
            // 
            // lbl_showPassword
            // 
            lbl_showPassword.AutoSize = true;
            lbl_showPassword.Cursor = Cursors.Hand;
            lbl_showPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPassword.ForeColor = Color.FromArgb(38, 32, 59);
            lbl_showPassword.Location = new Point(415, 427);
            lbl_showPassword.Name = "lbl_showPassword";
            lbl_showPassword.Size = new Size(47, 20);
            lbl_showPassword.TabIndex = 2;
            lbl_showPassword.Text = "Show";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(181, 191, 249);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(105, 451);
            panel4.Name = "panel4";
            panel4.Size = new Size(357, 48);
            panel4.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(38, 32, 59);
            label1.Location = new Point(105, 157);
            label1.Name = "label1";
            label1.Size = new Size(164, 38);
            label1.TabIndex = 3;
            label1.Text = "AttendEase";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(181, 191, 249);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(105, 347);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 48);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(txt_email);
            panel3.Location = new Point(1, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 46);
            panel3.TabIndex = 10;
            // 
            // txt_email
            // 
            txt_email.BorderStyle = BorderStyle.None;
            txt_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.ForeColor = Color.FromArgb(38, 32, 59);
            txt_email.Location = new Point(14, 11);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(327, 24);
            txt_email.TabIndex = 8;
            // 
            // btn_signIn
            // 
            btn_signIn.Cursor = Cursors.Hand;
            btn_signIn.Image = (Image)resources.GetObject("btn_signIn.Image");
            btn_signIn.Location = new Point(105, 556);
            btn_signIn.Name = "btn_signIn";
            btn_signIn.Size = new Size(357, 48);
            btn_signIn.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_signIn.TabIndex = 7;
            btn_signIn.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.FromArgb(38, 32, 59);
            label2.Location = new Point(101, 316);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.FromArgb(38, 32, 59);
            label3.Location = new Point(101, 420);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // btn_setPassword
            // 
            btn_setPassword.Cursor = Cursors.Hand;
            btn_setPassword.Image = (Image)resources.GetObject("btn_setPassword.Image");
            btn_setPassword.Location = new Point(105, 239);
            btn_setPassword.Name = "btn_setPassword";
            btn_setPassword.Size = new Size(358, 48);
            btn_setPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_setPassword.TabIndex = 2;
            btn_setPassword.TabStop = false;
            btn_setPassword.Click += btn_setPassword_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 853);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name = "SignInForm";
            Text = "SignInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_signIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_setPassword).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txt_password;
        private Panel panel5;
        private Panel panel2;
        private PictureBox pb_showPassword;
        private Label lbl_showPassword;
        private Panel panel4;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private TextBox txt_email;
        private PictureBox btn_signIn;
        private Label label2;
        private Label label3;
        private PictureBox btn_setPassword;
    }
}