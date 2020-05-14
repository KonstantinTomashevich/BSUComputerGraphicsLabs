#pragma once
#include "Shader.hpp"

typedef void (*VertexConfigurator) (Shader *shader, std::size_t stride, std::size_t offset);

typedef struct
{
    float x;
    float y;
    float z;
} Position3fVertex;

typedef struct
{
    unsigned char r;
    unsigned char g;
    unsigned char b;
} Color3ubVertex;

typedef struct
{
    Position3fVertex position;
    Color3ubVertex color;
} Position3fColor3ubVertex;

void Position3fVertexConfigurator (Shader *shader, std::size_t stride, std::size_t offset);
void ColorUIntVertexConfigurator (Shader *shader, std::size_t stride, std::size_t offset);
void Position3fColor3ubVertexConfigurator (Shader *shader, std::size_t stride, std::size_t offset);
