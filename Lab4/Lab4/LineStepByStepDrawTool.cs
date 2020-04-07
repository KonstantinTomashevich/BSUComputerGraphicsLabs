using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    class LineStepByStepDrawTool : LineDrawTool
    {
        public LineStepByStepDrawTool(Bitmap bitmap, 
            NumericUpDown alphaInput, NumericUpDown rInput, 
            NumericUpDown gInput, NumericUpDown bInput) : 
            base(bitmap, alphaInput, rInput, gInput, bInput)
        {
        }

        protected override void DrawLine(int firstX, int firstY, int x, int y)
        {
            Color color = GetColor();
            BeginDraw();
            if (firstX == x)
            {
                int step = y > firstY ? 1 : -1;
                for (int currentY = firstY; currentY != y; currentY += step)
                {
                    SetPixel(x, currentY, color);
                }

                SetPixel(x, y, color);
                EndDraw();
                return;
            }

            int length = Math.Max(Math.Abs(x - firstX), Math.Abs(y - firstY));
            float k = (float)(y - firstY) / (x - firstX);
            float b = firstY;

            for (int index = 0; index <= length; ++index)
            {
                float currentX = firstX + (x - firstX) * ((float) index / length);
                float currentY = k * (currentX - firstX) + b;
                SetPixel((int)Math.Round(currentX), (int)Math.Round(currentY), color);
            }

            EndDraw();
        }
    }
}
