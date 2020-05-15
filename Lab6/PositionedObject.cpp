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

const quat &PositionedObject::GetLocalRotation () const
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
    quat q1, q2;
    quat_identity (rotation_);
    quat_identity (q1);
    quat_identity (q1);

    quat_rotate (rotation_, x, (float *) xAxis);
    quat_rotate (q1, y, (float *) yAxis);

    quat_mul (q2, rotation_, q1);
    quat_rotate (q1, z, (float *) zAxis);

    quat_mul (rotation_, q2, q1);
    MarkDirty ();
}

void PositionedObject::SetLocalRotation (float x, float y, float z, float w)
{
    rotation_[0] = x;
    rotation_[1] = y;
    rotation_[2] = z;
    rotation_[3] = w;

    quat_norm (rotation_, rotation_);
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

    mat4x4 rotationMatrix;
    mat4x4_from_quat (rotationMatrix, rotation_);
    mat4x4_mul (modelSpaceMatrix_, modelSpaceMatrix_, rotationMatrix);
    matrixDirty_ = false;
}
