using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    class LineMidpointDrawTool : LineDrawTool
    {
        public LineMidpointDrawTool(Bitmap bitmap, 
            NumericUpDown alphaInput, NumericUpDown rInput, 
            NumericUpDown gInput, NumericUpDown bInput) : 
            base(bitmap, alphaInput, rInput, gInput, bInput)
        {
        }

        protected override void DrawLine(int firstX, int firstY, int x, int y)
        {
            if (firstX > x)
            {
                DrawLine(x, y, firstX, firstY);
                return;
            }

            BeginDraw();
            int slope;
            Color color = GetColor();

            int dx = x - firstX;
            int dy = y - firstY;
            int d = dx - 2 * dy;
            int currentY = firstY;

            if (dy < 0)
            {
                slope = -1;
                dy = -dy;
            }
            else
            {
                slope = 1;
            }

            for (int currentX = firstX; currentX <= x; currentX++)
            {
                SetPixel(currentX, currentY, color);
                if (d <= 0)
                {
                    d += 2 * dx - 2 * dy;
                    currentY += slope;
                }
                else
                {
                    d += -2 * dy;
                }
            }

            EndDraw();
        }
    }
}
