namespace AttendEase.Presentation
{
    partial class QrReaderForm
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
            components = new System.ComponentModel.Container();
            pic_qr = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_qr).BeginInit();
            SuspendLayout();
            // 
            // pic_qr
            // 
            pic_qr.Location = new Point(12, 12);
            pic_qr.Name = "pic_qr";
            pic_qr.Size = new Size(719, 650);
            pic_qr.TabIndex = 0;
            pic_qr.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(0, 126, 249);
            button2.Location = new Point(226, 690);
            button2.Name = "button2";
            button2.Size = new Size(269, 47);
            button2.TabIndex = 29;
            button2.Text = "Check QR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // QrReaderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(743, 762);
            Controls.Add(button2);
            Controls.Add(pic_qr);
            Name = "QrReaderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QrReaderForm";
            FormClosing += Form1_FormClosing;
            Load += QrReaderForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pic_qr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_qr;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
    }
}