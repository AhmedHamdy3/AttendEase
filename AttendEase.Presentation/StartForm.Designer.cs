namespace AttendEase.Presentation
{
    partial class StartForm
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
            btn_setPassword = new Button();
            btn_signIn = new Button();
            SuspendLayout();
            // 
            // btn_setPassword
            // 
            btn_setPassword.Location = new Point(302, 276);
            btn_setPassword.Name = "btn_setPassword";
            btn_setPassword.Size = new Size(238, 147);
            btn_setPassword.TabIndex = 3;
            btn_setPassword.Text = "Set Password";
            btn_setPassword.UseVisualStyleBackColor = true;
            btn_setPassword.Click += btn_setPassword_Click;
            // 
            // btn_signIn
            // 
            btn_signIn.Location = new Point(734, 276);
            btn_signIn.Name = "btn_signIn";
            btn_signIn.Size = new Size(247, 147);
            btn_signIn.TabIndex = 4;
            btn_signIn.Text = "Log In";
            btn_signIn.UseVisualStyleBackColor = true;
            btn_signIn.Click += btn_signIn_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1283, 853);
            Controls.Add(btn_setPassword);
            Controls.Add(btn_signIn);
            ForeColor = SystemColors.ControlText;
            Name = "StartForm";
            Text = "StartForm";
            Load += StartForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_setPassword;
        private Button btn_signIn;
    }
}