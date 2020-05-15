#pragma once
#include <linmath.h>

// TODO: Rewite as node for scene hierarchy support.
class PositionedObject
{
public:
    PositionedObject ();
    virtual ~PositionedObject () = default;

    const mat4x4 &GetMatrix ();
    const vec3 &GetLocalPosition () const;
    const quat &GetLocalRotation () const;
    const vec3 &GetLocalScale () const;

    void SetLocalPosition (float x, float y, float z);
    void SetLocalRotation (float x, float y, float z);
    void SetLocalRotation (float x, float y, float z, float w);
    void SetLocalScale (float x, float y, float z);

private:
    void MarkDirty ();
    void RecalculateMatrix ();

    vec3 position_;
    quat rotation_;
    vec3 scale_;

    bool matrixDirty_;
    mat4x4 modelSpaceMatrix_;
};
