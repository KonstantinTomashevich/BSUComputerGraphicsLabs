#include "mainwindow.h"
#include "./ui_mainwindow.h"
#include "clickablelabel.h"

#include <QSlider>
#include <QLineEdit>
#include <QStyle>
#include <cmath>

MainWindow::MainWindow (QWidget *parent)
    : QMainWindow (parent), ui_ (new Ui::MainWindow), paletteColors_ ()
{
    ui_->setupUi (this);

    rgb_ = RGBColor (255, 100, 100);
    xyz_ = XYZColor::fromRGB (rgb_);
    lab_ = LABColor::fromXYZ (xyz_);

    updateWidgetFromRGB ();
    updateEditionWidgets ();
    generatePalette ();
}

MainWindow::~MainWindow ()
{
    delete ui_;
}

void MainWindow::updateWidgetFromRGB ()
{
    ui_->colorWidget->setStyleSheet (QString ("background-color:rgb(%1, %2, %3);").
        arg (rgb_.r_).arg (rgb_.g_).arg (rgb_.b_));
}

void MainWindow::updateEditionWidgets ()
{
    setSliderSilently (ui_->rgbRSlider, rgb_.r_);
    setSliderSilently (ui_->rgbGSlider, rgb_.g_);
    setSliderSilently (ui_->rgbBSlider, rgb_.b_);

    setTextSilently (ui_->rgbREdit, QString::number (rgb_.r_));
    setTextSilently (ui_->rgbGEdit, QString::number (rgb_.g_));
    setTextSilently (ui_->rgbBEdit, QString::number (rgb_.b_));

    setSliderSilently (ui_->xyzXSlider, (int) xyz_.x_);
    setSliderSilently (ui_->xyzYSlider, (int) xyz_.y_);
    setSliderSilently (ui_->xyzZSlider, (int) xyz_.z_);

    setTextSilently (ui_->xyzXEdit, QString::number (xyz_.x_));
    setTextSilently (ui_->xyzYEdit, QString::number (xyz_.y_));
    setTextSilently (ui_->xyzZEdit, QString::number (xyz_.z_));

    setSliderSilently (ui_->labLSlider, lab_.l_);
    setSliderSilently (ui_->labASlider, lab_.a_);
    setSliderSilently (ui_->labBSlider, lab_.b_);

    setTextSilently (ui_->labLEdit, QString::number (lab_.l_));
    setTextSilently (ui_->labAEdit, QString::number (lab_.a_));
    setTextSilently (ui_->labBEdit, QString::number (lab_.b_));

    ui_->rgbLabel->setStyleSheet (rgb_.rounded_ ? "background:darkred;" : "");
    ui_->rgbLabel->setToolTip (rgb_.rounded_ ? "Value rounded!" : "");

    ui_->xyzLabel->setStyleSheet (xyz_.rounded_ ? "background:darkred;" : "");
    ui_->xyzLabel->setToolTip (xyz_.rounded_ ? "Value rounded!" : "");

    ui_->labLabel->setStyleSheet (lab_.rounded_ ? "background:darkred;" : "");
    ui_->labLabel->setToolTip (lab_.rounded_ ? "Value rounded!" : "");
}

void MainWindow::on_rgbRSlider_valueChanged (int value)
{
    rgb_.r_ = value;
    afterRGBChange ();
}

void MainWindow::on_rgbGSlider_valueChanged (int value)
{
    rgb_.g_ = value;
    afterRGBChange ();
}

void MainWindow::on_rgbBSlider_valueChanged (int value)
{
    rgb_.b_ = value;
    afterRGBChange ();
}

void MainWindow::setSliderSilently (QSlider *slider, int value)
{
    slider->blockSignals (true);
    slider->setValue (value);
    slider->blockSignals (false);
}

void MainWindow::setTextSilently (QLineEdit *lineEdit, const QString &value)
{
    lineEdit->blockSignals (true);
    lineEdit->setText (value);
    lineEdit->blockSignals (false);
}

void MainWindow::afterRGBChange ()
{
    rgb_.rounded_ = false;
    xyz_ = XYZColor::fromRGB (rgb_);
    lab_ = LABColor::fromXYZ (xyz_);

    updateWidgetFromRGB ();
    updateEditionWidgets ();
}

void MainWindow::afterXYZChange ()
{
    xyz_.rounded_ = false;
    rgb_ = RGBColor::fromXYZ (xyz_);
    lab_ = LABColor::fromXYZ (xyz_);

    updateWidgetFromRGB ();
    updateEditionWidgets ();
}

