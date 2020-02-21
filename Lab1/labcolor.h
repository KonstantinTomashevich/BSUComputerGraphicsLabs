#pragma once

class XYZColor;
class LABColor
{
public:
    LABColor ();
    LABColor (unsigned char l, short a, short b, bool rounded);

    static LABColor fromXYZ(const XYZColor &xyz);

    unsigned char l_;
    short a_;
    short b_;
    bool rounded_;
};
