#pragma once
#include <linmath.h>

class PositionedObject
{
public:
    PositionedObject ();
    virtual ~PositionedObject () = default;

    const mat4x4 &GetMatrix ();
    const vec3 &GetLocalPosition () const;
    const vec3 &GetLocalRotation () const;
    const vec3 &GetLocalScale () const;

    void SetLocalPosition (float x, float y, float z);
    void SetLocalRotation (float x, float y, float z);
    void SetLocalScale (float x, float y, float z);

private:
    void MarkDirty ();
    void RecalculateMatrix ();

    vec3 position_;
    vec3 rotation_;
    vec3 scale_;

    bool matrixDirty_;
    mat4x4 modelSpaceMatrix_;
};
