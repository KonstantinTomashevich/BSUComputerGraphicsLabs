#include "Drawable.hpp"
#include "Constants.hpp"

Drawable::Drawable ()
    : linkedGeometry_ (nullptr),
      linkedMaterial_ (nullptr)
{
}

Drawable::Drawable (AbstractGeometry *linkedGeometry, AbstractMaterial *linkedMaterial)
    : linkedGeometry_ (linkedGeometry),
      linkedMaterial_ (linkedMaterial)
{
}

void Drawable::Draw (const glm::mat4x4 &viewSpace)
{
    if (linkedGeometry_ == nullptr)
    {
        throw std::runtime_error ("Found attempt to call Draw on Drawable without geometry!");
    }

    if (linkedMaterial_ == nullptr)
    {
        throw std::runtime_error ("Found attempt to call Draw on Drawable without material!");
    }

    const glm::mat4x4 &modelSpace = GetMatrix ();
    glm::mat4 mvp = viewSpace * modelSpace;

    // TODO: We could use something like renderer context to stop reapplying same materials and shaders.
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
