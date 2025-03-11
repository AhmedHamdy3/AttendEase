namespace AttendEase.Presentation
{
    partial class CreateLeaveRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLeaveRequest));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            csb_sendRequest = new CustomControls.CustomButton();
            csb_close = new CustomControls.CustomButton();
            cdtp_startDate = new CustomControls.CustomDateTimePicker();
            cdtp_endDate = new CustomControls.CustomDateTimePicker();
            ccb_requestType = new CustomControls.CustomComboBox();
            ctxt_comment = new CustomControls.CustomTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(125, 133, 146);
            label1.Location = new Point(17, 115);
            label1.Name = "label1";
            label1.Size = new Size(113, 23);
            label1.TabIndex = 14;
            label1.Text = "Request Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(125, 133, 146);
            label3.Location = new Point(17, 317);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 17;
            label3.Text = "Comment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(125, 133, 146);
            label4.Location = new Point(17, 213);
            label4.Name = "label4";
            label4.Size = new Size(50, 23);
            label4.TabIndex = 23;
            label4.Text = "From";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(125, 133, 146);
            label5.Location = new Point(265, 213);
            label5.Name = "label5";
            label5.Size = new Size(27, 23);
            label5.TabIndex = 26;
            label5.Text = "To";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(10, 22, 41);
            label6.Location = new Point(18, 50);
            label6.Name = "label6";
            label6.Size = new Size(132, 28);
            label6.TabIndex = 27;
            label6.Text = "Add Request";
            // 
            // csb_sendRequest
            // 
            csb_sendRequest.BackColor = Color.FromArgb(70, 95, 241);
            csb_sendRequest.BorderRadius = 10;
            csb_sendRequest.Cursor = Cursors.Hand;
            csb_sendRequest.FlatAppearance.BorderSize = 0;
            csb_sendRequest.FlatStyle = FlatStyle.Flat;
            csb_sendRequest.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            csb_sendRequest.ForeColor = Color.White;
            csb_sendRequest.Location = new Point(274, 528);
            csb_sendRequest.Name = "csb_sendRequest";
            csb_sendRequest.Size = new Size(213, 51);
            csb_sendRequest.TabIndex = 32;
            csb_sendRequest.Text = "Send Request";
            csb_sendRequest.UseVisualStyleBackColor = false;
            csb_sendRequest.Click += csb_sendRequest_Click;
            // 
            // csb_close
            // 
            csb_close.BackColor = Color.FromArgb(243, 248, 252);
            csb_close.BorderRadius = 0;
            csb_close.Cursor = Cursors.Hand;
            csb_close.FlatAppearance.BorderSize = 0;
            csb_close.FlatStyle = FlatStyle.Flat;
            csb_close.ForeColor = Color.Black;
            csb_close.Image = (Image)resources.GetObject("csb_close.Image");
            csb_close.Location = new Point(442, 21);
            csb_close.Name = "csb_close";
            csb_close.Size = new Size(45, 45);
            csb_close.TabIndex = 33;
            csb_close.UseVisualStyleBackColor = false;
            csb_close.Click += csb_close_Click;
            // 
            // cdtp_startDate
            // 
            cdtp_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_startDate.BorderSize = 0;
            cdtp_startDate.CustomFormat = "dd/MM/yyyy";
            cdtp_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_startDate.Location = new Point(17, 244);
            cdtp_startDate.MinimumSize = new Size(0, 46);
            cdtp_startDate.Name = "cdtp_startDate";
            cdtp_startDate.Size = new Size(210, 46);
            cdtp_startDate.SkinColor = Color.White;
            cdtp_startDate.TabIndex = 35;
            cdtp_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // cdtp_endDate
            // 
            cdtp_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_endDate.BorderSize = 0;
            cdtp_endDate.CustomFormat = "dd/MM/yyyy";
            cdtp_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_endDate.Location = new Point(265, 244);
            cdtp_endDate.MinimumSize = new Size(0, 46);
            cdtp_endDate.Name = "cdtp_endDate";
            cdtp_endDate.Size = new Size(210, 46);
            cdtp_endDate.SkinColor = Color.White;
            cdtp_endDate.TabIndex = 36;
            cdtp_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // ccb_requestType
            // 
            ccb_requestType.BackColor = Color.White;
            ccb_requestType.BorderColor = Color.FromArgb(181, 191, 249);
            ccb_requestType.BorderSize = 0;
            ccb_requestType.DropDownStyle = ComboBoxStyle.DropDown;
            ccb_requestType.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ccb_requestType.ForeColor = Color.FromArgb(10, 22, 41);
            ccb_requestType.IconColor = Color.FromArgb(10, 22, 41);
            ccb_requestType.ListBackColor = Color.White;
            ccb_requestType.ListTextColor = Color.FromArgb(10, 22, 41);
            ccb_requestType.Location = new Point(17, 146);
            ccb_requestType.MinimumSize = new Size(200, 30);
            ccb_requestType.Name = "ccb_requestType";
            ccb_requestType.Size = new Size(223, 46);
            ccb_requestType.TabIndex = 37;
            // 
            // ctxt_comment
            // 
            ctxt_comment.BackColor = Color.White;
            ctxt_comment.BorderColor = Color.White;
            ctxt_comment.BorderFocusColor = Color.White;
            ctxt_comment.BorderSize = 0;
            ctxt_comment.ForeColor = Color.FromArgb(38, 32, 59);
            ctxt_comment.Location = new Point(17, 345);
            ctxt_comment.Multiline = true;
            ctxt_comment.Name = "ctxt_comment";
            ctxt_comment.Padding = new Padding(13);
            ctxt_comment.PasswordChar = false;
            ctxt_comment.Size = new Size(470, 162);
            ctxt_comment.TabIndex = 38;
            ctxt_comment.UnderlinedStyle = false;
            // 
            // CreateLeaveRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(503, 606);
            Controls.Add(ctxt_comment);
            Controls.Add(ccb_requestType);
            Controls.Add(cdtp_endDate);
            Controls.Add(cdtp_startDate);
            Controls.Add(csb_close);
            Controls.Add(csb_sendRequest);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateLeaveRequest";
            Text = "CreateLeaveRequest";
            Load += CreateLeaveRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox pb_close;
        private CustomControls.CustomButton csb_sendRequest;
        private CustomControls.CustomButton csb_close;
        private CustomControls.CustomDateTimePicker cdtp_startDate;
        private CustomControls.CustomDateTimePicker cdtp_endDate;
        private CustomControls.CustomComboBox ccb_requestType;
        private CustomControls.CustomTextBox ctxt_comment;
    }
}