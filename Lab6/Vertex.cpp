#include "Vertex.hpp"
#include "Constants.hpp"

void Position3fVertexConfigurator (Shader *shader, std::size_t stride, std::size_t offset)
{
    GLuint vPosAttribute = shader->GetAttributeHandle (positionAttributeNameHash);
    glEnableVertexAttribArray (vPosAttribute);
    glVertexAttribPointer (vPosAttribute, 3, GL_FLOAT, GL_FALSE, stride, (void *) offset);
}

void ColorUIntVertexConfigurator (Shader *shader, std::size_t stride, std::size_t offset)
{
    GLuint vColAttribute = shader->GetAttributeHandle (colorAttributeNameHash);
    glEnableVertexAttribArray (vColAttribute);
    glVertexAttribPointer (vColAttribute, 3, GL_UNSIGNED_BYTE, GL_TRUE, stride, (void *) offset);
}

void Position3fColor3ubVertexConfigurator (Shader *shader, std::size_t stride, std::size_t offset)
{
    Position3fVertexConfigurator (shader, stride, offset);
    ColorUIntVertexConfigurator (shader, stride, offset + sizeof (Position3fVertex));
}
