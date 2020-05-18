#include <glm/gtx/matrix_operation.hpp>
#include "OrthographicCamera.hpp"

OrthographicCamera::OrthographicCamera (float height, float near, float far)
    : height_ (height),
      near_ (near),
      far_ (far)
{
}

float OrthographicCamera::GetHeight () const
{
    return height_;
}

void OrthographicCamera::SetHeight (float height)
{
    height_ = height;
    projectionDirty_ = true;
}

float OrthographicCamera::GetNear () const
{
    return near_;
}

void OrthographicCamera::SetNear (float near)
{
    near_ = near;
}

float OrthographicCamera::GetFar () const
{
    return far_;
}

void OrthographicCamera::SetFar (float far)
{
    far_ = far;
}

void OrthographicCamera::RecalculateProjection (unsigned int viewportWidth,
                                                unsigned int viewportHeight,
                                                glm::mat4x4 &output)
{
    float ratio = (float) viewportWidth / (float) viewportHeight;
    float width = ratio * height_;

    output = glm::ortho (-width / 2.0f, width / 2.0f,
                         -height_ / 2.0f, height_ / 2.0f, near_, far_);
}
