using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.Presentation.CustomControls
{
    public  class BottomBorderPanel : Panel
    {
        private Color _borderColor = Color.Black; // Default border color
        private int _borderThickness = 2; // Default border thickness

        // BorderColor property with serialization attributes
        [Category("Appearance")] // Adds the property to the "Appearance" category in the designer
        [Description("The color of the bottom border.")] // Description shown in the designer
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // Ensures the property is serialized
        [DefaultValue(typeof(Color), "Black")] // Default value for the property
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate(); // Redraw the panel when the border color changes
            }
        }

        // BorderThickness property with serialization attributes
        [Category("Appearance")] // Adds the property to the "Appearance" category in the designer
        [Description("The thickness of the bottom border.")] // Description shown in the designer
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)] // Ensures the property is serialized
        [DefaultValue(2)] // Default value for the property
        public int BorderThickness
        {
            get { return _borderThickness; }
            set
            {
                _borderThickness = value;
                this.Invalidate(); // Redraw the panel when the border thickness changes
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the bottom border
            using (Pen pen = new Pen(BorderColor, BorderThickness))
            {
                int y = this.Height - BorderThickness; // Bottom edge of the panel
                e.Graphics.DrawLine(pen, 0, y, this.Width, y);
            }
        }
    }
}
