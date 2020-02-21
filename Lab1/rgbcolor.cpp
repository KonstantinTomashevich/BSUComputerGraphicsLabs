#include "rgbcolor.h"
#include "xyzcolor.h"
#include "utils.h"
#include <cmath>

RGBColor::RGBColor ()
    : r_ (0), g_ (0), b_ (0), rounded_(false)
{
}

RGBColor::RGBColor (unsigned char r, unsigned char g, unsigned char b, bool rounded)
    : r_ (r), g_ (g), b_ (b), rounded_ (rounded)
{
}

static float F(float x)
{
    if (x >= 0.0031308)
    {
        return 1.055f * powf (x, 1.0f / 2.4f) - 0.055f;
    }
    else
    {
        return 12.92f * x;
    }
}

RGBColor RGBColor::fromXYZ (const XYZColor &xyz)
{
    float rn = 3.2406f * (xyz.x_ * 0.01f) - 1.5372f * (xyz.y_ * 0.01f) - 0.4986f * (xyz.z_ * 0.01f);
    float gn = -0.9689f * (xyz.x_ * 0.01f) + 1.8758f * (xyz.y_ * 0.01f) + 0.0415f * (xyz.z_ * 0.01f);
    float bn = 0.0557f * (xyz.x_ * 0.01f) - 0.2040f * (xyz.y_ * 0.01f) + 1.0570f * (xyz.z_ * 0.01f);

    rn = F(rn) * 255;
    gn = F(gn) * 255;
    bn = F(bn) * 255;

    bool rounded = false;
    auto r = (unsigned char) lroundf (clampf (rn, 0.0f, 255.0f, rounded));
    auto g = (unsigned char) lroundf (clampf (gn, 0.0f, 255.0f, rounded));
    auto b = (unsigned char) lroundf (clampf (bn, 0.0f, 255.0f, rounded));
    return {r, g, b, rounded};
}

