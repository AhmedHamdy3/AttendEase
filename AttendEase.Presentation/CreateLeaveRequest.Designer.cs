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
            cb_requestType = new ComboBox();
            btn_cb_summaryType = new Button();
            label1 = new Label();
            rb_comment = new RichTextBox();
            panel2 = new Panel();
            label3 = new Label();
            dtp_startDate = new DateTimePicker();
            button1 = new Button();
            label4 = new Label();
            label5 = new Label();
            bottomBorderPanel1 = new CustomControls.BottomBorderPanel();
            label6 = new Label();
            bottomBorderPanel2 = new CustomControls.BottomBorderPanel();
            dtp_endDate = new DateTimePicker();
            button2 = new Button();
            csb_sendRequest = new CustomControls.CustomButton();
            csb_close = new CustomControls.CustomButton();
            panel2.SuspendLayout();
            bottomBorderPanel1.SuspendLayout();
            bottomBorderPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cb_requestType
            // 
            cb_requestType.FlatStyle = FlatStyle.Flat;
            cb_requestType.FormattingEnabled = true;
            cb_requestType.Location = new Point(31, 155);
            cb_requestType.Name = "cb_requestType";
            cb_requestType.Size = new Size(181, 28);
            cb_requestType.TabIndex = 12;
            // 
            // btn_cb_summaryType
            // 
            btn_cb_summaryType.BackColor = Color.White;
            btn_cb_summaryType.FlatAppearance.BorderSize = 0;
            btn_cb_summaryType.FlatAppearance.MouseDownBackColor = Color.White;
            btn_cb_summaryType.FlatAppearance.MouseOverBackColor = Color.White;
            btn_cb_summaryType.FlatStyle = FlatStyle.Flat;
            btn_cb_summaryType.ForeColor = SystemColors.ControlText;
            btn_cb_summaryType.Location = new Point(17, 146);
            btn_cb_summaryType.Name = "btn_cb_summaryType";
            btn_cb_summaryType.Size = new Size(210, 46);
            btn_cb_summaryType.TabIndex = 13;
            btn_cb_summaryType.UseVisualStyleBackColor = false;
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
            // rb_comment
            // 
            rb_comment.BorderStyle = BorderStyle.None;
            rb_comment.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rb_comment.Location = new Point(12, 12);
            rb_comment.Name = "rb_comment";
            rb_comment.Size = new Size(447, 138);
            rb_comment.TabIndex = 15;
            rb_comment.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(rb_comment);
            panel2.Location = new Point(17, 345);
            panel2.Name = "panel2";
            panel2.Size = new Size(470, 162);
            panel2.TabIndex = 16;
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
            // dtp_startDate
            // 
            dtp_startDate.Format = DateTimePickerFormat.Short;
            dtp_startDate.Location = new Point(-1, -1);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new Size(197, 27);
            dtp_startDate.TabIndex = 18;
            dtp_startDate.Value = new DateTime(2025, 3, 7, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(17, 244);
            button1.Name = "button1";
            button1.Size = new Size(210, 46);
            button1.TabIndex = 22;
            button1.UseVisualStyleBackColor = false;
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
            // bottomBorderPanel1
            // 
            bottomBorderPanel1.BackColor = Color.White;
            bottomBorderPanel1.Controls.Add(dtp_startDate);
            bottomBorderPanel1.Location = new Point(17, 255);
            bottomBorderPanel1.Name = "bottomBorderPanel1";
            bottomBorderPanel1.Size = new Size(195, 24);
            bottomBorderPanel1.TabIndex = 21;
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
            // bottomBorderPanel2
            // 
            bottomBorderPanel2.BackColor = Color.White;
            bottomBorderPanel2.Controls.Add(dtp_endDate);
            bottomBorderPanel2.Location = new Point(265, 255);
            bottomBorderPanel2.Name = "bottomBorderPanel2";
            bottomBorderPanel2.Size = new Size(195, 24);
            bottomBorderPanel2.TabIndex = 29;
            // 
            // dtp_endDate
            // 
            dtp_endDate.Format = DateTimePickerFormat.Short;
            dtp_endDate.Location = new Point(-1, -1);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new Size(197, 27);
            dtp_endDate.TabIndex = 18;
            dtp_endDate.Value = new DateTime(2025, 3, 7, 0, 0, 0, 0);
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(265, 244);
            button2.Name = "button2";
            button2.Size = new Size(210, 46);
            button2.TabIndex = 30;
            button2.UseVisualStyleBackColor = false;
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
            // CreateLeaveRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(503, 606);
            Controls.Add(csb_close);
            Controls.Add(csb_sendRequest);
            Controls.Add(bottomBorderPanel2);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(bottomBorderPanel1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(cb_requestType);
            Controls.Add(btn_cb_summaryType);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateLeaveRequest";
            Text = "CreateLeaveRequest";
            Load += CreateLeaveRequest_Load;
            panel2.ResumeLayout(false);
            bottomBorderPanel1.ResumeLayout(false);
            bottomBorderPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cb_requestType;
        private Button btn_cb_summaryType;
        private Label label1;
        private RichTextBox rb_comment;
        private Panel panel2;
        private Label label3;
        private DateTimePicker dtp_startDate;
        private Button button1;
        private Label label4;
        private Label label5;
        private CustomControls.BottomBorderPanel bottomBorderPanel1;
        private Label label6;
        private PictureBox pb_close;
        private CustomControls.BottomBorderPanel bottomBorderPanel2;
        private DateTimePicker dtp_endDate;
        private Button button2;
        private CustomControls.CustomButton csb_sendRequest;
        private CustomControls.CustomButton csb_close;
    }
}