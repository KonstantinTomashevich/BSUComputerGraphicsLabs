using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    abstract class CircleDrawTool : DrawTool
    {
        private NumericUpDown radiusInput;
        private Stopwatch stopwatch = new Stopwatch();
        private long lastDrawCallTime = 0;

        protected CircleDrawTool(Bitmap bitmap, NumericUpDown alphaInput, 
            NumericUpDown rInput, NumericUpDown gInput,
            NumericUpDown bInput, NumericUpDown radiusInput) : 
            base(bitmap, alphaInput, rInput, gInput, bInput)
        {
            this.radiusInput = radiusInput;
        }

        protected abstract void DrawCircle(int centerX, int centerY, int radius);

        public override void ExecuteForPerformanceTest()
        {
            int centerX = GetBitmap().Width / 2;
            int centerY = GetBitmap().Height / 2;
            int radius = Math.Min(GetBitmap().Width, GetBitmap().Height) / 2;

            stopwatch.Start();
            DrawCircle(centerX, centerY, radius);
            lastDrawCallTime = (long)Math.Round(stopwatch.Elapsed.TotalMilliseconds * 1000);
            stopwatch.Reset();
        }

        public override long GetLastDrawCallTime()
        {
            return lastDrawCallTime;
        }

        public override void ProcessClick(int x, int y)
        {
            int radius = Decimal.ToInt32(radiusInput.Value);
            stopwatch.Start();
            DrawCircle(x, y, radius);
            lastDrawCallTime = (long)Math.Round(stopwatch.Elapsed.TotalMilliseconds * 1000);
            stopwatch.Reset();
        }
    }
}
