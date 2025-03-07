using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AttendEase.Presentation.CustomControls
{
    public class ProfileImage : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Create a graphics path to define a circle
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width - 1, this.Height - 1);

            // Set the clipping region to the circular path
            this.Region = new Region(path);

            // Call the base OnPaint method to draw the image
            base.OnPaint(pe);
        }
    }
}
