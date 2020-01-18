﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sports4All
{
    class LabelX : Label
    {
     private string label { get; set; }

        public LabelX(string info)
        {
            this.Text = label = info;
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            Point drawPoint = new Point(0, 0);

            string[] ary = Text.Split(new char[] { '|' });
            if (ary.Length == 2)
            {
                Font normalFont = this.Font;

                Font boldFont = new Font(normalFont, FontStyle.Bold);

                Size boldSize = TextRenderer.MeasureText(ary[0], boldFont);
                Size normalSize = TextRenderer.MeasureText(ary[1], normalFont);

                Rectangle boldRect = new Rectangle(drawPoint, boldSize);
                Rectangle normalRect = new Rectangle(
                    boldRect.Right, boldRect.Top, normalSize.Width, normalSize.Height);

                TextRenderer.DrawText(e.Graphics, ary[0], boldFont, boldRect, ForeColor);
                TextRenderer.DrawText(e.Graphics, ary[1], normalFont, normalRect, ForeColor);
            }
            else
            {

                TextRenderer.DrawText(e.Graphics, Text, Font, drawPoint, ForeColor);
            }
        }
    }
}
