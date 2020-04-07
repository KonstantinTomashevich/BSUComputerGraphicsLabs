using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    class CircleMidpointDrawTool : CircleDrawTool
    {
        public CircleMidpointDrawTool(Bitmap bitmap, NumericUpDown alphaInput,
            NumericUpDown rInput, NumericUpDown gInput,
            NumericUpDown bInput, NumericUpDown radiusInput) :
            base(bitmap, alphaInput, rInput, gInput, bInput, radiusInput)
        {
        }

        protected override void DrawCircle(int centerX, int centerY, int radius)
        {
            BeginDraw();
            int d = (5 - radius * 4) / 4;
            int x = 0;
            int y = radius;
            Color color = GetColor();

            do
            {
                SetPixel(centerX + x, centerY + y, color);
                SetPixel(centerX + x, centerY - y, color);
                SetPixel(centerX - x, centerY + y, color);
                SetPixel(centerX - x, centerY - y, color);
                SetPixel(centerX + y, centerY + x, color);
                SetPixel(centerX + y, centerY - x, color);
                SetPixel(centerX - y, centerY + x, color);
                SetPixel(centerX - y, centerY - x, color);

                if (d < 0)
                {
                    d += 2 * x + 1;
                }
                else
                {
                    d += 2 * (x - y) + 1;
                    y--;
                }

                x++;
            } while (x <= y);
            EndDraw();
        }
    }
}
