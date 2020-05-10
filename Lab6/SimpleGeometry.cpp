#include "SimpleGeometry.hpp"
#include <stdexcept>

SimpleGeometry::SimpleGeometry ()
    : vertices_ (),
      indices_ ()
{
}

void SimpleGeometry::SetPrimitiveType (GLuint primitive)
{
    if (primitiveType_ == primitive)
    {
        return;;
    }

    if (!indices_.empty ())
    {
        throw std::runtime_error ("Found attempt to change primitive while indices are already set!");
    }

    primitiveType_ = primitive;
}

void SimpleGeometry::ClearVertices ()
{
    vertices_.clear ();
}

void SimpleGeometry::ClearIndices ()
{
    indices_.clear ();
}

void SimpleGeometry::AddVertex (GLfloat x, GLfloat y, GLfloat z)
{
    vertices_.push_back (x);
    vertices_.push_back (y);
    vertices_.push_back (z);
}

void SimpleGeometry::AddTriangle (GLuint i0, GLuint i1, GLuint i2)
{
    if (primitiveType_ != GL_TRIANGLES)
    {
        throw std::runtime_error ("Found attempt to add triangle while geometry is not in triangle mode!");
    }

    indices_.push_back (i0);
    indices_.push_back (i1);
    indices_.push_back (i2);
}

void SimpleGeometry::AddLine (GLuint i0, GLuint i1)
{
    if (primitiveType_ != GL_LINES)
    {
        throw std::runtime_error ("Found attempt to add line while geometry is not in lines mode!");
    }

    indices_.push_back (i0);
    indices_.push_back (i1);
}

void SimpleGeometry::SetupPositionAttribute (GLuint location)
{
    glVertexAttribPointer (location, 3, GL_FLOAT, GL_FALSE, sizeof (vertices_[0]) * 3, nullptr);
}

void *SimpleGeometry::GetVertexBuffer ()
{
    return &vertices_[0];
}

void *SimpleGeometry::GetIndexBuffer ()
{
    return &indices_[0];
}

size_t SimpleGeometry::GetVertexBufferSize ()
{
    return vertices_.size () * sizeof (vertices_[0]);
}

size_t SimpleGeometry::GetIndexBufferSize ()
{
    return indices_.size () * sizeof (indices_[0]);
}
