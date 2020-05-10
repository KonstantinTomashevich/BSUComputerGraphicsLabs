#pragma once
#include <vector>
#include <glad/gl.h>
#include "AbstractGeometry.hpp"

class SimpleGeometry : public AbstractGeometry
{
public:
    SimpleGeometry ();
    virtual ~SimpleGeometry () = default;

    void SetPrimitiveType (GLuint primitive);
    void ClearVertices ();
    void ClearIndices ();

    void AddVertex (GLfloat x, GLfloat y, GLfloat z);
    void AddTriangle (GLuint i0, GLuint i1, GLuint i2);
    void AddLine (GLuint i0, GLuint i1);

protected:
    void SetupPositionAttribute (GLuint location) override;
    void *GetVertexBuffer () override;
    void *GetIndexBuffer () override;

    size_t GetVertexBufferSize () override;
    size_t GetIndexBufferSize () override;

private:
    std::vector <GLfloat> vertices_;
    std::vector <GLuint> indices_;
};