void MainWindow::afterLABChange ()
{
    lab_.rounded_ = false;
    xyz_ = XYZColor::fromLAB (lab_);
    rgb_ = RGBColor::fromXYZ (xyz_);

    updateWidgetFromRGB ();
    updateEditionWidgets ();
}

void MainWindow::on_xyzXSlider_valueChanged (int value)
{
    xyz_.x_ = (float) value;
    afterXYZChange ();
}

void MainWindow::on_xyzYSlider_valueChanged (int value)
{
    xyz_.y_ = (float) value;
    afterXYZChange ();
}

void MainWindow::on_xyzZSlider_valueChanged (int value)
{
    xyz_.z_ = (float) value;
    afterXYZChange ();
}

void MainWindow::on_labLSlider_valueChanged (int value)
{
    lab_.l_ = (unsigned char) value;
    afterLABChange ();
}

void MainWindow::on_labASlider_valueChanged (int value)
{
    lab_.a_ = (short) value;
    afterLABChange ();
}

void MainWindow::on_labBSlider_valueChanged (int value)
{
    lab_.b_ = (short) value;
    afterLABChange ();
}

void MainWindow::on_rgbREdit_returnPressed ()
{
    rgb_.r_ = getRGBComponentFromEdit (ui_->rgbREdit);
    afterRGBChange ();
}

void MainWindow::on_rgbGEdit_returnPressed ()
{
    rgb_.g_ = getRGBComponentFromEdit (ui_->rgbGEdit);
    afterRGBChange ();
}

void MainWindow::on_rgbBEdit_returnPressed ()
{
    rgb_.b_ = getRGBComponentFromEdit (ui_->rgbBEdit);
    afterRGBChange ();
}

int MainWindow::getRGBComponentFromEdit (QLineEdit *edit)
{
    bool correct = true;
    int component = edit->text ().toInt (&correct);

    if (component > 255)
    {
        component = 255;
    }

    return correct ? component : 0;
}

void MainWindow::on_xyzXEdit_returnPressed ()
{
    xyz_ = XYZColor (getXYZComponentFromEdit (ui_->xyzXEdit), xyz_.y_, xyz_.z_);
    xyz_.rounded_ = false;
    afterXYZChange ();
}

void MainWindow::on_xyzYEdit_returnPressed ()
{
    xyz_ = XYZColor (xyz_.x_, getXYZComponentFromEdit (ui_->xyzYEdit), xyz_.z_);
    xyz_.rounded_ = false;
    afterXYZChange ();
}

void MainWindow::on_xyzZEdit_returnPressed ()
{
    xyz_ = XYZColor (xyz_.x_, xyz_.y_, getXYZComponentFromEdit (ui_->xyzZEdit));
    xyz_.rounded_ = false;
    afterXYZChange ();
}

float MainWindow::getXYZComponentFromEdit (QLineEdit *edit)
{
    bool correct = true;
    float component = edit->text ().toFloat (&correct);
    return correct ? component : 0.0f;
}

void MainWindow::on_labLEdit_returnPressed ()
{
    bool correct = true;
    unsigned char l = ui_->labLEdit->text ().toUInt (&correct);

    if (!correct) l = 0;
    if (l > 100) l = 100;

    lab_.l_ = l;
    afterLABChange ();
}

void MainWindow::on_labAEdit_returnPressed ()
{
    bool correct = true;
    short a = ui_->labAEdit->text ().toInt (&correct);

    if (!correct) a = 0;
    if (a > 128) a = 128;
    if (a < -128) a = -128;

    lab_.a_ = a;
    afterLABChange ();
}

void MainWindow::on_labBEdit_returnPressed ()
{
    bool correct = true;
    short b = ui_->labBEdit->text ().toInt (&correct);

    if (!correct) b = 0;
    if (b > 128) b = 128;
    if (b < -128) b = -128;

    lab_.b_ = b;
    afterLABChange ();
}

void MainWindow::on_palette_clicked (ClickableLabel *sender)
{
    rgb_ = paletteColors_[sender];
    afterRGBChange ();
}

void MainWindow::generatePalette ()
{
    for (int row = 0; row < 15; ++row)
    {
        for (int col = 0; col < 5; ++col)
        {
            auto *widget = new ClickableLabel (ui_->paletteFrame);
            RGBColor color (rand () % 255, rand () % 255, rand () % 255);

            widget->setStyleSheet (QString ("background-color:rgb(%1, %2, %3);").
                arg (color.r_).arg (color.g_).arg (color.b_));
            widget->setAutoFillBackground (true);

            paletteColors_[widget] = color;
            ui_->paletteLayout->addWidget (widget, row, col, 1, 1);
            connect (widget, &ClickableLabel::clicked, this, &MainWindow::on_palette_clicked);
        }
    }
}
