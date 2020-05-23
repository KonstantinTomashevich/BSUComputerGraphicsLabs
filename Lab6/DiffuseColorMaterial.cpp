#include "Constants.hpp"
#include "DiffuseColorMaterial.hpp"

DiffuseColorMaterial::DiffuseColorMaterial ()
{
    SetColor ({0.0f, 0.0f, 0.0f});
}

DiffuseColorMaterial::DiffuseColorMaterial (const glm::vec3 &color, Shader *linkedShader)
{
    SetColor (color);
    SetLinkedShader (linkedShader);
}

void DiffuseColorMaterial::SetColor (const glm::vec3 &color)
{
    diffuseColor_ = color;
}

void DiffuseColorMaterial::DoApply ()
{
    GetLinkedShader ()->SetVec3f (diffuseColorUniformNameHash, diffuseColor_);
}
