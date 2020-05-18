#pragma once
#include "AbstractCamera.hpp"

class OrthographicCamera : public AbstractCamera
{
public:
    OrthographicCamera (float height, float near, float far);
    virtual ~OrthographicCamera () = default;

    float GetHeight () const;
    void SetHeight (float height);

    float GetNear () const;
    void SetNear (float near);

    float GetFar () const;
    void SetFar (float far);

protected:
    void RecalculateProjection (
        unsigned int viewportWidth, unsigned int viewportHeight, glm::mat4x4 &output) override;

private:
    float height_;
    float near_;
    float far_;
};
