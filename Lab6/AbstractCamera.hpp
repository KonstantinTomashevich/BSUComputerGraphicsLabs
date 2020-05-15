#pragma once
#include "PositionedObject.hpp"

class AbstractCamera : public PositionedObject
{
public:
    AbstractCamera ();
    virtual ~AbstractCamera () = default;

    void GetViewMatrix (unsigned int viewportWidth, unsigned int viewportHeight, glm::mat4x4 &output);

protected:
    virtual void RecalculateProjection (
        unsigned int viewportWidth, unsigned int viewportHeight, glm::mat4x4 &output) = 0;

    bool projectionDirty_;

private:
    unsigned int previousViewportWidth_;
    unsigned int previousViewportHeight_;

    glm::mat4x4 projection_;
};
