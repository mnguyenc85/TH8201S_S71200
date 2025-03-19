using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH8201S.UserControls
{
    public class MyCustomPanel: Panel
    {
        Pen pen1 = new Pen(Brushes.DodgerBlue, 1);

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            
            Rectangle fill_rect = new Rectangle(0, 0, Width, Height);
            Rectangle border_rect = new Rectangle(0, 0, Width - 1, Height - 1);

            Brush br = new LinearGradientBrush(fill_rect, Color.FromArgb(227, 239, 255), Color.FromArgb(175, 210, 255), 90f);

            e.Graphics.FillRectangle(br, fill_rect);
            e.Graphics.DrawRectangle(pen1, border_rect);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        }
    }
}
