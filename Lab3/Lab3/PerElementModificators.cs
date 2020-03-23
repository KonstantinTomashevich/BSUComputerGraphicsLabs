using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    static class PerElementModificators
    {
        public static void Add(Bitmap bitmap, int deltaA, int deltaR, int deltaG, int deltaB)
        {
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
                        components[startIndex] = (byte)ClampColorComponent((int)components[startIndex] + (int)deltaB);
                        components[startIndex + 1] = (byte)ClampColorComponent((int)components[startIndex + 1] + (int)deltaG);
                        components[startIndex + 2] = (byte)ClampColorComponent((int)components[startIndex + 2] + (int)deltaR);
                        components[startIndex + 3] = (byte)ClampColorComponent((int)components[startIndex + 3] + (int)deltaA);
                    }
                }
            }

            bitmap.UnlockBits(data);
        }

        private static int ClampColorComponent(int value, int min = 0, int max = 255)
        {
            return Math.Max(Math.Min(value, max), min);
        }

        public static void Negate(Bitmap bitmap, bool negateAlpha = false)
        {
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
                        for (int index = 0; index < (negateAlpha ? 4 : 3); ++index)
                        {
                            components[startIndex + index] = (byte)NegateComponent(components[startIndex + index]);
                        }
                    }
                }
            }

            bitmap.UnlockBits(data);
        }

        private static int NegateComponent(int component)
        {
            return 255 - component;
        }

        public static void Multiply(Bitmap bitmap,
            float aMultiplier, float rMultiplier, float gMultiplier, float bMultiplier)
        {
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
                        components[startIndex] = (byte)MultiplyComponent((int)components[startIndex], bMultiplier);
                        components[startIndex + 1] = (byte)MultiplyComponent((int)components[startIndex + 1], gMultiplier);
                        components[startIndex + 2] = (byte)MultiplyComponent((int)components[startIndex + 2], rMultiplier);
                        components[startIndex + 3] = (byte)MultiplyComponent((int)components[startIndex + 3], aMultiplier);
                    }
                }
            }

            bitmap.UnlockBits(data);
        }

        private static int MultiplyComponent(int component, float multiplier)
        {
            return ClampColorComponent((int)Math.Round(component * multiplier));
        }

        public static void Power(Bitmap bitmap, float power, bool affectAlpha)
        {
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
                        for (int index = 0; index < (affectAlpha ? 4 : 3); ++index)
                        {
                            components[startIndex + index] = (byte)PowerComponent(components[startIndex + index], power);
                        }
                    }
                }
            }

            bitmap.UnlockBits(data);
        }

        private static int PowerComponent(int component, float power)
        {
            return (int)Math.Round(255 * Math.Pow(component / 255.0, power));
        }

        public static void Log(Bitmap bitmap, bool affectAlpha)
        {
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
                        for (int index = 0; index < (affectAlpha ? 4 : 3); ++index)
                        {
                            components[startIndex + index] = (byte)LogComponent(components[startIndex + index]);
                        }
                    }
                }
            }

            bitmap.UnlockBits(data);
        }

        private static int LogComponent(int component)
        {
            return (int)Math.Round(255 * (Math.Log(1 + component) / Math.Log(256)));
        }

        public static void LinearContrast(Bitmap bitmap, bool affectAlpha = false, 
            int targetMin = 0, int targetMax = 255)
        {
            BitmapData data = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* components = (byte*)data.Scan0;
                int realMin = 255;
                int realMax = 0;

                for (int w = 0; w < bitmap.Width; ++w)
                {
                    for (int h = 0; h < bitmap.Height; ++h)
                    {
                        int startIndex = w * 4 + h * data.Stride;
                        for (int index = 0; index < (affectAlpha ? 4 : 3); ++index)
                        {
                            UpdateMinMax(components[startIndex + index], realMin, realMax, out realMin, out realMax);
                        }
                    }
                }

                for (int w = 0; w < bitmap.Width; ++w)
                {
                    for (int h = 0; h < bitmap.Height; ++h)
                    {
                        int startIndex = w * 4 + h * data.Stride;
                        for (int index = 0; index < (affectAlpha ? 4 : 3); ++index)
                        {
                            components[startIndex + index] = (byte)FitComponent(components[startIndex +index],
                                realMin, realMax, targetMin, targetMax);
                        }
                    }
                }
            }

            bitmap.UnlockBits(data);
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
