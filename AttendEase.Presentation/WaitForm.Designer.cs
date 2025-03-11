namespace AttendEase.Presentation
{
    partial class WaitForm
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Image = Properties.Resources.Spin_1x_01;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 0, 0, 50);
            label1.Size = new Size(800, 396);
            label1.TabIndex = 0;
            label1.Text = "Please Wait . . .";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // WaitForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 396);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WaitForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "WaitForm";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}