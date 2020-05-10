#include "PositionedObject.hpp"
#include "Constants.hpp"

PositionedObject::PositionedObject ()
{
    SetLocalPosition (0.0f, 0.0f, 0.0f);
    SetLocalRotation (0.0f, 0.0f, 0.0f);
    SetLocalScale (1.0f, 1.0f, 1.0f);
}

const mat4x4 &PositionedObject::GetMatrix ()
{
    if (matrixDirty_)
    {
        RecalculateMatrix ();
    }

    return modelSpaceMatrix_;
}

const vec3 &PositionedObject::GetLocalPosition () const
{
    return position_;
}

const vec3 &PositionedObject::GetLocalRotation () const
{
    return rotation_;
}

const vec3 &PositionedObject::GetLocalScale () const
{
    return scale_;
}

void PositionedObject::SetLocalPosition (float x, float y, float z)
{
    position_[0] = x;
    position_[1] = y;
    position_[2] = z;
    MarkDirty ();
}

void PositionedObject::SetLocalRotation (float x, float y, float z)
{
    rotation_[0] = x;
    rotation_[1] = y;
    rotation_[2] = z;
    MarkDirty ();
}

void PositionedObject::SetLocalScale (float x, float y, float z)
{
    scale_[0] = x;
    scale_[1] = y;
    scale_[2] = z;
    MarkDirty ();
}

void PositionedObject::MarkDirty ()
{
    matrixDirty_ = true;
}

void PositionedObject::RecalculateMatrix ()
{
    mat4x4_identity (modelSpaceMatrix_);
    mat4x4_translate (modelSpaceMatrix_, position_[0], position_[1], position_[2]);
    mat4x4_scale_aniso (modelSpaceMatrix_, modelSpaceMatrix_, scale_[0], scale_[1], scale_[2]);

    mat4x4_rotate_X (modelSpaceMatrix_, modelSpaceMatrix_, rotation_[0]);
    mat4x4_rotate_Y (modelSpaceMatrix_, modelSpaceMatrix_, rotation_[1]);
    mat4x4_rotate_Z (modelSpaceMatrix_, modelSpaceMatrix_, rotation_[2]);
    matrixDirty_ = false;
}
