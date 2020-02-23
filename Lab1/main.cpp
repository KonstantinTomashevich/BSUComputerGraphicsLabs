#include "mainwindow.h"
#include <cmath>
#include <ctime>

#include <QApplication>
#include <QFile>
#include <QTextStream>

int main(int argc, char *argv[])
{
    srand (time (nullptr));
    QApplication app(argc, argv);
    QFile stylesheetFile(":qdarkstyle/style.qss");

    if (!stylesheetFile.exists())   {
        printf("Unable to set stylesheet, file not found\n");
    }
    else   {
        stylesheetFile.open(QFile::ReadOnly | QFile::Text);
        QTextStream stream(&stylesheetFile);
        app.setStyleSheet(stream.readAll());
    }

    MainWindow mainWindow;
    mainWindow.show();
    return QApplication::exec();
}
