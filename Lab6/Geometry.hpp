#pragma once
#include <vector>
#include <glad/gl.h>

#include "AbstractGeometry.hpp"
#include "Vertex.hpp"

class GeometryBase : public AbstractGeometry
{
public:
    GeometryBase ();
    virtual ~GeometryBase () = default;

    void SetPrimitiveType (GLuint primitive);
    void ClearIndices ();

    void AddTriangle (GLuint i0, GLuint i1, GLuint i2);
    void AddLine (GLuint i0, GLuint i1);

protected:
    void *GetIndexBuffer () override;
    size_t GetIndexBufferSize () override;

private:
    std::vector <GLuint> indices_;
};

template <typename VertexStruct, VertexConfigurator VertexConfigurator> class Geometry : public GeometryBase
{
public:
    Geometry ()
        : vertices_ ()
    {
    }

    virtual ~Geometry () = default;

    void ClearVertices ()
    {
        vertices_.clear ();
    }

    void AddVertex (VertexStruct vertex)
    {
        vertices_.push_back (vertex);
    }

protected:
    void ConfigureShader (Shader *shader) override
    {
        VertexConfigurator (shader, sizeof (vertices_[0]), 0);
    }

    void *GetVertexBuffer () override
    {
        return &vertices_[0];
    }

    size_t GetVertexBufferSize () override
    {
        return vertices_.size () * sizeof (VertexStruct);
    }

private:
    std::vector <VertexStruct> vertices_;
};
