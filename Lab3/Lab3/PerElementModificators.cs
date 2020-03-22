using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class PerElementModificators
    {
        public static void Add(Bitmap bitmap, int deltaA, int deltaR, int deltaG, int deltaB)
        {
            for (int w = 0; w < bitmap.Width; ++w)
            {
                for (int h = 0; h < bitmap.Height; ++h)
                {
                    Color source = bitmap.GetPixel(w, h);
                    bitmap.SetPixel(w, h, Color.FromArgb(
                        ClampColorComponent((int)source.A + (int)deltaA),
                        ClampColorComponent((int)source.R + (int)deltaR),
                        ClampColorComponent((int)source.G + (int)deltaG),
                        ClampColorComponent((int)source.B + (int)deltaB)));
                }
            }
        }

        private static int ClampColorComponent(int value, int min = 0, int max = 255)
        {
            return Math.Max(Math.Min(value, max), min);
        }

        public static void Negate(Bitmap bitmap, bool negateAlpha = false)
        {
            for (int w = 0; w < bitmap.Width; ++w)
            {
                for (int h = 0; h < bitmap.Height; ++h)
                {
                    Color source = bitmap.GetPixel(w, h);
                    bitmap.SetPixel(w, h, Color.FromArgb(
                        negateAlpha ? NegateComponent(source.A) : source.A,
                        NegateComponent(source.R),
                        NegateComponent(source.G),
                        NegateComponent(source.B)));
                }
            }
        }

        private static int NegateComponent(int component)
        {
            return 255 - component;
        }

        public static void Multiply(Bitmap bitmap,
            float aMultiplier, float rMultiplier, float gMultiplier, float bMultiplier)
        {
            for (int w = 0; w < bitmap.Width; ++w)
            {
                for (int h = 0; h < bitmap.Height; ++h)
                {
                    Color source = bitmap.GetPixel(w, h);
                    bitmap.SetPixel(w, h, Color.FromArgb(
                        MultiplyComponent(source.A, aMultiplier),
                        MultiplyComponent(source.R, rMultiplier),
                        MultiplyComponent(source.G, gMultiplier),
                        MultiplyComponent(source.B, bMultiplier)));
                }
            }
        }

        private static int MultiplyComponent(int component, float multiplier)
        {
            return ClampColorComponent((int)Math.Round(component * multiplier));
        }

        public static void Power(Bitmap bitmap, float power, bool affectAlpha)
        {
            for (int w = 0; w < bitmap.Width; ++w)
            {
                for (int h = 0; h < bitmap.Height; ++h)
                {
                    Color source = bitmap.GetPixel(w, h);
                    bitmap.SetPixel(w, h, Color.FromArgb(
                        affectAlpha ? PowerComponent(source.A, power) : source.A,
                        PowerComponent(source.R, power),
                        PowerComponent(source.G, power),
                        PowerComponent(source.B, power)));
                }
            }
        }

        private static int PowerComponent(int component, float power)
        {
            return (int)Math.Round(255 * Math.Pow(component / 255.0, power));
        }

        public static void Log(Bitmap bitmap, bool affectAlpha)
        {
            for (int w = 0; w < bitmap.Width; ++w)
            {
                for (int h = 0; h < bitmap.Height; ++h)
                {
                    Color source = bitmap.GetPixel(w, h);
                    bitmap.SetPixel(w, h, Color.FromArgb(
                        affectAlpha ? LogComponent(source.A) : source.A,
                        LogComponent(source.R),
                        LogComponent(source.G),
                        LogComponent(source.B)));
                }
            }
        }

        private static int LogComponent(int component)
        {
            return (int)Math.Round(255 * (Math.Log(1 + component) / Math.Log(256)));
        }

        public static void LinearContrast(Bitmap bitmap, bool affectAlpha = false, 
            int targetMin = 0, int targetMax = 255)
        {
            int realMin = 255;
            int realMax = 0;

            for (int w = 0; w < bitmap.Width; ++w)
            {
                for (int h = 0; h < bitmap.Height; ++h)
                {
                    Color source = bitmap.GetPixel(w, h);
                    if (affectAlpha)
                    {
                        UpdateMinMax(source.A, realMin, realMax, out realMin, out realMax);
                    }

                    UpdateMinMax(source.R, realMin, realMax, out realMin, out realMax);
                    UpdateMinMax(source.G, realMin, realMax, out realMin, out realMax);
                    UpdateMinMax(source.B, realMin, realMax, out realMin, out realMax);
                }
            }

            for (int w = 0; w < bitmap.Width; ++w)
            {
                for (int h = 0; h < bitmap.Height; ++h)
                {
                    Color source = bitmap.GetPixel(w, h);
                    bitmap.SetPixel(w, h, Color.FromArgb(
                        affectAlpha ? FitComponent(source.A, realMin, realMax, targetMin, targetMax) : source.A,
                        FitComponent(source.R, realMin, realMax, targetMin, targetMax),
                        FitComponent(source.G, realMin, realMax, targetMin, targetMax),
                        FitComponent(source.B, realMin, realMax, targetMin, targetMax)));
                }
            }
        }

        private static void UpdateMinMax(int value, int currentMin, int currentMax, 
            out int min, out int max)
        {
            min = Math.Min(value, currentMin);
            max = Math.Max(value, currentMax);
        }

        private static int FitComponent(int component, int realMin, int realMax, 
            int targetMin, int targetMax)
        {
            return (int)Math.Round((targetMax - targetMin) * 
                (component - realMin) / (float)(realMax - realMin) + targetMin);
        }
    }
}
