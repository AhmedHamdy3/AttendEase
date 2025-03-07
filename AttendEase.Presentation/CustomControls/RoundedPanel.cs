using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.Presentation.CustomControls
{
    public class RoundedPanel : Panel
    {
        // Properties for customization
        public Color BorderColor = Color.White; // Default border color
        public int BorderRadius = 10; // Default border radius
        public int BorderThickness = 0; // Default border thickness
        public Color HoverColor = Color.LightGray; // Color when hovered
        public Color ClickColor = Color.Gray; // Color when clicked

        private bool _isHovered = false;
        private bool _isClicked = false;

        public RoundedPanel()
        {
            // Enable double buffering to reduce flicker
            this.DoubleBuffered = true;

            // Handle mouse events
            this.MouseEnter += (sender, e) => { _isHovered = true; this.Invalidate(); };
            this.MouseLeave += (sender, e) => { _isHovered = false; this.Invalidate(); };
            this.MouseDown += (sender, e) => { _isClicked = true; this.Invalidate(); };
            this.MouseUp += (sender, e) => { _isClicked = false; this.Invalidate(); };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a graphics path with rounded corners
            GraphicsPath path = new GraphicsPath();
            int radius = BorderRadius;
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

            // Add rounded corners to the path
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // Top-left corner
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90); // Top-right corner
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90); // Bottom-right corner
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the panel's region to the rounded rectangle
            this.Region = new Region(path);

            // Fill the background with the appropriate color
            Color backgroundColor = this.BackColor;
            if (_isClicked)
                backgroundColor = ClickColor;
            else if (_isHovered)
                backgroundColor = HoverColor;

            using (SolidBrush brush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Draw the border
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
