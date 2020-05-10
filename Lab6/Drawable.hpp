#pragma once
#include <vector>
#include "AbstractGeometry.hpp"
#include "AbstractMaterial.hpp"
#include "PositionedObject.hpp"

class Drawable : public PositionedObject
{
public:
    Drawable ();
    virtual ~Drawable () = default;

    void Draw (const mat4x4 &viewSpace);
    AbstractGeometry *GetLinkedGeometry () const;
    void SetLinkedGeometry (AbstractGeometry *linkedGeometry);
    AbstractMaterial *GetLinkedMaterial () const;
    void SetLinkedMaterial (AbstractMaterial *linkedMaterial);

private:
    AbstractGeometry *linkedGeometry_;
    AbstractMaterial *linkedMaterial_;
};
