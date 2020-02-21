#pragma once

class XYZColor;
class RGBColor
{
public:
    RGBColor ();
    RGBColor (unsigned char r, unsigned char g, unsigned char b, bool rounded = false);

    static RGBColor fromXYZ(const XYZColor &xyz);

    unsigned char r_;
    unsigned char g_;
    unsigned char b_;
    bool rounded_;
};
