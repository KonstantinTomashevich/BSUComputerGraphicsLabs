#pragma once
#include <glad/gl.h>
#include <vector>
#include "Shader.hpp"

class AbstractGeometry
{
public:
    AbstractGeometry ();
    virtual ~AbstractGeometry ();

    void UpdateBuffers ();
    void DrawElements (Shader *shader);

    GLuint GetVertexBufferUsage () const;
    void SetVertexBufferUsage (GLuint vertexBufferUsage);
    GLuint GetIndexBufferUsage () const;
    void SetIndexBufferUsage (GLuint indexBufferUsage);

protected:
    GLuint primitiveType_;

    virtual void SetupPositionAttribute (GLuint location) = 0;
    virtual void *GetVertexBuffer () = 0;
    virtual void *GetIndexBuffer () = 0;

    virtual std::size_t GetVertexBufferSize () = 0;
    virtual std::size_t GetIndexBufferSize () = 0;

private:
    GLuint vertexBufferUsage_;
    GLuint indexBufferUsage_;
    GLuint vertexBufferHandle_;
    GLuint indexBufferHandle_;
};
