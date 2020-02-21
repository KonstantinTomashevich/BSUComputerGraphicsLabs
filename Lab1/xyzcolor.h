#pragma once

class RGBColor;
class LABColor;
class XYZColor
{
public:
    XYZColor ();
    XYZColor (float x, float y, float z, bool rounded);

    static XYZColor fromRGB(const RGBColor &rgb);
    static XYZColor fromLAB(const LABColor &lab);

    float x_;
    float y_;
    float z_;
    bool rounded_;
};
