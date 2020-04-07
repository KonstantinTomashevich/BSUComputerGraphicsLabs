using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Lab4
{
    abstract class DrawTool
    {
        private NumericUpDown alphaInput;
        private NumericUpDown rInput;
        private NumericUpDown gInput;
        private NumericUpDown bInput;
        private Bitmap bitmap;
        private BitmapData data;

        protected DrawTool(Bitmap bitmap, 
            NumericUpDown alphaInput, NumericUpDown rInput, 
            NumericUpDown gInput, NumericUpDown bInput)
        {
            this.bitmap = bitmap;
            this.alphaInput = alphaInput;
            this.rInput = rInput;
            this.gInput = gInput;
            this.bInput = bInput;
        }

        public abstract void ProcessClick(int x, int y);

        public abstract long GetLastDrawCallTime();

        public abstract void ExecuteForPerformanceTest();

        protected Bitmap GetBitmap()
        {
            return bitmap;
        }

        public void SetBitmap(Bitmap newBitmap)
        {
            if (data != null)
            {
                throw new Exception("Unable to set another bitmap while drawing in progress!");
            }

            bitmap = newBitmap;
        }

        protected void BeginDraw()
        {
            if (data != null)
            {
                throw new Exception("Unable to begin drawing without ending of previous draw call!");
            }

            data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
        }

        protected Color GetColor()
        {
            return Color.FromArgb(Decimal.ToInt32(alphaInput.Value), Decimal.ToInt32(rInput.Value),
                Decimal.ToInt32(gInput.Value), Decimal.ToInt32(bInput.Value));
        }

        protected void EndDraw()
        {
            bitmap.UnlockBits(data);
            data = null;
        }

        protected unsafe void SetPixel(int x, int y, Color color)
        {
            if (data == null)
            {
                throw new Exception("You must call BeginDraw before attempting to change pixels!");
            }

            if (x < 0 || y < 0 || x >= bitmap.Width || y >= bitmap.Height)
            {
                return;
            }

            byte* components = (byte *) data.Scan0;
            int startIndex = x * 4 + y * data.Stride;

            components[startIndex] = color.B;
            components[startIndex + 1] = color.G;
            components[startIndex + 2] = color.R;
            components[startIndex + 3] = color.A;
        }

        protected unsafe Color GetPixel(int x, int y)
        {
            if (data == null)
            {
                throw new Exception("You must call BeginDraw before attempting to change pixels!");
            }

            if (x < 0 || y < 0 || x >= bitmap.Width || y >= bitmap.Height)
            {
                return Color.White;
            }

            byte* components = (byte *) data.Scan0;
            int startIndex = x * 4 + y * data.Stride;
            return Color.FromArgb(components[startIndex + 3], components[startIndex + 2], 
                components[startIndex + 1], components[startIndex]);
        }
    }
}
