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
            pic_qr = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_qr).BeginInit();
            SuspendLayout();
            // 
            // pic_qr
            // 
            pic_qr.Location = new Point(12, 12);
            pic_qr.Name = "pic_qr";
            pic_qr.Size = new Size(719, 738);
            pic_qr.TabIndex = 0;
            pic_qr.TabStop = false;
            // 
            // QrReaderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 248, 252);
            ClientSize = new Size(743, 762);
            Controls.Add(pic_qr);
            Name = "QrReaderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QrReaderForm";
            FormClosing += QrReaderForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pic_qr).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_qr;
    }
}