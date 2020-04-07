using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        private Bitmap sampleBitmap;
        private int bitmapWidth;
        private int bitmapHeight;
        private int bitmapX;
        private int bitmapY;

        private DrawTool currentDrawTool = null;
        private DrawTool lineStepByStepDrawTool = null;
        private DrawTool lineDDADrawTool = null;
        private DrawTool lineBresenhamDrawTool = null;
        private DrawTool lineMidpointDrawTool = null;
        private DrawTool lineByDrawTool = null;

        private DrawTool circleBresenhamDrawTool = null;
        private DrawTool circleMidpointDrawTool = null;

        public MainForm()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", 
                BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, 
                null, bitmapPanel, new object[] { true });

            CreateInitialBitmap();
            lineStepByStepDrawTool = new LineStepByStepDrawTool(sampleBitmap, alphaEdit, rEdit, gEdit, bEdit);
            lineDDADrawTool = new LineDDADrawTool(sampleBitmap, alphaEdit, rEdit, gEdit, bEdit);
            lineBresenhamDrawTool = new LineBresenhamDrawTool(sampleBitmap, alphaEdit, rEdit, gEdit, bEdit);
            lineMidpointDrawTool = new LineMidpointDrawTool(sampleBitmap, alphaEdit, rEdit, gEdit, bEdit);
            lineByDrawTool = new LineByDrawTool(sampleBitmap, alphaEdit, rEdit, gEdit, bEdit);

            circleBresenhamDrawTool = new CircleBresenhamDrawTool(sampleBitmap, alphaEdit, rEdit, gEdit, bEdit, circleRadiusInput);
            circleMidpointDrawTool = new CircleMidpointDrawTool(sampleBitmap, alphaEdit, rEdit, gEdit, bEdit, circleRadiusInput);
        }

        private void CreateInitialBitmap()
        {
            sampleBitmap = new Bitmap(Decimal.ToInt32(widthInput.Value), Decimal.ToInt32(heightInput.Value));
            BitmapData data = sampleBitmap.LockBits(new Rectangle(0, 0, sampleBitmap.Width, sampleBitmap.Height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* components = (byte*)data.Scan0;
                for (int w = 0; w < sampleBitmap.Width; ++w)
                {
                    for (int h = 0; h < sampleBitmap.Height; ++h)
                    {
                        int startIndex = w * 4 + h * data.Stride;
                        for (int component = 0; component < 4; ++component)
                        {
                            components[startIndex + component] = 255;
                        }
                    }
                }
            }

            sampleBitmap.UnlockBits(data);
        }

        private void ResizeBitmap(int width, int height)
        {
            Bitmap newBitmap = new Bitmap(width, height);
            BitmapData newData = newBitmap.LockBits(new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            BitmapData oldData = sampleBitmap.LockBits(new Rectangle(0, 0, sampleBitmap.Width, sampleBitmap.Height),
               ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            unsafe
            {
                byte* newComponents = (byte *) newData.Scan0;
                byte* oldComponents = (byte *) oldData.Scan0;

                for (int x = 0; x < width; ++x)
                {
                    for (int y = 0; y < height; ++y)
                    {
                        int newIndex = x * 4 + y * newData.Stride;
                        if (x < sampleBitmap.Width && y < sampleBitmap.Height)
                        {
                            int oldIndex = x * 4 + y * oldData.Stride;
                            for (int offset = 0; offset < 4; ++offset)
                            {
                                newComponents[newIndex + offset] = oldComponents[oldIndex + offset];
                            }
                        }
                        else
                        {
                            for (int offset = 0; offset < 4; ++offset)
                            {
                                newComponents[newIndex + offset] = 255;
                            }
                        }
                    }
                }
            }

            newBitmap.UnlockBits(newData);
            sampleBitmap.UnlockBits(oldData);

            sampleBitmap = newBitmap;
            UpdateCurrentDrawTool();
            bitmapPanel.Invalidate();
        }

        private void bitmapPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

            float widthScale = (float) bitmapPanel.Width / sampleBitmap.Width;
            float heightScale = (float) bitmapPanel.Height / sampleBitmap.Height;
            float scale = Math.Min(widthScale, heightScale);

            bitmapWidth = (int) Math.Round(sampleBitmap.Width * scale);
            bitmapHeight = (int)Math.Round(sampleBitmap.Height * scale);
            bitmapY = (bitmapPanel.Height - bitmapHeight) / 2;
            bitmapX = (bitmapPanel.Width - bitmapWidth) / 2;

            e.Graphics.DrawImage(sampleBitmap, bitmapX, bitmapY, bitmapWidth, bitmapHeight);
        }

        private void bitmapPanel_Resize(object sender, EventArgs e)
        {
            bitmapPanel.Invalidate();
        }

        private void lineStepButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineStepButton.Checked)
            {
                currentDrawTool = lineStepByStepDrawTool;
            }

            UpdateCurrentDrawTool();
        }

        private void lineDDAButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineDDAButton.Checked)
            {
                currentDrawTool = lineDDADrawTool;
            }

            UpdateCurrentDrawTool();
        }

        private void lineBresenhamButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineBresenhamButton.Checked)
            {
                currentDrawTool = lineBresenhamDrawTool;
            }

            UpdateCurrentDrawTool();
        }

        private void circleBresenhamButton_CheckedChanged(object sender, EventArgs e)
        {
            if (circleBresenhamButton.Checked)
            {
                currentDrawTool = circleBresenhamDrawTool;
            }

            UpdateCurrentDrawTool();
        }

        private void UpdateCurrentDrawTool()
        {
            if (currentDrawTool != null)
            {
                currentDrawTool.SetBitmap(sampleBitmap);
            }
        }

        private void bitmapPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (int) Math.Round((float) (e.X - bitmapX) * sampleBitmap.Width / bitmapWidth);
            int y = (int) Math.Round((float) (e.Y - bitmapY) * sampleBitmap.Height / bitmapHeight);

            if (x >= 0 && y >= 0 && x < sampleBitmap.Width && y < sampleBitmap.Height && currentDrawTool != null)
            {
                currentDrawTool.ProcessClick(x, y);
                lastDrawCallTimeLabel.Text = currentDrawTool.GetLastDrawCallTime().ToString();
                bitmapPanel.Invalidate();
            }
        }

        private void widthInput_ValueChanged(object sender, EventArgs e)
        {
            ResizeBitmap(Decimal.ToInt32(widthInput.Value), Decimal.ToInt32(heightInput.Value));
        }

        private void heightInput_ValueChanged(object sender, EventArgs e)
        {
            ResizeBitmap(Decimal.ToInt32(widthInput.Value), Decimal.ToInt32(heightInput.Value));
        }

        private void testPerformanceButton_Click(object sender, EventArgs e)
        {
            if (currentDrawTool == null)
            {
                return;
            }

            int testCount = 1000;
            long totalNs = 0;

            for (int index = 0; index < testCount; ++index)
            {
                currentDrawTool.ExecuteForPerformanceTest();
                totalNs += currentDrawTool.GetLastDrawCallTime();
            }

            lastDrawCallTimeLabel.Text = ((long) Math.Round((float) totalNs / testCount)).ToString();
            bitmapPanel.Invalidate();
        }

        private void lineMidpointButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineMidpointButton.Checked)
            {
                currentDrawTool = lineMidpointDrawTool;
            }

            UpdateCurrentDrawTool();
        }

        private void circleMidpointButton_CheckedChanged(object sender, EventArgs e)
        {
            if (circleMidpointButton.Checked)
            {
                currentDrawTool = circleMidpointDrawTool;
            }

            UpdateCurrentDrawTool();
        }

        private void lineByButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lineByButton.Checked)
            {
                currentDrawTool = lineByDrawTool;
            }

            UpdateCurrentDrawTool();
        }
    }
}
