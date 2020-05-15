#pragma once
#include "AbstractMaterial.hpp"

class DiffuseColorMaterial : public AbstractMaterial
{
public:
    DiffuseColorMaterial ();
    virtual ~DiffuseColorMaterial () = default;
    void SetColor (float r, float g, float b);

protected:
    void DoApply () override;

private:
    glm::vec3 diffuseColor_;
};
