using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    class LineByDrawTool : LineDrawTool
    {
        public LineByDrawTool(Bitmap bitmap, 
            NumericUpDown alphaInput, NumericUpDown rInput, 
            NumericUpDown gInput, NumericUpDown bInput) : 
            base(bitmap, alphaInput, rInput, gInput, bInput)
        {
        }

        private void Plot(double x, double y, double c)
        {
            c = Math.Max(0.0, Math.Min(c, 1.0));
            Color initial = GetColor();
            Color background = GetPixel((int) x, (int) y);

            Color color = Color.FromArgb(255, (byte) (initial.R * c + background.R * (1.0 - c)),
                (byte) (initial.G * c + background.G * (1.0 - c)), (byte) (initial.B * c + background.B * (1.0 - c)));
            SetPixel((int) x, (int) y, color);
        }

        private int IPart(double x) { return (int)x; }

        private double FPart(double x)
        {
            if (x < 0) return (1 - (x - Math.Floor(x)));
            return (x - Math.Floor(x));
        }

        private double RFPart(double x)
        {
            return 1 - FPart(x);
        }

        protected override void DrawLine(int firstX, int firstY, int x, int y)
        {
            BeginDraw();
            bool steep = Math.Abs(y - firstY) > Math.Abs(x - firstX);

            if (steep)
            {
                int temp;
                temp = firstX;
                firstX = firstY;
                firstY = temp;

                temp = x;
                x = y;
                y = temp;
            }

            if (firstX > x)
            {
                int temp;
                temp = firstX;
                firstX = x;
                x = temp;

                temp = firstY;
                firstY = y;
                y = temp;
            }

            double dx = x - firstX;
            double dy = y - firstY;
            double gradient = dy / dx;

            double xEnd = Math.Round((double) firstX);
            double yEnd = firstY + gradient * (xEnd - firstX);
            double xGap = RFPart(firstX + 0.5);
            double xPixel1 = xEnd;
            double yPixel1 = IPart(yEnd);

            if (steep)
            {
                Plot(yPixel1, xPixel1, RFPart(yEnd) * xGap);
                Plot(yPixel1 + 1, xPixel1, FPart(yEnd) * xGap);
            }
            else
            {
                Plot(xPixel1, yPixel1, RFPart(yEnd) * xGap);
                Plot(xPixel1, yPixel1 + 1, FPart(yEnd) * xGap);
            }

            double intery = yEnd + gradient;
            xEnd = Math.Round((double) x);
            yEnd = y + gradient * (xEnd - x);
            xGap = FPart(x + 0.5);
            double xPixel2 = xEnd;
            double yPixel2 = IPart(yEnd);
            if (steep)
            {
                Plot(yPixel2, xPixel2, RFPart(yEnd) * xGap);
                Plot(yPixel2 + 1, xPixel2, FPart(yEnd) * xGap);
            }
            else
            {
                Plot(xPixel2, yPixel2, RFPart(yEnd) * xGap);
                Plot(xPixel2, yPixel2 + 1, FPart(yEnd) * xGap);
            }

            if (steep)
            {
                for (int currentX = (int)(xPixel1 + 1); currentX <= xPixel2 - 1; currentX++)
                {
                    Plot(IPart(intery), currentX, RFPart(intery));
                    Plot(IPart(intery) + 1, currentX, FPart(intery));
                    intery += gradient;
                }
            }
            else
            {
                for (int currentX = (int)(xPixel1 + 1); currentX <= xPixel2 - 1; currentX++)
                {
                    Plot(currentX, IPart(intery), RFPart(intery));
                    Plot(currentX, IPart(intery) + 1, FPart(intery));
                    intery += gradient;
                }
            }

            EndDraw();
        }
    }
}
