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

        public MainForm()
        {
            InitializeComponent();
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
                pictureView.Invalidate();
            }
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Add(selectedBitmap, -(int)colorAInput.Value,
                    -(int)colorRInput.Value, -(int)colorGInput.Value, -(int)colorBInput.Value);
                pictureView.Invalidate();
            }
        }

        private void negateButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Negate(selectedBitmap, negateAlphaCheck.Checked);
                pictureView.Invalidate();
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Multiply(selectedBitmap,
                    (float)colorAMultiplierInput.Value, (float)colorRMultiplierInput.Value,
                    (float)colorGMultiplierInput.Value, (float)colorBMultiplierInput.Value);
                pictureView.Invalidate();
            }
        }

        private void powerButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Power(selectedBitmap,
                    (float)powerInput.Value, powerAlphaCheck.Checked);
                pictureView.Invalidate();
            }
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (RequireBitmap())
            {
                PerElementModificators.Log(selectedBitmap, logAlphaCheck.Checked);
                pictureView.Invalidate();
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
                pictureView.Invalidate();
            }
        }
    }
}
