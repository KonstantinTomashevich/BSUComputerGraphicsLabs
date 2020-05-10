#include "AbstractGeometry.hpp"
#include "Constants.hpp"

AbstractGeometry::AbstractGeometry ()
    : primitiveType_ (GL_TRIANGLES),
      vertexBufferUsage_ (GL_STATIC_DRAW),
      indexBufferUsage_ (GL_STATIC_DRAW)
{
    glGenBuffers (1, &vertexBufferHandle_);
    glGenBuffers (1, &indexBufferHandle_);
}

AbstractGeometry::~AbstractGeometry ()
{
    glDeleteBuffers (1, &vertexBufferHandle_);
    glDeleteBuffers (1, &indexBufferHandle_);
}

void AbstractGeometry::UpdateBuffers ()
{
    glBindBuffer (GL_ARRAY_BUFFER, vertexBufferHandle_);
    glBufferData (GL_ARRAY_BUFFER, GetVertexBufferSize (), GetVertexBuffer (), vertexBufferUsage_);

    glBindBuffer (GL_ELEMENT_ARRAY_BUFFER, indexBufferHandle_);
    glBufferData (GL_ELEMENT_ARRAY_BUFFER, GetIndexBufferSize (), GetIndexBuffer (), GL_STATIC_DRAW);
}

void AbstractGeometry::DrawElements (Shader *shader)
{
    ConfigureShader (shader);
    glBindBuffer (GL_ARRAY_BUFFER, vertexBufferHandle_);
    glBindBuffer (GL_ELEMENT_ARRAY_BUFFER, indexBufferHandle_);
    glDrawElements (primitiveType_, GetIndexBufferSize (), GL_UNSIGNED_INT, nullptr);
}

GLuint AbstractGeometry::GetVertexBufferUsage () const
{
    return vertexBufferUsage_;
}

void AbstractGeometry::SetVertexBufferUsage (GLuint vertexBufferUsage)
{
    vertexBufferUsage_ = vertexBufferUsage;
}

GLuint AbstractGeometry::GetIndexBufferUsage () const
{
    return indexBufferUsage_;
}

void AbstractGeometry::SetIndexBufferUsage (GLuint indexBufferUsage)
{
    indexBufferUsage_ = indexBufferUsage;
}
