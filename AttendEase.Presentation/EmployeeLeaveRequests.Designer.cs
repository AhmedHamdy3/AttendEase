namespace AttendEase.Presentation
{
    partial class EmployeeLeaveRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLeaveRequests));
            lbl_title = new Label();
            csb_addRequest = new CustomControls.CustomButton();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(14, 93);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(307, 62);
            lbl_title.TabIndex = 25;
            lbl_title.Text = "My Requests";
            // 
            // csb_addRequest
            // 
            csb_addRequest.BackColor = Color.FromArgb(70, 95, 241);
            csb_addRequest.BorderColor = Color.Black;
            csb_addRequest.BorderRadius = 10;
            csb_addRequest.BorderSize = 0;
            csb_addRequest.Cursor = Cursors.Hand;
            csb_addRequest.FlatAppearance.BorderSize = 0;
            csb_addRequest.FlatStyle = FlatStyle.Flat;
            csb_addRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            csb_addRequest.ForeColor = Color.White;
            csb_addRequest.Image = (Image)resources.GetObject("csb_addRequest.Image");
            csb_addRequest.ImageAlign = ContentAlignment.MiddleLeft;
            csb_addRequest.Location = new Point(720, 155);
            csb_addRequest.Name = "csb_addRequest";
            csb_addRequest.Padding = new Padding(25, 0, 0, 0);
            csb_addRequest.Size = new Size(209, 50);
            csb_addRequest.TabIndex = 27;
            csb_addRequest.Text = "Add Request";
            csb_addRequest.UseVisualStyleBackColor = false;
            csb_addRequest.Click += csb_addRequest_Click;
            // 
            // EmployeeLeaveRequests
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(csb_addRequest);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeLeaveRequests";
            Text = "EmployeeLeaveRequests";
            Load += EmployeeLeaveRequests_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_title;
        private CustomControls.CustomButton csb_addRequest;
    }
}