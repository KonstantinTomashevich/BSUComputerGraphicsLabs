using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    class CircleBresenhamDrawTool : CircleDrawTool
    {
        public CircleBresenhamDrawTool(Bitmap bitmap, NumericUpDown alphaInput,
            NumericUpDown rInput, NumericUpDown gInput, 
            NumericUpDown bInput, NumericUpDown radiusInput) :
            base(bitmap, alphaInput, rInput, gInput, bInput, radiusInput)
        {
        }

        private void DrawStep(int xc, int yc, int x, int y, Color color)
        {
            SetPixel(xc + x, yc + y, color);
            SetPixel(xc - x, yc + y, color);
            SetPixel(xc + x, yc - y, color);
            SetPixel(xc - x, yc - y, color);
            SetPixel(xc + y, yc + x, color);
            SetPixel(xc - y, yc + x, color);
            SetPixel(xc + y, yc - x, color);
            SetPixel(xc - y, yc - x, color);
        }

        protected override void DrawCircle(int centerX, int centerY, int radius)
        {
            BeginDraw();
            Color color = GetColor();

            int x = 0, y = radius;
            int decesionParameter = 3 - 2 * radius;
            DrawStep(centerX, centerY, x, y, color);

            while (y >= x)
            {
                x++;
                if (decesionParameter > 0)
                {
                    y--;
                    decesionParameter = decesionParameter + 4 * (x - y) + 10;
                }
                else
                {
                    decesionParameter = decesionParameter + 4 * x + 6;
                }

                DrawStep(centerX, centerY, x, y, color);
            }

            EndDraw();
        }
    }
}
