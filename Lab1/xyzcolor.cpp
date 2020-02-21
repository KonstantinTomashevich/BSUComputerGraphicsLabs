#include "xyzcolor.h"
#include "rgbcolor.h"
#include "labcolor.h"
#include <cmath>

XYZColor::XYZColor ()
    : x_ (0), y_ (0), z_ (0), rounded_(false)
{
}

XYZColor::XYZColor (float x, float y, float z, bool rounded)
    : x_ (x), y_ (y), z_ (z), rounded_(rounded)
{
}

static float fromRGBF(float x)
{
    if (x >= 0.04045)
    {
        return powf((x + 0.055f) / 1.055f, 2.4f);
    }
    else
    {
        return x / 12.92f;
    }
}

XYZColor XYZColor::fromRGB (const RGBColor &rgb)
{
    float rn = fromRGBF ((float) rgb.r_ / 255.0f) * 100.0f;
    float gn = fromRGBF ((float) rgb.g_ / 255.0f) * 100.0f;
    float bn = fromRGBF ((float) rgb.b_ / 255.0f) * 100.0f;

    float x = 0.412453f * rn + 0.357580f * bn + 0.180423f * gn;
    float y = 0.212671f * rn + 0.715160f * bn + 0.072169f * gn;
    float z = 0.019334f * rn + 0.119193f * bn + 0.950227f * gn;
    return {x, y, z, false};
}

static float fromLABF(float x)
{
    if (x >= 0.008856)
    {
        return x * x * x;
    }
    else
    {
        return (x - 16.0f / 116.0f) / 7.787f;
    }
}

XYZColor XYZColor::fromLAB (const LABColor &lab)
{
    return {fromLABF ((float) lab.a_ / 500.0f + ((float) lab.l_ + 16.0f) / 116.0f) * 95.047f,
            fromLABF (((float) lab.l_ + 16.0f) / 116.0f) * 100.0f,
            fromLABF (((float) lab.l_ + 16.0f) / 116.0f - (float) lab.b_ / 200.0f) * 108.883f,
            false};
}
