#ifndef CLICKABLEWIDGET_H
#define CLICKABLEWIDGET_H

#include <QLabel>

class ClickableLabel : public QLabel
{
Q_OBJECT
public:
    explicit ClickableLabel (QWidget *parent = nullptr, Qt::WindowFlags f = Qt::WindowFlags());
    virtual ~ClickableLabel () = default;

signals:
    void clicked (ClickableLabel *sender);

protected:
    void mousePressEvent (QMouseEvent *event);
};

#endif // CLICKABLEWIDGET_H
