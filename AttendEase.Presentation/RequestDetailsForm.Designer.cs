namespace AttendEase.Presentation
{
    partial class RequestDetailsForm
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
            lbl_jobTitle = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lbl_name = new Label();
            lbl_title = new Label();
            lbl_end = new Label();
            lbl_start = new Label();
            lbl_creationDate = new Label();
            lbl_desc = new Label();
            btn_accept = new Button();
            btn_reject = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_jobTitle
            // 
            lbl_jobTitle.AutoSize = true;
            lbl_jobTitle.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_jobTitle.Location = new Point(285, 340);
            lbl_jobTitle.Name = "lbl_jobTitle";
            lbl_jobTitle.Size = new Size(140, 20);
            lbl_jobTitle.TabIndex = 4;
            lbl_jobTitle.Text = "Some user text here";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Location = new Point(260, 111);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(177, 178);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_name.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_name.Location = new Point(263, 292);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(81, 32);
            lbl_name.TabIndex = 2;
            lbl_name.Text = "Name";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lbl_title.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_title.Location = new Point(39, 14);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(59, 30);
            lbl_title.TabIndex = 7;
            lbl_title.Text = "Title";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_end
            // 
            lbl_end.AutoSize = true;
            lbl_end.Font = new Font("Segoe UI", 11F);
            lbl_end.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_end.Location = new Point(49, 17);
            lbl_end.Name = "lbl_end";
            lbl_end.Size = new Size(83, 25);
            lbl_end.TabIndex = 15;
            lbl_end.Text = "EndDate";
            // 
            // lbl_start
            // 
            lbl_start.AutoSize = true;
            lbl_start.Font = new Font("Segoe UI", 11F);
            lbl_start.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_start.Location = new Point(74, 17);
            lbl_start.Name = "lbl_start";
            lbl_start.Size = new Size(89, 25);
            lbl_start.TabIndex = 12;
            lbl_start.Text = "StartDate";
            // 
            // lbl_creationDate
            // 
            lbl_creationDate.AutoSize = true;
            lbl_creationDate.Font = new Font("Segoe UI", 11F);
            lbl_creationDate.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_creationDate.Location = new Point(56, 18);
            lbl_creationDate.Name = "lbl_creationDate";
            lbl_creationDate.Size = new Size(123, 25);
            lbl_creationDate.TabIndex = 16;
            lbl_creationDate.Text = "creation date";
            // 
            // lbl_desc
            // 
            lbl_desc.AutoSize = true;
            lbl_desc.Font = new Font("Segoe UI", 10F);
            lbl_desc.ForeColor = Color.FromArgb(93, 114, 133);
            lbl_desc.Location = new Point(51, 75);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(96, 23);
            lbl_desc.TabIndex = 17;
            lbl_desc.Text = "Description";
            lbl_desc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_accept
            // 
            btn_accept.FlatAppearance.BorderSize = 2;
            btn_accept.FlatStyle = FlatStyle.Flat;
            btn_accept.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_accept.ForeColor = Color.FromArgb(0, 126, 249);
            btn_accept.Location = new Point(75, 678);
            btn_accept.Name = "btn_accept";
            btn_accept.Size = new Size(269, 47);
            btn_accept.TabIndex = 27;
            btn_accept.Text = "Accept Request";
            btn_accept.UseVisualStyleBackColor = true;
            btn_accept.Click += btn_accept_Click;
            // 
            // btn_reject
            // 
            btn_reject.FlatAppearance.BorderSize = 2;
            btn_reject.FlatStyle = FlatStyle.Flat;
            btn_reject.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_reject.ForeColor = Color.FromArgb(0, 126, 249);
            btn_reject.Location = new Point(369, 678);
            btn_reject.Name = "btn_reject";
            btn_reject.Size = new Size(269, 47);
            btn_reject.TabIndex = 28;
            btn_reject.Text = "Reject Request";
            btn_reject.UseVisualStyleBackColor = true;
            btn_reject.Click += btn_reject_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 181, 250);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 174);
            panel1.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(111, 181, 250);
            panel2.Controls.Add(lbl_desc);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 380);
            panel2.Name = "panel2";
            panel2.Size = new Size(715, 224);
            panel2.TabIndex = 30;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(label2);
            panel6.Controls.Add(lbl_start);
            panel6.Location = new Point(3, 163);
            panel6.Name = "panel6";
            panel6.Size = new Size(354, 58);
            panel6.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(93, 114, 133);
            label2.Location = new Point(14, 17);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 18;
            label2.Text = "FROM";
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label3);
            panel5.Controls.Add(lbl_end);
            panel5.Location = new Point(363, 163);
            panel5.Name = "panel5";
            panel5.Size = new Size(349, 58);
            panel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(93, 114, 133);
            label3.Location = new Point(8, 17);
            label3.Name = "label3";
            label3.Size = new Size(36, 25);
            label3.TabIndex = 18;
            label3.Text = "TO";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label1);
            panel4.Controls.Add(lbl_creationDate);
            panel4.Location = new Point(363, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(349, 58);
            panel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(93, 114, 133);
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 17;
            label1.Text = "ON";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lbl_title);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(354, 58);
            panel3.TabIndex = 0;
            // 
            // RequestDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(739, 758);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_reject);
            Controls.Add(btn_accept);
            Controls.Add(lbl_jobTitle);
            Controls.Add(lbl_name);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RequestDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RequestDetailsForm";
            Load += RequestDetailsForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_jobTitle;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lbl_title;
        private Label lbl_end;
        private Label lbl_name;
        private Label lbl_start;
        private Label lbl_creationDate;
        private Label lbl_desc;
        private Button btn_accept;
        private Button btn_reject;
        private Panel panel1;
        private Panel panel2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}