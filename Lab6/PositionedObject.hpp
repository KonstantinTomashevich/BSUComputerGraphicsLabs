#pragma once
#include <glm/vec3.hpp>
#include <glm/mat4x4.hpp>
#include <glm/ext/quaternion_float.hpp>

// TODO: Rewite as node for scene hierarchy support.
class PositionedObject
{
public:
    PositionedObject ();
    virtual ~PositionedObject () = default;

    const glm::mat4x4 &GetMatrix ();
    const glm::vec3 &GetLocalPosition () const;
    const glm::quat &GetLocalRotation () const;
    const glm::vec3 &GetLocalScale () const;

    void SetLocalPosition (const glm::vec3 &position);
    void SetLocalRotation (const glm::vec3 &euler);
    void SetLocalRotation (const glm::quat &rotation);
    void SetLocalScale (const glm::vec3 &scale);

private:
    void MarkDirty ();
    void RecalculateMatrix ();

    glm::vec3 position_;
    glm::quat rotation_;
    glm:: vec3 scale_;

    bool matrixDirty_;
    glm::mat4x4 modelSpaceMatrix_;
};
