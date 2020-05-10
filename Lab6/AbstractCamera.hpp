#pragma once
#include "PositionedObject.hpp"

class AbstractCamera : public PositionedObject
{
public:
    AbstractCamera ();
    virtual ~AbstractCamera () = default;

    void GetViewMatrix (unsigned int viewportWidth, unsigned int viewportHeight, const mat4x4 &output);

protected:
    virtual void RecalculateProjection (
        unsigned int viewportWidth, unsigned int viewportHeight, const mat4x4 &output) = 0;

    bool projectionDirty_;

private:
    unsigned int previousViewportWidth_;
    unsigned int previousViewportHeight_;

    mat4x4 projection_;
};
