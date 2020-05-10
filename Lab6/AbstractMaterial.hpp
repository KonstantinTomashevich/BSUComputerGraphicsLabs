#pragma once
#include "Shader.hpp"

class AbstractMaterial
{
public:
    AbstractMaterial ();
    virtual ~AbstractMaterial () = default;

    void Apply ();
    Shader *GetLinkedShader () const;
    void SetLinkedShader (Shader *linkedShader);

protected:
    virtual void DoApply () = 0;

private:
    Shader *linkedShader_;
};
