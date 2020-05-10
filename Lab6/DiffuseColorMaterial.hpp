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
    vec3 diffuseColor_;
};
