#include "Geometry.hpp"
#include <stdexcept>

GeometryBase::GeometryBase ()
    : indices_ ()
{
}

void GeometryBase::SetPrimitiveType (GLuint primitive)
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

void GeometryBase::ClearIndices ()
{
    indices_.clear ();
}

void GeometryBase::AddTriangle (GLuint i0, GLuint i1, GLuint i2)
{
    if (primitiveType_ != GL_TRIANGLES)
    {
        throw std::runtime_error ("Found attempt to add triangle while geometry is not in triangle mode!");
    }

    indices_.push_back (i0);
    indices_.push_back (i1);
    indices_.push_back (i2);
}

void GeometryBase::AddLine (GLuint i0, GLuint i1)
{
    if (primitiveType_ != GL_LINES)
    {
        throw std::runtime_error ("Found attempt to add line while geometry is not in lines mode!");
    }

    indices_.push_back (i0);
    indices_.push_back (i1);
}

void *GeometryBase::GetIndexBuffer ()
{
    return &indices_[0];
}

size_t GeometryBase::GetIndexBufferSize ()
{
    return indices_.size () * sizeof (indices_[0]);
}
