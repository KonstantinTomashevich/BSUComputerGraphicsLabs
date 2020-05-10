#include "Drawable.hpp"
#include "Constants.hpp"

Drawable::Drawable ()
    : linkedGeometry_ (nullptr),
      linkedMaterial_ (nullptr)
{
}

void Drawable::Draw (const mat4x4 &viewSpace)
{
    if (linkedGeometry_ == nullptr)
    {
        throw std::runtime_error ("Found attempt to call Draw on Drawable without geometry!");
    }

    if (linkedMaterial_ == nullptr)
    {
        throw std::runtime_error ("Found attempt to call Draw on Drawable without material!");
    }

    mat4x4 mvp;
    const mat4x4 &modelSpace = GetMatrix ();
    mat4x4_mul (mvp, (vec4 *) viewSpace, (vec4 *) modelSpace);

    linkedMaterial_->Apply ();
    linkedMaterial_->GetLinkedShader ()->SetMat4x4f (mvpUniformNameHash, mvp);
    linkedGeometry_->DrawElements (linkedMaterial_->GetLinkedShader ());
}

AbstractGeometry *Drawable::GetLinkedGeometry () const
{
    return linkedGeometry_;
}

void Drawable::SetLinkedGeometry (AbstractGeometry *linkedGeometry)
{
    linkedGeometry_ = linkedGeometry;
}

AbstractMaterial *Drawable::GetLinkedMaterial () const
{
    return linkedMaterial_;
}

void Drawable::SetLinkedMaterial (AbstractMaterial *linkedMaterial)
{
    linkedMaterial_ = linkedMaterial;
}
