using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    class LineDDADrawTool : LineDrawTool
    {
        public LineDDADrawTool(Bitmap bitmap, 
            NumericUpDown alphaInput, NumericUpDown rInput, 
            NumericUpDown gInput, NumericUpDown bInput) : 
            base(bitmap, alphaInput, rInput, gInput, bInput)
        {
        }

        protected override void DrawLine(int firstX, int firstY, int x, int y)
        {
            BeginDraw();
            int dx = x - firstX;
            int dy = y - firstY;
            int length = Math.Max(Math.Abs(dx), Math.Abs(dy));

            Color color = GetColor();
            float xStep = (float) dx / length;
            float yStep = (float) dy / length;

            for (int index = 0; index <= length; ++index)
            {
                SetPixel((int) Math.Round(firstX + index * xStep), (int) Math.Round(firstY + index * yStep), color);
            }

            EndDraw();
        }
    }
}
