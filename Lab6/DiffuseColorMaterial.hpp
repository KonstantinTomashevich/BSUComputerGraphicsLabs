#pragma once
#include "AbstractMaterial.hpp"

class DiffuseColorMaterial : public AbstractMaterial
{
public:
    DiffuseColorMaterial ();
    DiffuseColorMaterial (const glm::vec3 &color, Shader *linkedShader);

    virtual ~DiffuseColorMaterial () = default;
    void SetColor (const glm::vec3 &color);

protected:
    void DoApply () override;

private:
    glm::vec3 diffuseColor_;
};
