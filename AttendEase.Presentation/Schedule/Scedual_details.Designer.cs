namespace AttendEase.Presentation.Scedual
{
    partial class Scedual_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scedual_details));
            lbl_schedules = new Label();
            pictureBox9 = new PictureBox();
            csb_addSchedule = new CustomControls.CustomButton();
            btn_back = new Button();
            label2 = new Label();
            label9 = new Label();
            ctxt_name = new CustomControls.CustomTextBox();
            ctxt_description = new CustomControls.CustomTextBox();
            cbtn_add = new CustomControls.CustomButton();
            pnl_addSchedule = new Panel();
            cdtp_wednesday_startDate = new CustomControls.CustomDateTimePicker();
            cdtp_friday_endDate = new CustomControls.CustomDateTimePicker();
            chb_friday = new CheckBox();
            cdtp_friday_startDate = new CustomControls.CustomDateTimePicker();
            cdtp_Thurday_endDate = new CustomControls.CustomDateTimePicker();
            cdtp_wednesday_endDate = new CustomControls.CustomDateTimePicker();
            cdtp_Tuesday_endDate = new CustomControls.CustomDateTimePicker();
            chb_thursday = new CheckBox();
            cdtp_Thurday_startDate = new CustomControls.CustomDateTimePicker();
            chb_wednesday = new CheckBox();
            chb_tuesday = new CheckBox();
            cdtp_Tuesday_startDate = new CustomControls.CustomDateTimePicker();
            label3 = new Label();
            label1 = new Label();
            cdtp_monrday_endDate = new CustomControls.CustomDateTimePicker();
            cdtp_sunday_endDate = new CustomControls.CustomDateTimePicker();
            cdtp_saturday_endDate = new CustomControls.CustomDateTimePicker();
            chb_monday = new CheckBox();
            cdtp_monrday_startDate = new CustomControls.CustomDateTimePicker();
            chb_sunday = new CheckBox();
            cdtp_sunday_startDate = new CustomControls.CustomDateTimePicker();
            chb_saturday = new CheckBox();
            cdtp_saturday_startDate = new CustomControls.CustomDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            pnl_addSchedule.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_schedules
            // 
            lbl_schedules.AutoSize = true;
            lbl_schedules.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_schedules.ForeColor = Color.FromArgb(10, 22, 41);
            lbl_schedules.Location = new Point(14, 93);
            lbl_schedules.Name = "lbl_schedules";
            lbl_schedules.Size = new Size(245, 62);
            lbl_schedules.TabIndex = 13;
            lbl_schedules.Text = "Schedules";
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(27, 27);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(412, 48);
            pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox9.TabIndex = 16;
            pictureBox9.TabStop = false;
            // 
            // csb_addSchedule
            // 
            csb_addSchedule.BackColor = Color.FromArgb(70, 95, 241);
            csb_addSchedule.BorderColor = Color.Black;
            csb_addSchedule.BorderRadius = 10;
            csb_addSchedule.BorderSize = 0;
            csb_addSchedule.Cursor = Cursors.Hand;
            csb_addSchedule.FlatAppearance.BorderSize = 0;
            csb_addSchedule.FlatStyle = FlatStyle.Flat;
            csb_addSchedule.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            csb_addSchedule.ForeColor = Color.White;
            csb_addSchedule.Image = (Image)resources.GetObject("csb_addSchedule.Image");
            csb_addSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            csb_addSchedule.Location = new Point(720, 155);
            csb_addSchedule.Name = "csb_addSchedule";
            csb_addSchedule.Padding = new Padding(25, 0, 0, 0);
            csb_addSchedule.Size = new Size(218, 50);
            csb_addSchedule.TabIndex = 86;
            csb_addSchedule.Text = "  Add Schedule";
            csb_addSchedule.UseVisualStyleBackColor = false;
            csb_addSchedule.Click += csb_addSchedule_Click;
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
            btn_back.Location = new Point(27, 194);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(190, 29);
            btn_back.TabIndex = 87;
            btn_back.Text = "      Back to Schedules";
            btn_back.TextAlign = ContentAlignment.MiddleLeft;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Visible = false;
            btn_back.Click += btn_back_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(55, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 86;
            label2.Text = "Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(55, 151);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(96, 23);
            label9.TabIndex = 90;
            label9.Text = "Description";
            // 
            // ctxt_name
            // 
            ctxt_name.BackColor = Color.White;
            ctxt_name.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_name.BorderFocusColor = Color.FromArgb(230, 230, 230);
            ctxt_name.BorderSize = 1;
            ctxt_name.Font = new Font("Segoe UI", 9F);
            ctxt_name.ForeColor = Color.DimGray;
            ctxt_name.Location = new Point(55, 59);
            ctxt_name.Multiline = false;
            ctxt_name.Name = "ctxt_name";
            ctxt_name.Padding = new Padding(13);
            ctxt_name.PasswordChar = false;
            ctxt_name.Size = new Size(296, 47);
            ctxt_name.TabIndex = 84;
            ctxt_name.UnderlinedStyle = false;
            // 
            // ctxt_description
            // 
            ctxt_description.BackColor = Color.White;
            ctxt_description.BorderColor = Color.FromArgb(230, 230, 230);
            ctxt_description.BorderFocusColor = Color.FromArgb(230, 230, 230);
            ctxt_description.BorderSize = 1;
            ctxt_description.Font = new Font("Segoe UI", 9F);
            ctxt_description.ForeColor = Color.DimGray;
            ctxt_description.Location = new Point(55, 178);
            ctxt_description.Multiline = true;
            ctxt_description.Name = "ctxt_description";
            ctxt_description.Padding = new Padding(13);
            ctxt_description.PasswordChar = false;
            ctxt_description.Size = new Size(297, 232);
            ctxt_description.TabIndex = 101;
            ctxt_description.UnderlinedStyle = false;
            // 
            // cbtn_add
            // 
            cbtn_add.BackColor = Color.FromArgb(70, 95, 241);
            cbtn_add.BorderColor = Color.Black;
            cbtn_add.BorderRadius = 10;
            cbtn_add.BorderSize = 0;
            cbtn_add.Cursor = Cursors.Hand;
            cbtn_add.FlatAppearance.BorderSize = 0;
            cbtn_add.FlatStyle = FlatStyle.Flat;
            cbtn_add.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbtn_add.ForeColor = Color.White;
            cbtn_add.ImageAlign = ContentAlignment.MiddleLeft;
            cbtn_add.Location = new Point(346, 524);
            cbtn_add.Name = "cbtn_add";
            cbtn_add.Size = new Size(213, 50);
            cbtn_add.TabIndex = 106;
            cbtn_add.Text = "Add";
            cbtn_add.UseVisualStyleBackColor = false;
            cbtn_add.Click += cbtn_add_Click;
            // 
            // pnl_addSchedule
            // 
            pnl_addSchedule.Controls.Add(cdtp_wednesday_startDate);
            pnl_addSchedule.Controls.Add(cdtp_friday_endDate);
            pnl_addSchedule.Controls.Add(chb_friday);
            pnl_addSchedule.Controls.Add(cdtp_friday_startDate);
            pnl_addSchedule.Controls.Add(cdtp_Thurday_endDate);
            pnl_addSchedule.Controls.Add(cdtp_wednesday_endDate);
            pnl_addSchedule.Controls.Add(cdtp_Tuesday_endDate);
            pnl_addSchedule.Controls.Add(chb_thursday);
            pnl_addSchedule.Controls.Add(cdtp_Thurday_startDate);
            pnl_addSchedule.Controls.Add(chb_wednesday);
            pnl_addSchedule.Controls.Add(chb_tuesday);
            pnl_addSchedule.Controls.Add(cdtp_Tuesday_startDate);
            pnl_addSchedule.Controls.Add(label3);
            pnl_addSchedule.Controls.Add(label1);
            pnl_addSchedule.Controls.Add(cdtp_monrday_endDate);
            pnl_addSchedule.Controls.Add(cdtp_sunday_endDate);
            pnl_addSchedule.Controls.Add(cdtp_saturday_endDate);
            pnl_addSchedule.Controls.Add(chb_monday);
            pnl_addSchedule.Controls.Add(cdtp_monrday_startDate);
            pnl_addSchedule.Controls.Add(chb_sunday);
            pnl_addSchedule.Controls.Add(cdtp_sunday_startDate);
            pnl_addSchedule.Controls.Add(chb_saturday);
            pnl_addSchedule.Controls.Add(cdtp_saturday_startDate);
            pnl_addSchedule.Controls.Add(cbtn_add);
            pnl_addSchedule.Controls.Add(ctxt_description);
            pnl_addSchedule.Controls.Add(ctxt_name);
            pnl_addSchedule.Controls.Add(label9);
            pnl_addSchedule.Controls.Add(label2);
            pnl_addSchedule.Font = new Font("Segoe UI", 11F);
            pnl_addSchedule.ForeColor = Color.DimGray;
            pnl_addSchedule.Location = new Point(27, 222);
            pnl_addSchedule.Margin = new Padding(2);
            pnl_addSchedule.Name = "pnl_addSchedule";
            pnl_addSchedule.Size = new Size(914, 614);
            pnl_addSchedule.TabIndex = 88;
            // 
            // cdtp_wednesday_startDate
            // 
            cdtp_wednesday_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_wednesday_startDate.BorderSize = 0;
            cdtp_wednesday_startDate.CustomFormat = "hh:mm:ss tt";
            cdtp_wednesday_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_wednesday_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_wednesday_startDate.Location = new Point(527, 296);
            cdtp_wednesday_startDate.MinimumSize = new Size(0, 46);
            cdtp_wednesday_startDate.Name = "cdtp_wednesday_startDate";
            cdtp_wednesday_startDate.ShowUpDown = true;
            cdtp_wednesday_startDate.Size = new Size(177, 46);
            cdtp_wednesday_startDate.SkinColor = Color.White;
            cdtp_wednesday_startDate.TabIndex = 120;
            cdtp_wednesday_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // cdtp_friday_endDate
            // 
            cdtp_friday_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_friday_endDate.BorderSize = 0;
            cdtp_friday_endDate.CustomFormat = "hh:mm:ss tt";
            cdtp_friday_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_friday_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_friday_endDate.Location = new Point(710, 414);
            cdtp_friday_endDate.MinimumSize = new Size(0, 46);
            cdtp_friday_endDate.Name = "cdtp_friday_endDate";
            cdtp_friday_endDate.ShowUpDown = true;
            cdtp_friday_endDate.Size = new Size(177, 46);
            cdtp_friday_endDate.SkinColor = Color.White;
            cdtp_friday_endDate.TabIndex = 129;
            cdtp_friday_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // chb_friday
            // 
            chb_friday.AutoSize = true;
            chb_friday.Location = new Point(402, 420);
            chb_friday.Name = "chb_friday";
            chb_friday.Size = new Size(85, 29);
            chb_friday.TabIndex = 128;
            chb_friday.Text = "Friday";
            chb_friday.UseVisualStyleBackColor = true;
            // 
            // cdtp_friday_startDate
            // 
            cdtp_friday_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_friday_startDate.BorderSize = 0;
            cdtp_friday_startDate.CustomFormat = "hh:mm:ss tt";
            cdtp_friday_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_friday_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_friday_startDate.Location = new Point(527, 414);
            cdtp_friday_startDate.MinimumSize = new Size(0, 46);
            cdtp_friday_startDate.Name = "cdtp_friday_startDate";
            cdtp_friday_startDate.ShowUpDown = true;
            cdtp_friday_startDate.Size = new Size(177, 46);
            cdtp_friday_startDate.SkinColor = Color.White;
            cdtp_friday_startDate.TabIndex = 127;
            cdtp_friday_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // cdtp_Thurday_endDate
            // 
            cdtp_Thurday_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_Thurday_endDate.BorderSize = 0;
            cdtp_Thurday_endDate.CustomFormat = "hh:mm:ss tt";
            cdtp_Thurday_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_Thurday_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_Thurday_endDate.Location = new Point(710, 355);
            cdtp_Thurday_endDate.MinimumSize = new Size(0, 46);
            cdtp_Thurday_endDate.Name = "cdtp_Thurday_endDate";
            cdtp_Thurday_endDate.ShowUpDown = true;
            cdtp_Thurday_endDate.Size = new Size(177, 46);
            cdtp_Thurday_endDate.SkinColor = Color.White;
            cdtp_Thurday_endDate.TabIndex = 126;
            cdtp_Thurday_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // cdtp_wednesday_endDate
            // 
            cdtp_wednesday_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_wednesday_endDate.BorderSize = 0;
            cdtp_wednesday_endDate.CustomFormat = "hh:mm:ss tt";
            cdtp_wednesday_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_wednesday_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_wednesday_endDate.Location = new Point(710, 296);
            cdtp_wednesday_endDate.MinimumSize = new Size(0, 46);
            cdtp_wednesday_endDate.Name = "cdtp_wednesday_endDate";
            cdtp_wednesday_endDate.ShowUpDown = true;
            cdtp_wednesday_endDate.Size = new Size(177, 46);
            cdtp_wednesday_endDate.SkinColor = Color.White;
            cdtp_wednesday_endDate.TabIndex = 125;
            cdtp_wednesday_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // cdtp_Tuesday_endDate
            // 
            cdtp_Tuesday_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_Tuesday_endDate.BorderSize = 0;
            cdtp_Tuesday_endDate.CustomFormat = "hh:mm:ss tt";
            cdtp_Tuesday_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_Tuesday_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_Tuesday_endDate.Location = new Point(710, 237);
            cdtp_Tuesday_endDate.MinimumSize = new Size(0, 46);
            cdtp_Tuesday_endDate.Name = "cdtp_Tuesday_endDate";
            cdtp_Tuesday_endDate.ShowUpDown = true;
            cdtp_Tuesday_endDate.Size = new Size(177, 46);
            cdtp_Tuesday_endDate.SkinColor = Color.White;
            cdtp_Tuesday_endDate.TabIndex = 124;
            cdtp_Tuesday_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // chb_thursday
            // 
            chb_thursday.AutoSize = true;
            chb_thursday.Location = new Point(402, 361);
            chb_thursday.Name = "chb_thursday";
            chb_thursday.Size = new Size(111, 29);
            chb_thursday.TabIndex = 123;
            chb_thursday.Text = "Thursday";
            chb_thursday.UseVisualStyleBackColor = true;
            // 
            // cdtp_Thurday_startDate
            // 
            cdtp_Thurday_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_Thurday_startDate.BorderSize = 0;
            cdtp_Thurday_startDate.CustomFormat = "hh:mm:ss tt";
            cdtp_Thurday_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_Thurday_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_Thurday_startDate.Location = new Point(527, 355);
            cdtp_Thurday_startDate.MinimumSize = new Size(0, 46);
            cdtp_Thurday_startDate.Name = "cdtp_Thurday_startDate";
            cdtp_Thurday_startDate.ShowUpDown = true;
            cdtp_Thurday_startDate.Size = new Size(177, 46);
            cdtp_Thurday_startDate.SkinColor = Color.White;
            cdtp_Thurday_startDate.TabIndex = 122;
            cdtp_Thurday_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // chb_wednesday
            // 
            chb_wednesday.AutoSize = true;
            chb_wednesday.BackColor = Color.Transparent;
            chb_wednesday.Location = new Point(402, 302);
            chb_wednesday.Name = "chb_wednesday";
            chb_wednesday.Size = new Size(131, 29);
            chb_wednesday.TabIndex = 121;
            chb_wednesday.Text = "Wednesday";
            chb_wednesday.UseVisualStyleBackColor = false;
            // 
            // chb_tuesday
            // 
            chb_tuesday.AutoSize = true;
            chb_tuesday.Location = new Point(402, 243);
            chb_tuesday.Name = "chb_tuesday";
            chb_tuesday.Size = new Size(103, 29);
            chb_tuesday.TabIndex = 119;
            chb_tuesday.Text = "Tuesday";
            chb_tuesday.UseVisualStyleBackColor = true;
            // 
            // cdtp_Tuesday_startDate
            // 
            cdtp_Tuesday_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_Tuesday_startDate.BorderSize = 0;
            cdtp_Tuesday_startDate.CustomFormat = "hh:mm:ss tt";
            cdtp_Tuesday_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_Tuesday_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_Tuesday_startDate.Location = new Point(527, 237);
            cdtp_Tuesday_startDate.MinimumSize = new Size(0, 46);
            cdtp_Tuesday_startDate.Name = "cdtp_Tuesday_startDate";
            cdtp_Tuesday_startDate.ShowUpDown = true;
            cdtp_Tuesday_startDate.Size = new Size(177, 46);
            cdtp_Tuesday_startDate.SkinColor = Color.White;
            cdtp_Tuesday_startDate.TabIndex = 118;
            cdtp_Tuesday_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(755, 32);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 23);
            label3.TabIndex = 117;
            label3.Text = "End Time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(566, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 116;
            label1.Text = "Start Time";
            // 
            // cdtp_monrday_endDate
            // 
            cdtp_monrday_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_monrday_endDate.BorderSize = 0;
            cdtp_monrday_endDate.CustomFormat = "hh:mm:ss tt";
            cdtp_monrday_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_monrday_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_monrday_endDate.Location = new Point(710, 178);
            cdtp_monrday_endDate.MinimumSize = new Size(0, 46);
            cdtp_monrday_endDate.Name = "cdtp_monrday_endDate";
            cdtp_monrday_endDate.ShowUpDown = true;
            cdtp_monrday_endDate.Size = new Size(177, 46);
            cdtp_monrday_endDate.SkinColor = Color.White;
            cdtp_monrday_endDate.TabIndex = 115;
            cdtp_monrday_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // cdtp_sunday_endDate
            // 
            cdtp_sunday_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_sunday_endDate.BorderSize = 0;
            cdtp_sunday_endDate.CustomFormat = "hh:mm:ss tt";
            cdtp_sunday_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_sunday_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_sunday_endDate.Location = new Point(710, 119);
            cdtp_sunday_endDate.MinimumSize = new Size(0, 46);
            cdtp_sunday_endDate.Name = "cdtp_sunday_endDate";
            cdtp_sunday_endDate.ShowUpDown = true;
            cdtp_sunday_endDate.Size = new Size(177, 46);
            cdtp_sunday_endDate.SkinColor = Color.White;
            cdtp_sunday_endDate.TabIndex = 114;
            cdtp_sunday_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // cdtp_saturday_endDate
            // 
            cdtp_saturday_endDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_saturday_endDate.BorderSize = 0;
            cdtp_saturday_endDate.CustomFormat = "hh:mm:ss tt";
            cdtp_saturday_endDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_saturday_endDate.Format = DateTimePickerFormat.Custom;
            cdtp_saturday_endDate.Location = new Point(710, 60);
            cdtp_saturday_endDate.MinimumSize = new Size(0, 46);
            cdtp_saturday_endDate.Name = "cdtp_saturday_endDate";
            cdtp_saturday_endDate.ShowUpDown = true;
            cdtp_saturday_endDate.Size = new Size(177, 46);
            cdtp_saturday_endDate.SkinColor = Color.White;
            cdtp_saturday_endDate.TabIndex = 113;
            cdtp_saturday_endDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // chb_monday
            // 
            chb_monday.AutoSize = true;
            chb_monday.Location = new Point(402, 184);
            chb_monday.Name = "chb_monday";
            chb_monday.Size = new Size(103, 29);
            chb_monday.TabIndex = 112;
            chb_monday.Text = "Monday";
            chb_monday.UseVisualStyleBackColor = true;
            // 
            // cdtp_monrday_startDate
            // 
            cdtp_monrday_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_monrday_startDate.BorderSize = 0;
            cdtp_monrday_startDate.CustomFormat = "hh:mm:ss tt";
            cdtp_monrday_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_monrday_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_monrday_startDate.Location = new Point(527, 178);
            cdtp_monrday_startDate.MinimumSize = new Size(0, 46);
            cdtp_monrday_startDate.Name = "cdtp_monrday_startDate";
            cdtp_monrday_startDate.ShowUpDown = true;
            cdtp_monrday_startDate.Size = new Size(177, 46);
            cdtp_monrday_startDate.SkinColor = Color.White;
            cdtp_monrday_startDate.TabIndex = 111;
            cdtp_monrday_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // chb_sunday
            // 
            chb_sunday.AutoSize = true;
            chb_sunday.Location = new Point(402, 125);
            chb_sunday.Name = "chb_sunday";
            chb_sunday.Size = new Size(96, 29);
            chb_sunday.TabIndex = 110;
            chb_sunday.Text = "Sunday";
            chb_sunday.UseVisualStyleBackColor = true;
            // 
            // cdtp_sunday_startDate
            // 
            cdtp_sunday_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_sunday_startDate.BorderSize = 0;
            cdtp_sunday_startDate.CustomFormat = "hh:mm:ss tt";
            cdtp_sunday_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_sunday_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_sunday_startDate.Location = new Point(527, 119);
            cdtp_sunday_startDate.MinimumSize = new Size(0, 46);
            cdtp_sunday_startDate.Name = "cdtp_sunday_startDate";
            cdtp_sunday_startDate.ShowUpDown = true;
            cdtp_sunday_startDate.Size = new Size(177, 46);
            cdtp_sunday_startDate.SkinColor = Color.White;
            cdtp_sunday_startDate.TabIndex = 109;
            cdtp_sunday_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // chb_saturday
            // 
            chb_saturday.AutoSize = true;
            chb_saturday.Location = new Point(402, 66);
            chb_saturday.Name = "chb_saturday";
            chb_saturday.Size = new Size(108, 29);
            chb_saturday.TabIndex = 108;
            chb_saturday.Text = "Saturday";
            chb_saturday.UseVisualStyleBackColor = true;
            // 
            // cdtp_saturday_startDate
            // 
            cdtp_saturday_startDate.BorderColor = Color.FromArgb(181, 191, 249);
            cdtp_saturday_startDate.BorderSize = 0;
            cdtp_saturday_startDate.CustomFormat = "hh:mm:ss tt";
            cdtp_saturday_startDate.Font = new Font("Segoe UI", 9.5F);
            cdtp_saturday_startDate.Format = DateTimePickerFormat.Custom;
            cdtp_saturday_startDate.Location = new Point(527, 60);
            cdtp_saturday_startDate.MinimumSize = new Size(0, 46);
            cdtp_saturday_startDate.Name = "cdtp_saturday_startDate";
            cdtp_saturday_startDate.ShowUpDown = true;
            cdtp_saturday_startDate.Size = new Size(177, 46);
            cdtp_saturday_startDate.SkinColor = Color.White;
            cdtp_saturday_startDate.TabIndex = 107;
            cdtp_saturday_startDate.TextColor = Color.FromArgb(10, 22, 41);
            // 
            // Scedual_details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(972, 853);
            Controls.Add(pnl_addSchedule);
            Controls.Add(btn_back);
            Controls.Add(csb_addSchedule);
            Controls.Add(pictureBox9);
            Controls.Add(lbl_schedules);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Scedual_details";
            Text = "Scedual_details";
            Load += Scedual_details_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            pnl_addSchedule.ResumeLayout(false);
            pnl_addSchedule.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_schedules;
        private PictureBox pictureBox9;
        private ComboBox cb_summaryType;
        private CustomControls.CustomButton csb_addSchedule;
        private Button btn_back;
        private Label label2;
        private Label label9;
        private CustomControls.CustomTextBox ctxt_name;
        private CustomControls.CustomTextBox ctxt_description;
        private CustomControls.CustomButton cbtn_add;
        private Panel pnl_addSchedule;
        private CustomControls.CustomDateTimePicker cdtp_saturday_startDate;
        private CheckBox chb_monday;
        private CustomControls.CustomDateTimePicker cdtp_monrday_startDate;
        private CheckBox chb_sunday;
        private CustomControls.CustomDateTimePicker cdtp_sunday_startDate;
        private CheckBox chb_saturday;
        private CustomControls.CustomDateTimePicker cdtp_friday_endDate;
        private CheckBox chb_friday;
        private CustomControls.CustomDateTimePicker cdtp_friday_startDate;
        private CustomControls.CustomDateTimePicker cdtp_Thurday_endDate;
        private CustomControls.CustomDateTimePicker cdtp_wednesday_endDate;
        private CustomControls.CustomDateTimePicker cdtp_Tuesday_endDate;
        private CheckBox chb_thursday;
        private CustomControls.CustomDateTimePicker cdtp_Thurday_startDate;
        private CheckBox chb_wednesday;
        private CustomControls.CustomDateTimePicker cdtp_wednesday_startDate;
        private CheckBox chb_tuesday;
        private CustomControls.CustomDateTimePicker cdtp_Tuesday_startDate;
        private Label label3;
        private Label label1;
        private CustomControls.CustomDateTimePicker cdtp_monrday_endDate;
        private CustomControls.CustomDateTimePicker cdtp_sunday_endDate;
        private CustomControls.CustomDateTimePicker cdtp_saturday_endDate;
    }
}