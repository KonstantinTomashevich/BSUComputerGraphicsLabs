#include "Models.hpp"

AbstractGeometry *Generate2DGrid (int xLines, int yLines, Color3ubVertex color)
{
    auto *geometry = new Geometry <Position3fColor3ubVertex, Position3fColor3ubVertexConfigurator> ();
    geometry->SetPrimitiveType (GL_LINES);

    float xStep = 2.0f / (float) (xLines - 1);
    float yStep = 2.0f / (float) (yLines - 1);

    float x = -1.0f;
    int vertexIndex = 0;

    for (int index = 0; index < xLines; ++index)
    {
        geometry->AddVertex ({x, -1.0f, 0.0f, color});
        geometry->AddVertex ({x, 1.0f, 0.0f, color});
        geometry->AddLine (vertexIndex, vertexIndex + 1);

        vertexIndex += 2;
        x += xStep;
    }

    float y = -1.0f;
    for (int index = 0; index < xLines; ++index)
    {
        geometry->AddVertex ({-1.0f, y, 0.0f, color});
        geometry->AddVertex ({1.0f, y, 0.0f, color});
        geometry->AddLine (vertexIndex, vertexIndex + 1);

        vertexIndex += 2;
        y += yStep;
    }

    geometry->UpdateBuffers ();
    return geometry;
}

AbstractGeometry *GenerateTSymbol ()
{
    auto *geometry = new Geometry <Position3fColor3ubVertex, Position3fColor3ubVertexConfigurator> ();
    geometry->SetPrimitiveType (GL_TRIANGLES);

    std::function<Position3fColor3ubVertex(Position3fVertex)> vertexConstructor = [] (Position3fVertex position)
    {
        Position3fColor3ubVertex vertex;
        vertex.position = position;
        vertex.color = {0, 0, 100};
        return vertex;
    };

    AddColumnToGeometry <Position3fColor3ubVertex, Position3fColor3ubVertexConfigurator> (
        geometry, {-0.1f, -0.1f, 0.0f}, {0.1f, 0.1f, 0.85f},
        true, false, vertexConstructor);

    AddColumnToGeometry <Position3fColor3ubVertex, Position3fColor3ubVertexConfigurator> (
        geometry, {-0.4f, -0.1f, 0.85f}, {0.4f, 0.1f, 1.0f},
        true, true, vertexConstructor);

    geometry->UpdateBuffers ();
    return geometry;
}

AbstractGeometry *GenerateXAxisLine ()
{
    auto *geometry = new Geometry <Position3fVertex, Position3fVertexConfigurator> ();
    geometry->SetPrimitiveType (GL_TRIANGLES);

    AddColumnToGeometry <Position3fVertex, Position3fVertexConfigurator> (
        geometry, {0.0f, -0.025f, -0.025f}, {1.0f, 0.025f, 0.025f},
        true, true, [] (Position3fVertex position) -> Position3fVertex { return position; });

    geometry->UpdateBuffers ();
    return geometry;
}

void AddPlaneToGeometry (GeometryBase *geometry, int v1, int v2, int v3, int v4)
{
    geometry->AddTriangle (v1, v2, v3);
    geometry->AddTriangle (v3, v4, v1);
}
