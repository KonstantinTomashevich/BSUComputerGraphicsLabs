#include "AbstractCamera.hpp"

AbstractCamera::AbstractCamera ()
    : previousViewportWidth_ (0),
      previousViewportHeight_ (0)
{
    mat4x4_identity (projection_);
}

void AbstractCamera::GetViewMatrix (unsigned int viewportWidth, unsigned int viewportHeight, const mat4x4 &output)
{
    if (projectionDirty_ || viewportWidth != previousViewportWidth_ || viewportHeight != previousViewportHeight_)
    {
        RecalculateProjection (viewportWidth, viewportHeight, projection_);
        previousViewportWidth_ = viewportWidth;
        previousViewportHeight_ = viewportWidth;
        projectionDirty_ = false;
    }

    mat4x4 viewSpace;
    mat4x4_invert (viewSpace, (vec4 *) GetMatrix ());
    mat4x4_mul ((vec4 *) output, projection_, viewSpace);
}
