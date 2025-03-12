namespace AttendEase.Presentation
{
    partial class LeaveRequestsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveRequestsForm));
            panel2 = new Panel();
            pic_next = new PictureBox();
            pic_prev = new PictureBox();
            panel4 = new Panel();
            lbl_title3 = new Label();
            Btn_view3 = new Button();
            lbl_userName3 = new Label();
            pic_user3 = new PictureBox();
            panel7 = new Panel();
            panel3 = new Panel();
            lbl_title1 = new Label();
            btn_view1 = new Button();
            lbl_userName1 = new Label();
            pic_user1 = new PictureBox();
            panel5 = new Panel();
            panel1 = new Panel();
            lbl_title2 = new Label();
            btn_view2 = new Button();
            lbl_userName2 = new Label();
            pic_user2 = new PictureBox();
            panel6 = new Panel();
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_next).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_prev).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pic_next);
            panel2.Controls.Add(pic_prev);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pictureBox9);
            panel2.Controls.Add(lbl_title);
            panel2.Location = new Point(12, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(987, 829);
            panel2.TabIndex = 21;
            panel2.Paint += panel2_Paint;
            // 
            // pic_next
            // 
            pic_next.Image = (Image)resources.GetObject("pic_next.Image");
            pic_next.Location = new Point(899, 442);
            pic_next.Name = "pic_next";
            pic_next.Size = new Size(40, 46);
            pic_next.SizeMode = PictureBoxSizeMode.Zoom;
            pic_next.TabIndex = 25;
            pic_next.TabStop = false;
            pic_next.Click += pic_next_Click;
            // 
            // pic_prev
            // 
            pic_prev.Image = (Image)resources.GetObject("pic_prev.Image");
            pic_prev.Location = new Point(-4, 442);
            pic_prev.Name = "pic_prev";
            pic_prev.Size = new Size(40, 46);
            pic_prev.SizeMode = PictureBoxSizeMode.Zoom;
            pic_prev.TabIndex = 24;
            pic_prev.TabStop = false;
            pic_prev.Click += pic_prev_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_title3);
            panel4.Controls.Add(Btn_view3);
            panel4.Controls.Add(lbl_userName3);
            panel4.Controls.Add(pic_user3);
            panel4.Controls.Add(panel7);
            panel4.Location = new Point(620, 238);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 432);
            panel4.TabIndex = 23;
            // 
            // lbl_title3
            // 
            lbl_title3.AutoSize = true;
            lbl_title3.Location = new Point(16, 273);
            lbl_title3.Name = "lbl_title3";
            lbl_title3.Size = new Size(46, 20);
            lbl_title3.TabIndex = 28;
            lbl_title3.Text = "Title3";
            // 
            // Btn_view3
            // 
            Btn_view3.FlatAppearance.BorderSize = 2;
            Btn_view3.FlatStyle = FlatStyle.Flat;
            Btn_view3.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            Btn_view3.ForeColor = Color.FromArgb(0, 126, 249);
            Btn_view3.Location = new Point(3, 368);
            Btn_view3.Name = "Btn_view3";
            Btn_view3.Size = new Size(267, 47);
            Btn_view3.TabIndex = 27;
            Btn_view3.Text = "View Request";
            Btn_view3.UseVisualStyleBackColor = true;
            Btn_view3.Click += Btn_view3_Click;
            // 
            // lbl_userName3
            // 
            lbl_userName3.AutoSize = true;
            lbl_userName3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_userName3.Location = new Point(81, 222);
            lbl_userName3.Name = "lbl_userName3";
            lbl_userName3.Size = new Size(116, 28);
            lbl_userName3.TabIndex = 8;
            lbl_userName3.Text = "User Name";
            // 
            // pic_user3
            // 
            pic_user3.BackColor = Color.White;
            pic_user3.Image = Properties.Resources.user__1_;
            pic_user3.Location = new Point(81, 75);
            pic_user3.Name = "pic_user3";
            pic_user3.Size = new Size(125, 125);
            pic_user3.SizeMode = PictureBoxSizeMode.Zoom;
            pic_user3.TabIndex = 6;
            pic_user3.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(111, 181, 250);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(273, 125);
            panel7.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Controls.Add(lbl_title1);
            panel3.Controls.Add(btn_view1);
            panel3.Controls.Add(lbl_userName1);
            panel3.Controls.Add(pic_user1);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(35, 238);
            panel3.Name = "panel3";
            panel3.Size = new Size(273, 432);
            panel3.TabIndex = 23;
            panel3.Paint += panel3_Paint;
            // 
            // lbl_title1
            // 
            lbl_title1.AutoSize = true;
            lbl_title1.Location = new Point(15, 273);
            lbl_title1.Name = "lbl_title1";
            lbl_title1.Size = new Size(46, 20);
            lbl_title1.TabIndex = 27;
            lbl_title1.Text = "Title1";
            // 
            // btn_view1
            // 
            btn_view1.FlatAppearance.BorderSize = 2;
            btn_view1.FlatStyle = FlatStyle.Flat;
            btn_view1.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_view1.ForeColor = Color.FromArgb(0, 126, 249);
            btn_view1.Location = new Point(3, 368);
            btn_view1.Name = "btn_view1";
            btn_view1.Size = new Size(269, 47);
            btn_view1.TabIndex = 26;
            btn_view1.Text = "View Request";
            btn_view1.UseVisualStyleBackColor = true;
            btn_view1.Click += btn_view1_Click;
            // 
            // lbl_userName1
            // 
            lbl_userName1.AutoSize = true;
            lbl_userName1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_userName1.Location = new Point(82, 222);
            lbl_userName1.Name = "lbl_userName1";
            lbl_userName1.Size = new Size(116, 28);
            lbl_userName1.TabIndex = 2;
            lbl_userName1.Text = "User Name";
            // 
            // pic_user1
            // 
            pic_user1.BackColor = Color.White;
            pic_user1.Image = (Image)resources.GetObject("pic_user1.Image");
            pic_user1.Location = new Point(82, 75);
            pic_user1.Name = "pic_user1";
            pic_user1.Size = new Size(125, 125);
            pic_user1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_user1.TabIndex = 0;
            pic_user1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(111, 181, 250);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(273, 125);
            panel5.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_title2);
            panel1.Controls.Add(btn_view2);
            panel1.Controls.Add(lbl_userName2);
            panel1.Controls.Add(pic_user2);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(328, 238);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 432);
            panel1.TabIndex = 22;
            // 
            // lbl_title2
            // 
            lbl_title2.AutoSize = true;
            lbl_title2.Location = new Point(15, 273);
            lbl_title2.Name = "lbl_title2";
            lbl_title2.Size = new Size(46, 20);
            lbl_title2.TabIndex = 28;
            lbl_title2.Text = "Title2";
            // 
            // btn_view2
            // 
            btn_view2.FlatAppearance.BorderSize = 2;
            btn_view2.FlatStyle = FlatStyle.Flat;
            btn_view2.Font = new Font("Nirmala UI", 12F, FontStyle.Bold);
            btn_view2.ForeColor = Color.FromArgb(0, 126, 249);
            btn_view2.Location = new Point(3, 368);
            btn_view2.Name = "btn_view2";
            btn_view2.Size = new Size(268, 47);
            btn_view2.TabIndex = 27;
            btn_view2.Text = "View Request";
            btn_view2.UseVisualStyleBackColor = true;
            btn_view2.Click += btn_view2_Click;
            // 
            // lbl_userName2
            // 
            lbl_userName2.AutoSize = true;
            lbl_userName2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_userName2.Location = new Point(78, 222);
            lbl_userName2.Name = "lbl_userName2";
            lbl_userName2.Size = new Size(116, 28);
            lbl_userName2.TabIndex = 5;
            lbl_userName2.Text = "User Name";
            // 
            // pic_user2
            // 
            pic_user2.BackColor = Color.White;
            pic_user2.Image = (Image)resources.GetObject("pic_user2.Image");
            pic_user2.Location = new Point(78, 75);
            pic_user2.Name = "pic_user2";
            pic_user2.Size = new Size(125, 125);
            pic_user2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_user2.TabIndex = 3;
            pic_user2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(111, 181, 250);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(273, 125);
            panel6.TabIndex = 4;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(19, 20);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 21;
            pictureBox9.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(4, 81);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(361, 62);
            lbl_title.TabIndex = 20;
            lbl_title.Text = "Leave Requests";
            // 
            // LeaveRequestsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(1300, 900);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LeaveRequestsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LeaveRequestsForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_next).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_prev).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_user2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox9;
        private Label lbl_title;
        private PictureBox pic_prev;
        private Panel panel4;
        private Panel panel3;
        private Panel panel1;
        private PictureBox pic_next;
        private Panel panel5;
        private PictureBox pic_user1;
        private Label lbl_userName3;
        private PictureBox pic_user3;
        private Panel panel7;
        private Label lbl_userName1;
        private Label lbl_userName2;
        private PictureBox pic_user2;
        private Panel panel6;
        private Button btn_view1;
        private Label lbl_title3;
        private Button Btn_view3;
        private Label lbl_title1;
        private Label lbl_title2;
        private Button btn_view2;
    }
}