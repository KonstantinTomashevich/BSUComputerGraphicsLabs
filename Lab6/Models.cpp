#include "Models.hpp"

AbstractGeometry *Generate2DGrid (int xLines, int yLines, Color3ubVertex color)
{
    auto *geometry = new Geometry <Position3fColorUIntVertex, Position3fColor3ubVertexConfigurator> ();
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
