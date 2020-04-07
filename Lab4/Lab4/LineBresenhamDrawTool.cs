using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    class LineBresenhamDrawTool : LineDrawTool
    {
        public LineBresenhamDrawTool(Bitmap bitmap, 
            NumericUpDown alphaInput, NumericUpDown rInput, 
            NumericUpDown gInput, NumericUpDown bInput) : 
            base(bitmap, alphaInput, rInput, gInput, bInput)
        {
        }

        protected override void DrawLine(int firstX, int firstY, int x, int y)
        {
            BeginDraw();
            Color color = GetColor();

            int dx = Math.Abs(x - firstX);
            int sx = firstX < x ? 1 : -1;

            int dy = Math.Abs(y - firstY);
            int sy = firstY < y ? 1 : -1;

            int err = (dx > dy ? dx : -dy) / 2;
            int e2 = 0;

            int currentX = firstX;
            int currentY = firstY;

            while(true)
            {
                SetPixel(currentX, currentY, color);
                if (currentX == x && currentY == y)
                {
                    break;
                }

                e2 = err;
                if (e2 > -dx)
                {
                    err -= dy; currentX += sx;
                }

                if (e2 < dy)
                {
                    err += dx; currentY += sy;
                }
            }

            EndDraw();
        }
    }
}
