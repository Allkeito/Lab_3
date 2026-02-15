using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinButNum
{
    
    public class ClickButton : Button
    {
        int mClicks = 0;

        public int Clicks
        {
            get { return mClicks; }
        }

        protected override void OnClick(EventArgs e)
        {
            mClicks++;
            this.Invalidate(); 
            base.OnClick(e);
        }

        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics g = pevent.Graphics;

            string text = Clicks.ToString();
            
            SizeF stringsize = g.MeasureString(text, this.Font);

            g.DrawString(text, this.Font,
                SystemBrushes.ControlText,
                this.Width - stringsize.Width - 3,
                this.Height - stringsize.Height - 3);
        }
    }
}
