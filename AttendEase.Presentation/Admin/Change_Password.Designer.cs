namespace AttendEase.Presentation.Admin
{
    partial class Change_Password
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
            pic_eyeCurrentPass = new Panel();
            pictureBox1 = new PictureBox();
            show_currentPass = new Label();
            btn_cancle = new Button();
            pic_eyePass = new PictureBox();
            show_pass = new Label();
            pic_eyeConfirm = new PictureBox();
            show_confirm = new Label();
            txt_currentPass = new CustomControls.CustomTextBox();
            txt_pass = new CustomControls.CustomTextBox();
            txt_confirm = new CustomControls.CustomTextBox();
            btn_resetPass = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pic_eyeCurrentPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_eyePass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_eyeConfirm).BeginInit();
            SuspendLayout();
            // 
            // pic_eyeCurrentPass
            // 
            pic_eyeCurrentPass.Controls.Add(pictureBox1);
            pic_eyeCurrentPass.Controls.Add(show_currentPass);
            pic_eyeCurrentPass.Controls.Add(btn_cancle);
            pic_eyeCurrentPass.Controls.Add(pic_eyePass);
            pic_eyeCurrentPass.Controls.Add(show_pass);
            pic_eyeCurrentPass.Controls.Add(pic_eyeConfirm);
            pic_eyeCurrentPass.Controls.Add(show_confirm);
            pic_eyeCurrentPass.Controls.Add(txt_currentPass);
            pic_eyeCurrentPass.Controls.Add(txt_pass);
            pic_eyeCurrentPass.Controls.Add(txt_confirm);
            pic_eyeCurrentPass.Controls.Add(btn_resetPass);
            pic_eyeCurrentPass.Controls.Add(label4);
            pic_eyeCurrentPass.Controls.Add(label3);
            pic_eyeCurrentPass.Controls.Add(label2);
            pic_eyeCurrentPass.ForeColor = Color.FromArgb(93, 114, 133);
            pic_eyeCurrentPass.Location = new Point(40, 11);
            pic_eyeCurrentPass.Margin = new Padding(3, 2, 3, 2);
            pic_eyeCurrentPass.Name = "pic_eyeCurrentPass";
            pic_eyeCurrentPass.Size = new Size(715, 478);
            pic_eyeCurrentPass.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Eye;
            pictureBox1.Location = new Point(357, 151);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(12, 9);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 60;
            pictureBox1.TabStop = false;
            // 
            // show_currentPass
            // 
            show_currentPass.AutoSize = true;
            show_currentPass.Cursor = Cursors.Hand;
            show_currentPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            show_currentPass.ForeColor = Color.FromArgb(38, 32, 59);
            show_currentPass.Location = new Point(370, 149);
            show_currentPass.Margin = new Padding(2, 0, 2, 0);
            show_currentPass.Name = "show_currentPass";
            show_currentPass.Size = new Size(38, 15);
            show_currentPass.TabIndex = 59;
            show_currentPass.Text = "Show";
            show_currentPass.Click += show_currentPass_Click;
            // 
            // btn_cancle
            // 
            btn_cancle.BackColor = Color.FromArgb(243, 248, 252);
            btn_cancle.FlatAppearance.BorderSize = 2;
            btn_cancle.FlatStyle = FlatStyle.Flat;
            btn_cancle.Font = new Font("Segoe UI", 12F);
            btn_cancle.ForeColor = Color.FromArgb(0, 126, 249);
            btn_cancle.Location = new Point(326, 343);
            btn_cancle.Margin = new Padding(4, 3, 4, 3);
            btn_cancle.Name = "btn_cancle";
            btn_cancle.Size = new Size(174, 38);
            btn_cancle.TabIndex = 58;
            btn_cancle.Text = "Cancle";
            btn_cancle.UseVisualStyleBackColor = false;
            btn_cancle.Click += btn_cancle_Click;
            // 
            // pic_eyePass
            // 
            pic_eyePass.Cursor = Cursors.Hand;
            pic_eyePass.Image = Properties.Resources.Eye;
            pic_eyePass.Location = new Point(357, 212);
            pic_eyePass.Margin = new Padding(2);
            pic_eyePass.Name = "pic_eyePass";
            pic_eyePass.Size = new Size(12, 9);
            pic_eyePass.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_eyePass.TabIndex = 57;
            pic_eyePass.TabStop = false;
            // 
            // show_pass
            // 
            show_pass.AutoSize = true;
            show_pass.Cursor = Cursors.Hand;
            show_pass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            show_pass.ForeColor = Color.FromArgb(38, 32, 59);
            show_pass.Location = new Point(370, 210);
            show_pass.Margin = new Padding(2, 0, 2, 0);
            show_pass.Name = "show_pass";
            show_pass.Size = new Size(38, 15);
            show_pass.TabIndex = 56;
            show_pass.Text = "Show";
            // 
            // pic_eyeConfirm
            // 
            pic_eyeConfirm.Cursor = Cursors.Hand;
            pic_eyeConfirm.Image = Properties.Resources.Eye;
            pic_eyeConfirm.Location = new Point(357, 275);
            pic_eyeConfirm.Margin = new Padding(2);
            pic_eyeConfirm.Name = "pic_eyeConfirm";
            pic_eyeConfirm.Size = new Size(12, 9);
            pic_eyeConfirm.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_eyeConfirm.TabIndex = 55;
            pic_eyeConfirm.TabStop = false;
            // 
            // show_confirm
            // 
            show_confirm.AutoSize = true;
            show_confirm.Cursor = Cursors.Hand;
            show_confirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            show_confirm.ForeColor = Color.FromArgb(38, 32, 59);
            show_confirm.Location = new Point(370, 272);
            show_confirm.Margin = new Padding(2, 0, 2, 0);
            show_confirm.Name = "show_confirm";
            show_confirm.Size = new Size(38, 15);
            show_confirm.TabIndex = 54;
            show_confirm.Text = "Show";
            // 
            // txt_currentPass
            // 
            txt_currentPass.BackColor = Color.White;
            txt_currentPass.BorderColor = Color.FromArgb(181, 191, 249);
            txt_currentPass.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_currentPass.BorderSize = 1;
            txt_currentPass.Font = new Font("Segoe UI", 11F);
            txt_currentPass.ForeColor = Color.FromArgb(38, 32, 59);
            txt_currentPass.Location = new Point(102, 103);
            txt_currentPass.Margin = new Padding(3, 2, 3, 2);
            txt_currentPass.Multiline = false;
            txt_currentPass.Name = "txt_currentPass";
            txt_currentPass.Padding = new Padding(11, 10, 11, 10);
            txt_currentPass.PasswordChar = true;
            txt_currentPass.Size = new Size(310, 41);
            txt_currentPass.TabIndex = 28;
            txt_currentPass.UnderlinedStyle = false;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.White;
            txt_pass.BorderColor = Color.FromArgb(181, 191, 249);
            txt_pass.BorderFocusColor = Color.FromArgb(181, 191, 249);
            txt_pass.BorderSize = 1;
            txt_pass.Font = new Font("Segoe UI", 11F);
            txt_pass.ForeColor = Color.FromArgb(38, 32, 59);
            txt_pass.Location = new Point(102, 166);
            txt_pass.Margin = new Padding(3, 2, 3, 2);
            txt_pass.Multiline = false;
            txt_pass.Name = "txt_pass";
            txt_pass.Padding = new Padding(11, 10, 11, 10);
            txt_pass.PasswordChar = true;
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
            txt_confirm.Location = new Point(102, 228);
            txt_confirm.Margin = new Padding(3, 2, 3, 2);
            txt_confirm.Multiline = false;
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Padding = new Padding(11, 10, 11, 10);
            txt_confirm.PasswordChar = true;
            txt_confirm.Size = new Size(310, 41);
            txt_confirm.TabIndex = 26;
            txt_confirm.UnderlinedStyle = false;
            // 
            // btn_resetPass
            // 
            btn_resetPass.BackColor = Color.FromArgb(243, 248, 252);
            btn_resetPass.FlatAppearance.BorderSize = 2;
            btn_resetPass.FlatStyle = FlatStyle.Flat;
            btn_resetPass.Font = new Font("Segoe UI", 12F);
            btn_resetPass.ForeColor = Color.FromArgb(0, 126, 249);
            btn_resetPass.Location = new Point(55, 343);
            btn_resetPass.Margin = new Padding(4, 3, 4, 3);
            btn_resetPass.Name = "btn_resetPass";
            btn_resetPass.Size = new Size(174, 38);
            btn_resetPass.TabIndex = 25;
            btn_resetPass.Text = "Reset Password";
            btn_resetPass.UseVisualStyleBackColor = false;
            btn_resetPass.Click += btn_resetPass_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.ForeColor = Color.FromArgb(93, 114, 133);
            label4.Location = new Point(102, 207);
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
            label3.Location = new Point(102, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 17;
            label3.Text = "New Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.ForeColor = Color.FromArgb(93, 114, 133);
            label2.Location = new Point(102, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 14;
            label2.Text = "Current Password";
            // 
            // Change_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1106, 564);
            Controls.Add(pic_eyeCurrentPass);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Change_Password";
            Text = "Change_Password";
            pic_eyeCurrentPass.ResumeLayout(false);
            pic_eyeCurrentPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_eyePass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_eyeConfirm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pic_eyeCurrentPass;
        private Button btn_cancle;
        private PictureBox pic_eyePass;
        private Label show_pass;
        private PictureBox pic_eyeConfirm;
        private Label show_confirm;
        private CustomControls.CustomTextBox txt_currentPass;
        private CustomControls.CustomTextBox txt_pass;
        private CustomControls.CustomTextBox txt_confirm;
        private Button btn_resetPass;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label show_currentPass;
    }
}