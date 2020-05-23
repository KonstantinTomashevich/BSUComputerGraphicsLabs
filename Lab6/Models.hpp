#pragma once
#include "Geometry.hpp"
#include "Vertex.hpp"
#include <functional>

AbstractGeometry *Generate2DGrid (int xLines, int yLines, Color3ubVertex color);
AbstractGeometry *GenerateTSymbol ();
AbstractGeometry *GenerateXAxisLine ();
void AddPlaneToGeometry (GeometryBase *geometry, int v1, int v2, int v3, int v4);

template <typename V, VertexConfigurator C> int AddHorizontalPlaceToGeometry (
    Geometry <V, C> *geometry, float x0, float y0, float x1, float y1, float z,
    std::function <V (Position3fVertex)> vertexConstructor, bool addPlane = false, bool planeUp = false)
{
    if (x0 > x1)
    {
        std::swap (x0, x1);
    }

    if (y0 > y1)
    {
        std::swap (y0, y1);
    }

    int leftBack = geometry->AddVertex (vertexConstructor ({x0, y0, z}));
    int leftFront = geometry->AddVertex (vertexConstructor ({x0, y1, z}));
    int rightFront = geometry->AddVertex (vertexConstructor ({x1, y1, z}));
    int rightBack = geometry->AddVertex (vertexConstructor ({x1, y0, z}));

    if (addPlane)
    {
        if (planeUp)
        {
            AddPlaneToGeometry (geometry, leftBack, leftFront, rightFront, rightBack);
        }
        else
        {
            AddPlaneToGeometry (geometry, rightBack, rightFront, leftFront, leftBack);
        }
    }

    return leftBack;
}

template <typename V, VertexConfigurator C> void AddColumnToGeometry (
    Geometry <V, C> *geometry, Position3fVertex start, Position3fVertex end,
    bool addBasement, bool addRoof, std::function <V (Position3fVertex)> vertexConstructor)
{
    if (start.x > end.x)
    {
        std::swap (start.x, end.x);
    }

    if (start.y > end.y)
    {
        std::swap (start.y, end.y);
    }

    if (start.z > end.z)
    {
        std::swap (start.z, end.z);
    }

    int startBasementVertex = AddHorizontalPlaceToGeometry (
        geometry, start.x, start.y, end.x, end.y, start.z, vertexConstructor, addBasement, false);
    int startRoofVertex = AddHorizontalPlaceToGeometry (
        geometry, start.x, start.y, end.x, end.y, end.z, vertexConstructor, addRoof, true);

    AddPlaneToGeometry (geometry, startBasementVertex, startRoofVertex,
                        startRoofVertex + 3, startBasementVertex + 3);

    AddPlaneToGeometry (geometry, startBasementVertex + 1, startBasementVertex + 2,
                        startRoofVertex + 2, startRoofVertex + 1);

    AddPlaneToGeometry (geometry, startBasementVertex, startBasementVertex + 1,
                        startRoofVertex + 1, startRoofVertex);

    AddPlaneToGeometry (geometry, startBasementVertex + 2, startBasementVertex + 3,
                        startRoofVertex + 3, startRoofVertex + 2);
}
