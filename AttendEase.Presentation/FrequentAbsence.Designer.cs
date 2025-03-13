﻿namespace AttendEase.Presentation
{
    partial class FrequentAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrequentAbsence));
            pictureBox9 = new PictureBox();
            lbl_title = new Label();
            btn_back = new Button();
            cdtp_startDate = new CustomControls.CustomDateTimePicker();
            cdtp_endDate = new CustomControls.CustomDateTimePicker();
            pnl_exportMenu = new Panel();
            cbtn_exportPdf = new CustomControls.CustomButton();
            cbtn_exportExcel = new CustomControls.CustomButton();
            cbtn_export = new CustomControls.CustomButton();
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
            pictureBox9.TabIndex = 25;
            pictureBox9.TabStop = false;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_title.Location = new Point(12, 87);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(420, 62);
            lbl_title.TabIndex = 24;
            lbl_title.Text = "Frequent Absence";
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
            btn_back.Size = new Size(234, 29);
            btn_back.TabIndex = 30;
            btn_back.Text = "      Back to Frequent Absence";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click_1;
            // 
            // cdtp_startDate
            // 
            cdtp_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_startDate.BorderSize = 0;
            cdtp_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_startDate.Location = new Point(29, 171);
            cdtp_startDate.MinimumSize = new Size(0, 46);
            cdtp_startDate.Name = "cdtp_startDate";
            cdtp_startDate.Size = new Size(355, 46);
            cdtp_startDate.SkinColor = Color.White;
            cdtp_startDate.TabIndex = 32;
            cdtp_startDate.TextColor = Color.FromArgb(10, 22, 41);
            cdtp_startDate.ValueChanged += cdtp_startDate_ValueChanged;
            // 
            // cdtp_endDate
            // 
            cdtp_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_endDate.BorderSize = 0;
            cdtp_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_endDate.Location = new Point(438, 170);
            cdtp_endDate.MinimumSize = new Size(0, 46);
            cdtp_endDate.Name = "cdtp_endDate";
            cdtp_endDate.Size = new Size(355, 46);
            cdtp_endDate.SkinColor = Color.White;
            cdtp_endDate.TabIndex = 33;
            cdtp_endDate.TextColor = Color.FromArgb(10, 22, 41);
            cdtp_endDate.ValueChanged += cdtp_endDate_ValueChanged;
            // 
            // pnl_exportMenu
            // 
            pnl_exportMenu.Controls.Add(cbtn_exportPdf);
            pnl_exportMenu.Controls.Add(cbtn_exportExcel);
            pnl_exportMenu.Location = new Point(773, 74);
            pnl_exportMenu.Name = "pnl_exportMenu";
            pnl_exportMenu.Size = new Size(178, 104);
            pnl_exportMenu.TabIndex = 39;
            // 
            // cbtn_exportPdf
            // 
            cbtn_exportPdf.BackColor = SystemColors.MenuBar;
            cbtn_exportPdf.BorderRadius = 0;
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
            cbtn_exportExcel.BorderRadius = 0;
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
            cbtn_export.BorderRadius = 5;
            cbtn_export.Cursor = Cursors.Hand;
            cbtn_export.FlatAppearance.BorderSize = 0;
            cbtn_export.FlatStyle = FlatStyle.Flat;
            cbtn_export.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_export.ForeColor = Color.White;
            cbtn_export.Image = Properties.Resources.Export;
            cbtn_export.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_export.Location = new Point(769, 24);
            cbtn_export.Name = "cbtn_export";
            cbtn_export.Padding = new Padding(15, 0, 0, 0);
            cbtn_export.Size = new Size(182, 50);
            cbtn_export.TabIndex = 38;
            cbtn_export.Text = "         Export";
            cbtn_export.TextAlign = ContentAlignment.MiddleLeft;
            cbtn_export.UseVisualStyleBackColor = false;
            cbtn_export.Click += cbtn_export_Click;
            // 
            // FrequentAbsence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(pnl_exportMenu);
            Controls.Add(cbtn_export);
            Controls.Add(cdtp_endDate);
            Controls.Add(cdtp_startDate);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_title);
            Controls.Add(btn_back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrequentAbsence";
            Text = "FrequentAbsence";
            Load += FrequentAbsence_Load;
            MouseClick += FrequentAbsence_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnl_exportMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox9;
        private Label lbl_title;
        private Button btn_back;
        private CustomControls.CustomDateTimePicker cdtp_startDate;
        private CustomControls.CustomDateTimePicker cdtp_endDate;
        private Panel pnl_exportMenu;
        private CustomControls.CustomButton cbtn_exportPdf;
        private CustomControls.CustomButton cbtn_exportExcel;
        private CustomControls.CustomButton cbtn_export;
    }
}