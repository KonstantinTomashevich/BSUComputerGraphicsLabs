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
    abstract class LineDrawTool : DrawTool
    {
        private bool firstPointSelected = false;
        private int firstX;
        private int firstY;
        private long lastDrawCallTime = 0;
        private Stopwatch stopwatch = new Stopwatch();

        protected LineDrawTool(Bitmap bitmap,
            NumericUpDown alphaInput, NumericUpDown rInput, 
            NumericUpDown gInput, NumericUpDown bInput) : 
            base(bitmap, alphaInput, rInput, gInput, bInput)
        {
        }

        public override void ProcessClick(int x, int y)
        {
            if (firstPointSelected)
            {
                stopwatch.Start();
                DrawLine(firstX, firstY, x, y);
                lastDrawCallTime = (long) Math.Round(stopwatch.Elapsed.TotalMilliseconds * 1000);

                stopwatch.Reset();
                firstPointSelected = false;
            }
            else
            {
                firstPointSelected = true;
                firstX = x;
                firstY = y;
            }
        }

        public override long GetLastDrawCallTime()
        {
            return lastDrawCallTime;
        }

        public override void ExecuteForPerformanceTest()
        {
            ProcessClick(0, 0);
            ProcessClick(GetBitmap().Width - 1, GetBitmap().Height - 1);
        }

        protected abstract void DrawLine(int firstX, int firstY, int x, int y);
    }
}
