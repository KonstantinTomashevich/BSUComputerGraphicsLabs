#include "AbstractCamera.hpp"
#include <glm/gtx/matrix_operation.hpp>

#include "../glfw/deps/linmath.h"
#include <glm/gtc/type_ptr.hpp>

AbstractCamera::AbstractCamera ()
    : previousViewportWidth_ (0),
      previousViewportHeight_ (0)
{
    projection_ = glm::identity <glm::mat4x4> ();
}

void AbstractCamera::GetViewMatrix (unsigned int viewportWidth, unsigned int viewportHeight, glm::mat4x4 &output)
{
    if (projectionDirty_ || viewportWidth != previousViewportWidth_ || viewportHeight != previousViewportHeight_)
    {
        RecalculateProjection (viewportWidth, viewportHeight, projection_);
        previousViewportWidth_ = viewportWidth;
        previousViewportHeight_ = viewportWidth;
        projectionDirty_ = false;
    }

    mat4x4 viewSpace;
    mat4x4_invert (viewSpace, (vec4 *) glm::value_ptr (GetMatrix ()));
    mat4x4 out;
    mat4x4_mul (out, (vec4 *) glm::value_ptr (projection_), viewSpace);
    output = projection_ * glm::inverse (GetMatrix ());
}
