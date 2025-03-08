namespace AttendEase.Presentation
{
    partial class SetPassword
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPassword));
            btn_signIn = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_email = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pb_showConfirm = new PictureBox();
            lbl_showConfirm = new Label();
            pb_showPassword = new PictureBox();
            lbl_showPassword = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            txt_confirm = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            txt_password = new TextBox();
            btn_setPassword = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_signIn).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showConfirm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).BeginInit();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_setPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_signIn
            // 
            btn_signIn.Cursor = Cursors.Hand;
            btn_signIn.Image = (Image)resources.GetObject("btn_signIn.Image");
            btn_signIn.Location = new Point(105, 239);
            btn_signIn.Name = "btn_signIn";
            btn_signIn.Size = new Size(358, 48);
            btn_signIn.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_signIn.TabIndex = 2;
            btn_signIn.TabStop = false;
            btn_signIn.Click += btn_signIn_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.FromArgb(38, 32, 59);
            label4.Location = new Point(101, 525);
            label4.Name = "label4";
            label4.Size = new Size(168, 28);
            label4.TabIndex = 6;
            label4.Text = "Confirm Password";
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
            // panel2
            // 
            panel2.Controls.Add(pb_showConfirm);
            panel2.Controls.Add(lbl_showConfirm);
            panel2.Controls.Add(pb_showPassword);
            panel2.Controls.Add(lbl_showPassword);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btn_setPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_signIn);
            panel2.Location = new Point(650, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 853);
            panel2.TabIndex = 0;
            // 
            // pb_showConfirm
            // 
            pb_showConfirm.Cursor = Cursors.Hand;
            pb_showConfirm.Image = Properties.Resources.Eye;
            pb_showConfirm.Location = new Point(397, 535);
            pb_showConfirm.Name = "pb_showConfirm";
            pb_showConfirm.Size = new Size(18, 15);
            pb_showConfirm.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_showConfirm.TabIndex = 15;
            pb_showConfirm.TabStop = false;
            // 
            // lbl_showConfirm
            // 
            lbl_showConfirm.AutoSize = true;
            lbl_showConfirm.Cursor = Cursors.Hand;
            lbl_showConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showConfirm.ForeColor = Color.FromArgb(38, 32, 59);
            lbl_showConfirm.Location = new Point(415, 532);
            lbl_showConfirm.Name = "lbl_showConfirm";
            lbl_showConfirm.Size = new Size(47, 20);
            lbl_showConfirm.TabIndex = 14;
            lbl_showConfirm.Text = "Show";
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
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(181, 191, 249);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(105, 556);
            panel6.Name = "panel6";
            panel6.Size = new Size(357, 48);
            panel6.TabIndex = 12;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(txt_confirm);
            panel7.Location = new Point(1, 1);
            panel7.Name = "panel7";
            panel7.Size = new Size(355, 46);
            panel7.TabIndex = 10;
            // 
            // txt_confirm
            // 
            txt_confirm.BorderStyle = BorderStyle.None;
            txt_confirm.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confirm.ForeColor = Color.FromArgb(38, 32, 59);
            txt_confirm.Location = new Point(14, 11);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.PasswordChar = '*';
            txt_confirm.Size = new Size(327, 24);
            txt_confirm.TabIndex = 8;
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
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(txt_password);
            panel5.Location = new Point(1, 1);
            panel5.Name = "panel5";
            panel5.Size = new Size(355, 46);
            panel5.TabIndex = 10;
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
            // btn_setPassword
            // 
            btn_setPassword.Cursor = Cursors.Hand;
            btn_setPassword.Image = (Image)resources.GetObject("btn_setPassword.Image");
            btn_setPassword.Location = new Point(105, 662);
            btn_setPassword.Name = "btn_setPassword";
            btn_setPassword.Size = new Size(357, 48);
            btn_setPassword.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_setPassword.TabIndex = 7;
            btn_setPassword.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 803);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // SetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1282, 853);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Name = "SetPassword";
            Text = "Form1";
            Load += SetPassword_Load;
            ((System.ComponentModel.ISupportInitialize)btn_signIn).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_showConfirm).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_showPassword).EndInit();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_setPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btn_signIn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_email;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox btn_setPassword;
        private Panel panel4;
        private Panel panel5;
        private TextBox txt_password;
        private Panel panel6;
        private Panel panel7;
        private TextBox txt_confirm;
        private Label lbl_showPassword;
        private PictureBox pb_showPassword;
        private PictureBox pb_showConfirm;
        private Label lbl_showConfirm;
        private PictureBox pictureBox1;
    }
}
