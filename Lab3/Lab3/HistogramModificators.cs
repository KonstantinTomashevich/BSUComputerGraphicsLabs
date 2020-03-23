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
               ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

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

        public static int[] CalculateBrightnessHistogram(Bitmap bitmap)
        {
            int[] lightnessHistogram = new int[101];
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
               ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* components = (byte*)data.Scan0;
                for (int w = 0; w < bitmap.Width; ++w)
                {
                    for (int h = 0; h < bitmap.Height; ++h)
                    {
                        int startIndex = w * 4 + h * data.Stride;
                        float H, S, V;

                        RGBToHSV(components[startIndex + 2], components[startIndex + 1], 
                            components[startIndex], out H, out S, out V);
                        lightnessHistogram[(int)Math.Round(V)]++;
                    }
                }
            }

            bitmap.UnlockBits(data);
            return lightnessHistogram;
        }

        public static void EqualizeHSVBrightness(Bitmap bitmap, int[] backedHistogram)
        {
            float[] cumulative = NormalizedCumulative(backedHistogram);
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
                        float H, S, V;

                        RGBToHSV(components[startIndex + 2], components[startIndex + 1],
                            components[startIndex], out H, out S, out V);

                        Color color = HSVToRGB(H, S, 100.0f * cumulative[(int)Math.Round(V)]);
                        components[startIndex] = color.B;
                        components[startIndex + 1] = color.G;
                        components[startIndex + 2] = color.R;
                    }
                }
            }

            bitmap.UnlockBits(data);
        }

        public static void RGBToHSV(int R, int G, int B, out float H, out float S, out float V)
        {

            float r = R / 255.0f;
            float g = G / 255.0f;
            float b = B / 255.0f;

            float min, max, delta;        
            min = Math.Min(Math.Min(r, g), b);
            max = Math.Max(Math.Max(r, g), b);

            float h = 0, s, v = max;
            delta = max - min;

            if (delta != 0)
            {
                if (max == r)
                {
                    h = 60 * (((g - b) / delta) % 6);
                }
                else if (max == g)
                {
                    h = 60 * (((b - r) / delta) + 2);
                }
                else if (max == b)
                {
                    h = 60 * (((r - g) / delta) + 4);
                }
                if (h < 0)
                {
                    h += 360;
                }
            }

            if (max == 0)
            {
                s = 0;
            }
            else
            {
                s = delta / max;
            }

            H = h;
            S = s * 100.0f;
            V = v * 100.0f;
        }

        public static Color HSVToRGB(float H, float S, float V)
        {
            float R, G, B;
            H /= 360f;
            S /= 100f;
            V /= 100f;

            if (S == 0)
            {
                R = V * 255;
                G = V * 255;
                B = V * 255;
            }
            else
            {
                float var_h = H * 6;
                if (var_h == 6)
                {
                    var_h = 0;
                }

                int var_i = (int)Math.Floor((double)var_h);
                float var_1 = V * (1 - S);
                float var_2 = V * (1 - S * (var_h - var_i));
                float var_3 = V * (1 - S * (1 - (var_h - var_i)));

                float var_r;
                float var_g;
                float var_b;

                if (var_i == 0)
                {
                    var_r = V;
                    var_g = var_3;
                    var_b = var_1;
                }

                else if (var_i == 1)
                {
                    var_r = var_2;
                    var_g = V;
                    var_b = var_1;
                }

                else if (var_i == 2)
                {
                    var_r = var_1;
                    var_g = V;
                    var_b = var_3;
                }

                else if (var_i == 3)
                {
                    var_r = var_1;
                    var_g = var_2;
                    var_b = V;
                }

                else if (var_i == 4)
                {
                    var_r = var_3;
                    var_g = var_1;
                    var_b = V;
                }

                else
                {
                    var_r = V;
                    var_g = var_1;
                    var_b = var_2;
                }

                R = var_r * 255;
                G = var_g * 255;
                B = var_b * 255;
            }

            return Color.FromArgb((byte)Math.Round(R), (byte)Math.Round(G), (byte)Math.Round(B));
        }
    }
}
