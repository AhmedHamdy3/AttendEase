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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            ctxt_confirm = new CustomControls.CustomTextBox();
            ctxt_password = new CustomControls.CustomTextBox();
            ctxt_email = new CustomControls.CustomTextBox();
            lbl_confirmError = new Label();
            lbl_passwordError = new Label();
            btn_showConfirm = new Button();
            btn_showPassword = new Button();
            panel8 = new Panel();
            csb_singIn = new CustomControls.CustomButton();
            customButton1 = new CustomControls.CustomButton();
            csb_setPassword = new CustomControls.CustomButton();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            // panel2
            // 
            panel2.Controls.Add(ctxt_confirm);
            panel2.Controls.Add(ctxt_password);
            panel2.Controls.Add(ctxt_email);
            panel2.Controls.Add(lbl_confirmError);
            panel2.Controls.Add(lbl_passwordError);
            panel2.Controls.Add(btn_showConfirm);
            panel2.Controls.Add(btn_showPassword);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(csb_setPassword);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(650, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(633, 853);
            panel2.TabIndex = 0;
            // 
            // ctxt_confirm
            // 
            ctxt_confirm.BackColor = Color.White;
            ctxt_confirm.BorderColor = Color.FromArgb(181, 191, 249);
            ctxt_confirm.BorderFocusColor = Color.FromArgb(181, 191, 249);
            ctxt_confirm.BorderSize = 1;
            ctxt_confirm.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_confirm.Location = new Point(105, 556);
            ctxt_confirm.Multiline = false;
            ctxt_confirm.Name = "ctxt_confirm";
            ctxt_confirm.Padding = new Padding(13);
            ctxt_confirm.PasswordChar = true;
            ctxt_confirm.Size = new Size(357, 47);
            ctxt_confirm.TabIndex = 24;
            ctxt_confirm.UnderlinedStyle = false;
            ctxt_confirm._TextChanged += ctxt_confirm__TextChanged;
            // 
            // ctxt_password
            // 
            ctxt_password.BackColor = Color.White;
            ctxt_password.BorderColor = Color.FromArgb(181, 191, 249);
            ctxt_password.BorderFocusColor = Color.FromArgb(181, 191, 249);
            ctxt_password.BorderSize = 1;
            ctxt_password.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_password.Location = new Point(105, 451);
            ctxt_password.Multiline = false;
            ctxt_password.Name = "ctxt_password";
            ctxt_password.Padding = new Padding(13);
            ctxt_password.PasswordChar = true;
            ctxt_password.Size = new Size(357, 47);
            ctxt_password.TabIndex = 23;
            ctxt_password.UnderlinedStyle = false;
            ctxt_password._TextChanged += ctxt_password__TextChanged;
            // 
            // ctxt_email
            // 
            ctxt_email.BackColor = Color.White;
            ctxt_email.BorderColor = Color.FromArgb(181, 191, 249);
            ctxt_email.BorderFocusColor = Color.FromArgb(181, 191, 249);
            ctxt_email.BorderSize = 1;
            ctxt_email.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_email.Location = new Point(105, 347);
            ctxt_email.Multiline = false;
            ctxt_email.Name = "ctxt_email";
            ctxt_email.Padding = new Padding(13);
            ctxt_email.PasswordChar = false;
            ctxt_email.Size = new Size(357, 47);
            ctxt_email.TabIndex = 22;
            ctxt_email.UnderlinedStyle = false;
            // 
            // lbl_confirmError
            // 
            lbl_confirmError.AutoSize = true;
            lbl_confirmError.BackColor = Color.Transparent;
            lbl_confirmError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_confirmError.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_confirmError.Location = new Point(103, 604);
            lbl_confirmError.Name = "lbl_confirmError";
            lbl_confirmError.Size = new Size(0, 17);
            lbl_confirmError.TabIndex = 21;
            // 
            // lbl_passwordError
            // 
            lbl_passwordError.AutoSize = true;
            lbl_passwordError.BackColor = Color.Transparent;
            lbl_passwordError.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passwordError.ForeColor = Color.FromArgb(192, 0, 0);
            lbl_passwordError.Location = new Point(103, 499);
            lbl_passwordError.Name = "lbl_passwordError";
            lbl_passwordError.Size = new Size(0, 17);
            lbl_passwordError.TabIndex = 20;
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
            btn_showConfirm.Location = new Point(393, 527);
            btn_showConfirm.Name = "btn_showConfirm";
            btn_showConfirm.Size = new Size(76, 29);
            btn_showConfirm.TabIndex = 19;
            btn_showConfirm.Text = "     Show";
            btn_showConfirm.TextAlign = ContentAlignment.MiddleLeft;
            btn_showConfirm.UseVisualStyleBackColor = false;
            btn_showConfirm.Click += btn_showConfirm_Click;
            // 
            // btn_showPassword
            // 
            btn_showPassword.BackColor = Color.Transparent;
            btn_showPassword.Cursor = Cursors.Hand;
            btn_showPassword.FlatAppearance.BorderSize = 0;
            btn_showPassword.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_showPassword.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_showPassword.FlatStyle = FlatStyle.Flat;
            btn_showPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_showPassword.ForeColor = Color.FromArgb(38, 32, 59);
            btn_showPassword.Image = Properties.Resources.Eye1;
            btn_showPassword.ImageAlign = ContentAlignment.MiddleLeft;
            btn_showPassword.Location = new Point(393, 422);
            btn_showPassword.Name = "btn_showPassword";
            btn_showPassword.Size = new Size(76, 29);
            btn_showPassword.TabIndex = 18;
            btn_showPassword.Text = "     Show";
            btn_showPassword.TextAlign = ContentAlignment.MiddleLeft;
            btn_showPassword.UseVisualStyleBackColor = false;
            btn_showPassword.Click += btn_showPassword_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(236, 240, 255);
            panel8.Controls.Add(csb_singIn);
            panel8.Controls.Add(customButton1);
            panel8.Location = new Point(105, 239);
            panel8.Name = "panel8";
            panel8.Size = new Size(358, 48);
            panel8.TabIndex = 17;
            // 
            // csb_singIn
            // 
            csb_singIn.BackColor = Color.FromArgb(236, 240, 255);
            csb_singIn.BorderColor = Color.Black;
            csb_singIn.BorderRadius = 7;
            csb_singIn.BorderSize = 0;
            csb_singIn.Cursor = Cursors.Hand;
            csb_singIn.FlatAppearance.BorderSize = 0;
            csb_singIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(210, 219, 253);
            csb_singIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 219, 253);
            csb_singIn.FlatStyle = FlatStyle.Flat;
            csb_singIn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            csb_singIn.ForeColor = Color.FromArgb(156, 154, 165);
            csb_singIn.Location = new Point(179, 2);
            csb_singIn.Name = "csb_singIn";
            csb_singIn.Size = new Size(174, 43);
            csb_singIn.TabIndex = 19;
            csb_singIn.Text = "Sign In";
            csb_singIn.UseVisualStyleBackColor = false;
            csb_singIn.Click += csb_singIn_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(70, 95, 241);
            customButton1.BorderColor = Color.Black;
            customButton1.BorderRadius = 7;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, 95, 241);
            customButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 95, 241);
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(3, 2);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(174, 43);
            customButton1.TabIndex = 18;
            customButton1.Text = "Set Password";
            customButton1.UseVisualStyleBackColor = false;
            // 
            // csb_setPassword
            // 
            csb_setPassword.BackColor = Color.FromArgb(70, 95, 241);
            csb_setPassword.BorderColor = Color.Black;
            csb_setPassword.BorderRadius = 10;
            csb_setPassword.BorderSize = 0;
            csb_setPassword.Cursor = Cursors.Hand;
            csb_setPassword.FlatAppearance.BorderSize = 0;
            csb_setPassword.FlatStyle = FlatStyle.Flat;
            csb_setPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            csb_setPassword.ForeColor = Color.White;
            csb_setPassword.Location = new Point(105, 662);
            csb_setPassword.Name = "csb_setPassword";
            csb_setPassword.Size = new Size(362, 50);
            csb_setPassword.TabIndex = 16;
            csb_setPassword.Text = "Set Password";
            csb_setPassword.UseVisualStyleBackColor = false;
            csb_setPassword.Click += csb_setPassword_Click;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Set Password";
            Load += SetPassword_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private PictureBox pictureBox1;
        private CustomControls.CustomButton csb_setPassword;
        private CustomControls.CustomButton customButton1;
        private Panel panel8;
        private CustomControls.CustomButton csb_singIn;
        private Button btn_showPassword;
        private Button btn_showConfirm;
        private Label lbl_confirmError;
        private Label lbl_passwordError;
        private CustomControls.CustomTextBox ctxt_confirm;
        private CustomControls.CustomTextBox ctxt_password;
        private CustomControls.CustomTextBox ctxt_email;
    }
}
