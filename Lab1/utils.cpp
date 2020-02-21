#include "utils.h"

float clampf (float value, float min, float max, bool &changed)
{
    if (value < min)
    {
        changed = true;
        return min;
    }
    else if (value > max)
    {
        changed = true;
        return max;
    }
    else
    {
        return value;
    }
}
