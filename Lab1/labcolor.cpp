#include "labcolor.h"

LABColor::LABColor ()
    : l_ (-128.0f), a_ (-128.0f), b_ (-128.0f)
{
}

LABColor::LABColor (float l, float a, float b)
    : l_ (l), a_ (a), b_ (b)
{}
