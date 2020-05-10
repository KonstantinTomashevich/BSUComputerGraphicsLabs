#include "AbstractMaterial.hpp"

AbstractMaterial::AbstractMaterial ()
    : linkedShader_ (nullptr)
{
}

void AbstractMaterial::Apply ()
{
    if (linkedShader_ == nullptr)
    {
        throw std::runtime_error ("Unable to apply material without shader!");
    }

    linkedShader_->Apply ();
    DoApply ();
}

Shader *AbstractMaterial::GetLinkedShader () const
{
    return linkedShader_;
}

void AbstractMaterial::SetLinkedShader (Shader *linkedShader)
{
    linkedShader_ = linkedShader;
}
