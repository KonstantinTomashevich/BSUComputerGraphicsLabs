#include "PositionedObject.hpp"
#include "Constants.hpp"
#include <glm/ext/matrix_transform.hpp>
#include <glm/gtx/quaternion.hpp>
#include <glm/gtx/matrix_operation.hpp>

PositionedObject::PositionedObject ()
{
    SetLocalPosition ({0, 0, 0});
    SetLocalRotation ({0, 0, 0});
    SetLocalScale ({1, 1, 1});
}

const glm::mat4x4 &PositionedObject::GetMatrix ()
{
    if (matrixDirty_)
    {
        RecalculateMatrix ();
    }

    return modelSpaceMatrix_;
}

const glm::vec3 &PositionedObject::GetLocalPosition () const
{
    return position_;
}

const glm::quat &PositionedObject::GetLocalRotation () const
{
    return rotation_;
}

const glm::vec3 &PositionedObject::GetLocalScale () const
{
    return scale_;
}

void PositionedObject::SetLocalPosition (const glm::vec3 &position)
{
    position_ = position;
    MarkDirty ();
}

void PositionedObject::SetLocalRotation (const glm::vec3 &euler)
{
    rotation_ = glm::quat (euler);
    MarkDirty ();
}

void PositionedObject::SetLocalRotation (const glm::quat &rotation)
{
    rotation_ = rotation;
    MarkDirty ();
}

void PositionedObject::SetLocalScale (const glm::vec3 &scale)
{
    scale_ = scale;
    MarkDirty ();
}

void PositionedObject::MarkDirty ()
{
    matrixDirty_ = true;
}

void PositionedObject::RecalculateMatrix ()
{
    modelSpaceMatrix_ = glm::identity <glm::mat4x4> ();
    modelSpaceMatrix_ = glm::translate (modelSpaceMatrix_, position_);
    modelSpaceMatrix_ *= glm::toMat4(rotation_);
    modelSpaceMatrix_ = glm::scale (modelSpaceMatrix_, scale_);
    matrixDirty_ = false;
}
