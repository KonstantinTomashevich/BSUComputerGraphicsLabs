#pragma once
#include "AbstractCamera.hpp"

class PerspectiveCamera : public AbstractCamera
{
public:
    PerspectiveCamera (float fov, float near, float far);
    virtual ~PerspectiveCamera () = default;

    float GetFov () const;
    void SetFov (float fov);

    float GetNear () const;
    void SetNear (float near);

    float GetFar () const;
    void SetFar (float far);

protected:
    void RecalculateProjection (
        unsigned int viewportWidth, unsigned int viewportHeight, glm::mat4x4 &output) override;

private:
    float fov_;
    float near_;
    float far_;
};
