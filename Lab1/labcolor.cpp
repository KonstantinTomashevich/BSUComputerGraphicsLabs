#include "labcolor.h"
#include "xyzcolor.h"
#include "utils.h"
#include <cmath>

LABColor::LABColor ()
    : l_ (0), a_ (-128), b_ (-128), rounded_ (false)
{
}

LABColor::LABColor (unsigned char l, short a, short b, bool rounded)
    : l_ (l), a_ (a), b_ (b), rounded_ (rounded)
{}

static float F (float x)
{
    if (x >= 0.008856f)
    {
        return powf (x, 1.0f / 3.0f);
    }
    else
    {
        return 7.787f * x + 16.0f / 116.0f;
    }
}

LABColor LABColor::fromXYZ (const XYZColor &xyz)
{
    bool  rounded = false;
    float l = 116 * F (xyz.y_ / 100.0f);
    float a = 500.0f * (F (xyz.x_ / 95.047f) - F (xyz.y_ / 100.0f));
    float b = 200.0f * (F (xyz.y_ / 100.0f) - F (xyz.z_ / 108.883f));

    l = clampf (l, 0.0f, 100.0f, rounded);
    a = clampf (a, -128.0f, 128.0f, rounded);
    b = clampf (b, -128.0f, 128.0f, rounded);

    return {(unsigned char) lroundf (l), (short) lroundf (a), (short) lroundf (b), rounded};
}
