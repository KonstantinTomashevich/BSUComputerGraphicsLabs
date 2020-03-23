using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        private Bitmap selectedBitmap = null;
        private int[][] rgbHistogram = null;

        public MainForm()
        {
            InitializeComponent();
            modificatorsPanel.HorizontalScroll.Visible = false;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    Bitmap newBitmap = new Bitmap(openImageDialog.FileName);
                    selectedBitmap = newBitmap;
                    OnImageUpdated();
                    pictureView.Image = selectedBitmap;
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Unable to open file " + openImageDialog.FileName +
                        " due to exception " + exception.Message + "!",
                        "Unable to open image!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedBitmap == null)
            {
                MessageBox.Show("Unable to save image as there is no image opened!",
                        "Unable to save image!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult result = saveImageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedBitmap.Save(saveImageDialog.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Unable to save image to file " + saveImageDialog.FileName +
                        " due to exception " + exception.Message + "!",
                        "Unable to save image!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool RequireBitmap()
        {
            if (selectedBitmap == null)
            {
                MessageBox.Show("You must open image first!", "Unable to apply modifier!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Add(selectedBitmap, (int)colorAInput.Value,
                    (int)colorRInput.Value, (int)colorGInput.Value, (int)colorBInput.Value);
                OnImageUpdated();
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Add(selectedBitmap, -(int)colorAInput.Value,
                    -(int)colorRInput.Value, -(int)colorGInput.Value, -(int)colorBInput.Value);
                OnImageUpdated();
            }
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Negate(selectedBitmap, negateAlphaCheck.Checked);
                OnImageUpdated();
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Multiply(selectedBitmap,
                    (float)colorAMultiplierInput.Value, (float)colorRMultiplierInput.Value,
                    (float)colorGMultiplierInput.Value, (float)colorBMultiplierInput.Value);
                OnImageUpdated();
            }
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Power(selectedBitmap,
                    (float)powerInput.Value, powerAlphaCheck.Checked);
                OnImageUpdated();
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Log(selectedBitmap, logAlphaCheck.Checked);
                OnImageUpdated();
            }
        }

        private void linearContrastButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                if (contrastMinInput.Value >= contrastMaxInput.Value)
                {
                    MessageBox.Show("Contrast min value must be less than max!", "Unable to apply modifier!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                PerElementModificators.LinearContrast(selectedBitmap, linearContrastAlphaCheck.Checked,
                    (int)contrastMinInput.Value, (int)contrastMaxInput.Value);
                OnImageUpdated();
            }
        }

        private void OnImageUpdated()
        {
            rgbHistogram = HistogramModificators.CalculateRGBHistogram(selectedBitmap);
            for (int component = 0; component < 3; ++component)
            {
                rgbHistogramChart.Series[component].Points.Clear();
                for (int index = 0; index < 255; ++index)
                {
                    rgbHistogramChart.Series[component].Points.AddXY(index, rgbHistogram[component][index]);
                }
            }

            pictureView.Invalidate();
        }

        private void separateEqualizeButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                if (contrastMinInput.Value >= contrastMaxInput.Value)
                {
                    MessageBox.Show("Contrast min value must be less than max!", "Unable to apply modifier!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                HistogramModificators.EqualizeRGBComponentsSeparately(selectedBitmap, rgbHistogram);
                OnImageUpdated();
            }
        }
    }
}
