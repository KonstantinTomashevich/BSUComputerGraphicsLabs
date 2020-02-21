#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "rgbcolor.h"
#include "xyzcolor.h"
#include "labcolor.h"

QT_BEGIN_NAMESPACE
namespace Ui
{
class MainWindow;
}
QT_END_NAMESPACE

class QSlider;
class QLineEdit;
class MainWindow : public QMainWindow
{
Q_OBJECT

public:
    MainWindow (QWidget *parent = nullptr);
    ~MainWindow ();

private slots:

    void on_rgbRSlider_valueChanged (int value);
    void on_rgbGSlider_valueChanged(int value);
    void on_rgbBSlider_valueChanged (int value);

    void on_xyzXSlider_valueChanged (int value);
    void on_xyzYSlider_valueChanged(int value);
    void on_xyzZSlider_valueChanged (int value);

    void on_labLSlider_valueChanged (int value);
    void on_labASlider_valueChanged(int value);
    void on_labBSlider_valueChanged (int value);

private:
    void setSliderSilently (QSlider *slider, int value);
    void setTextSilently (QLineEdit *lineEdit, const QString &value);

    void afterRGBChange ();
    void afterXYZChange ();
    void afterLABChange ();

    void updateWidgetFromRGB ();
    void updateEditionWidgets ();

    Ui::MainWindow *ui_;
    RGBColor rgb_;
    XYZColor xyz_;
    LABColor lab_;
};

#endif // MAINWINDOW_H
