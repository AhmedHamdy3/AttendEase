namespace AttendEase.Presentation
{
    partial class Arrivals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrivals));
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            btn_back = new Button();
            cdtp_endDate = new CustomControls.CustomDateTimePicker();
            cdtp_startDate = new CustomControls.CustomDateTimePicker();
            pnl_exportMenu = new Panel();
            cbtn_exportPdf = new CustomControls.CustomButton();
            cbtn_exportExcel = new CustomControls.CustomButton();
            cbtn_export = new CustomControls.CustomButton();
            lbl_details_header = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnl_exportMenu.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(27, 26);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 17;
            pictureBox9.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(22, 107);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(665, 54);
            lbl_title.TabIndex = 16;
            lbl_title.Text = "Late Arrivals and Early Departures";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.Transparent;
            btn_back.Cursor = Cursors.Hand;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_back.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.FromArgb(63, 140, 255);
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(29, 240);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(163, 29);
            btn_back.TabIndex = 23;
            btn_back.Text = "      Back to Arrivals";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click;
            // 
            // cdtp_endDate
            // 
            cdtp_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_endDate.BorderSize = 0;
            cdtp_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_endDate.Location = new Point(439, 171);
            cdtp_endDate.MinimumSize = new Size(0, 46);
            cdtp_endDate.Name = "cdtp_endDate";
            cdtp_endDate.Size = new Size(355, 46);
            cdtp_endDate.SkinColor = Color.White;
            cdtp_endDate.TabIndex = 35;
            cdtp_endDate.TextColor = Color.FromArgb(10, 22, 41);
            cdtp_endDate.ValueChanged += cdtp_endDate_ValueChanged;
            // 
            // cdtp_startDate
            // 
            cdtp_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_startDate.BorderSize = 0;
            cdtp_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_startDate.Location = new Point(30, 171);
            cdtp_startDate.MinimumSize = new Size(0, 46);
            cdtp_startDate.Name = "cdtp_startDate";
            cdtp_startDate.Size = new Size(355, 46);
            cdtp_startDate.SkinColor = Color.White;
            cdtp_startDate.TabIndex = 34;
            cdtp_startDate.TextColor = Color.FromArgb(10, 22, 41);
            cdtp_startDate.ValueChanged += cdtp_startDate_ValueChanged;
            // 
            // pnl_exportMenu
            // 
            pnl_exportMenu.Controls.Add(cbtn_exportPdf);
            pnl_exportMenu.Controls.Add(cbtn_exportExcel);
            pnl_exportMenu.Location = new Point(754, 74);
            pnl_exportMenu.Name = "pnl_exportMenu";
            pnl_exportMenu.Size = new Size(178, 104);
            pnl_exportMenu.TabIndex = 37;
            pnl_exportMenu.Visible = false;
            // 
            // cbtn_exportPdf
            // 
            cbtn_exportPdf.BackColor = SystemColors.MenuBar;
            cbtn_exportPdf.BorderColor = Color.Black;
            cbtn_exportPdf.BorderRadius = 0;
            cbtn_exportPdf.BorderSize = 0;
            cbtn_exportPdf.Cursor = Cursors.Hand;
            cbtn_exportPdf.FlatAppearance.BorderSize = 0;
            cbtn_exportPdf.FlatStyle = FlatStyle.Flat;
            cbtn_exportPdf.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_exportPdf.ForeColor = Color.FromArgb(10, 22, 41);
            cbtn_exportPdf.Image = Properties.Resources.Export_Pdf;
            cbtn_exportPdf.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_exportPdf.Location = new Point(1, 1);
            cbtn_exportPdf.Name = "cbtn_exportPdf";
            cbtn_exportPdf.Size = new Size(176, 50);
            cbtn_exportPdf.TabIndex = 26;
            cbtn_exportPdf.Text = "        PDF";
            cbtn_exportPdf.TextAlign = ContentAlignment.MiddleLeft;
            cbtn_exportPdf.UseVisualStyleBackColor = false;
            cbtn_exportPdf.Visible = false;
            cbtn_exportPdf.Click += cbtn_exportPdf_Click;
            // 
            // cbtn_exportExcel
            // 
            cbtn_exportExcel.BackColor = SystemColors.MenuBar;
            cbtn_exportExcel.BorderColor = Color.Black;
            cbtn_exportExcel.BorderRadius = 0;
            cbtn_exportExcel.BorderSize = 0;
            cbtn_exportExcel.Cursor = Cursors.Hand;
            cbtn_exportExcel.FlatAppearance.BorderSize = 0;
            cbtn_exportExcel.FlatStyle = FlatStyle.Flat;
            cbtn_exportExcel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_exportExcel.ForeColor = Color.FromArgb(10, 22, 41);
            cbtn_exportExcel.Image = Properties.Resources.Export_CSV;
            cbtn_exportExcel.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_exportExcel.Location = new Point(1, 51);
            cbtn_exportExcel.Name = "cbtn_exportExcel";
            cbtn_exportExcel.Size = new Size(176, 50);
            cbtn_exportExcel.TabIndex = 27;
            cbtn_exportExcel.Text = "        EXCEL";
            cbtn_exportExcel.TextAlign = ContentAlignment.MiddleLeft;
            cbtn_exportExcel.UseVisualStyleBackColor = false;
            cbtn_exportExcel.Visible = false;
            cbtn_exportExcel.Click += cbtn_exportExcel_Click;
            // 
            // cbtn_export
            // 
            cbtn_export.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_export.BorderColor = Color.Black;
            cbtn_export.BorderRadius = 5;
            cbtn_export.BorderSize = 0;
            cbtn_export.Cursor = Cursors.Hand;
            cbtn_export.FlatAppearance.BorderSize = 0;
            cbtn_export.FlatStyle = FlatStyle.Flat;
            cbtn_export.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_export.ForeColor = Color.White;
            cbtn_export.Image = Properties.Resources.Export;
            cbtn_export.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_export.Location = new Point(750, 24);
            cbtn_export.Name = "cbtn_export";
            cbtn_export.Padding = new Padding(15, 0, 0, 0);
            cbtn_export.Size = new Size(182, 50);
            cbtn_export.TabIndex = 36;
            cbtn_export.Text = "         Export";
            cbtn_export.TextAlign = ContentAlignment.MiddleLeft;
            cbtn_export.UseVisualStyleBackColor = false;
            cbtn_export.Click += cbtn_export_Click;
            // 
            // lbl_details_header
            // 
            lbl_details_header.AutoSize = true;
            lbl_details_header.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_details_header.Location = new Point(22, 107);
            lbl_details_header.Name = "lbl_details_header";
            lbl_details_header.Size = new Size(0, 38);
            lbl_details_header.TabIndex = 38;
            // 
            // Arrivals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(lbl_details_header);
            Controls.Add(pnl_exportMenu);
            Controls.Add(cbtn_export);
            Controls.Add(cdtp_endDate);
            Controls.Add(cdtp_startDate);
            Controls.Add(btn_back);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Arrivals";
            Text = "Arrivals";
            Load += Arrivals_Load;
            MouseClick += Arrivals_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnl_exportMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_title;
        private Button btn_back;
        private CustomControls.CustomDateTimePicker cdtp_endDate;
        private CustomControls.CustomDateTimePicker cdtp_startDate;
        private Panel pnl_exportMenu;
        private CustomControls.CustomButton cbtn_exportPdf;
        private CustomControls.CustomButton cbtn_exportExcel;
        private CustomControls.CustomButton cbtn_export;
        private Label lbl_details_header;
    }
}