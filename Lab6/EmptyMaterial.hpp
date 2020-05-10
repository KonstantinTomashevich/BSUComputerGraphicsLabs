#pragma once
#include "AbstractMaterial.hpp"

class EmptyMaterial : public AbstractMaterial
{
public:
    EmptyMaterial () = default;
    virtual ~EmptyMaterial () = default;

protected:
    void DoApply () override;
};
