using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class HistogramModificators
    {
        public static int[][] CalculateRGBHistogram(Bitmap bitmap)
        {
            int[][] rgbHistogram = new int[][] { new int[256], new int[256], new int[256] };
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
               ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* components = (byte*)data.Scan0;
                for (int w = 0; w < bitmap.Width; ++w)
                {
                    for (int h = 0; h < bitmap.Height; ++h)
                    {
                        int startIndex = w * 4 + h * data.Stride;
                        rgbHistogram[0][components[startIndex + 2]]++;
                        rgbHistogram[1][components[startIndex + 1]]++;
                        rgbHistogram[2][components[startIndex]]++;
                    }
                }
            }

            bitmap.UnlockBits(data);
            return rgbHistogram;
        }

        private static float[] NormalizedCumulative(int[] corresponding)
        {
            float[] cumulative = new float[corresponding.Length];
            cumulative[0] = corresponding[0];

            for (int index = 1; index < corresponding.Length; ++index)
            {
                cumulative[index] = cumulative[index - 1] + corresponding[index];
            }

            for (int index = 0; index < corresponding.Length; ++index)
            {
                cumulative[index] /= cumulative[corresponding.Length - 1];
            }

            return cumulative;
        }

        public static void EqualizeRGBComponentsSeparately(Bitmap bitmap, int[][] backedHistogram)
        {
            float[][] cumulative = new float[][] {
                NormalizedCumulative(backedHistogram[0]),
                NormalizedCumulative(backedHistogram[1]),
                NormalizedCumulative(backedHistogram[2])
            };

            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* components = (byte*)data.Scan0;
                for (int w = 0; w < bitmap.Width; ++w)
                {
                    for (int h = 0; h < bitmap.Height; ++h)
                    {
                        int startIndex = w * 4 + h * data.Stride;
                        components[startIndex] = (byte)Math.Round(255.0f * cumulative[2][components[startIndex]]);
                        components[startIndex + 1] = (byte)Math.Round(255.0f * cumulative[1][components[startIndex + 1]]);
                        components[startIndex + 2] = (byte)Math.Round(255.0f * cumulative[0][components[startIndex + 2]]); ;
                    }
                }
            }

            bitmap.UnlockBits(data);
        }
    }
}
