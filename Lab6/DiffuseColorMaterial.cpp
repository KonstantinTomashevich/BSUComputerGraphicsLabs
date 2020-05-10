#include "Constants.hpp"
#include "DiffuseColorMaterial.hpp"

DiffuseColorMaterial::DiffuseColorMaterial ()
{
    SetColor (0.0f, 0.0f, 0.0f);
}

void DiffuseColorMaterial::SetColor (float r, float g, float b)
{
    diffuseColor_[0] = r;
    diffuseColor_[1] = g;
    diffuseColor_[2] = b;
}

void DiffuseColorMaterial::DoApply ()
{
    GetLinkedShader ()->SetVec3f (diffuseColorUniformNameHash, diffuseColor_);
}
