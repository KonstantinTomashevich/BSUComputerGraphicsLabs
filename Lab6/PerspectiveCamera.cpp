//
// Created by Konstant on 5/10/2020.
//

#include "PerspectiveCamera.hpp"

PerspectiveCamera::PerspectiveCamera (float fov, float near, float far)
    : fov_ (fov),
      near_ (near),
      far_ (far)
{
}

void PerspectiveCamera::RecalculateProjection (
    unsigned int viewportWidth, unsigned int viewportHeight, const mat4x4 &output)
{
    mat4x4_perspective ((vec4 *) output, fov_, (float) viewportWidth / (float) viewportHeight, near_, far_);
}

float PerspectiveCamera::GetFov () const
{
    return fov_;
}

void PerspectiveCamera::SetFov (float fov)
{
    fov_ = fov;
    projectionDirty_ = true;
}

float PerspectiveCamera::GetNear () const
{
    return near_;
}

void PerspectiveCamera::SetNear (float near)
{
    near_ = near;
    projectionDirty_ = true;
}

float PerspectiveCamera::GetFar () const
{
    return far_;
}

void PerspectiveCamera::SetFar (float far)
{
    far_ = far;
    projectionDirty_ = true;
}
