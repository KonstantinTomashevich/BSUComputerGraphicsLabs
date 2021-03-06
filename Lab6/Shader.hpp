#pragma once
#include <glad/glad.h>
#include <unordered_map>
#include <glm/vec3.hpp>
#include <glm/mat4x4.hpp>

class Shader
{
public:
    Shader (const char *vertexCode, const char *fragmentCode);
    virtual ~Shader ();

    void Apply () const;
    GLuint GetAttributeHandle (std::size_t nameHash) const;

    void SetVec3f (std::size_t nameHash, glm::vec3 value);
    void SetMat4x4f (std::size_t nameHash, glm::mat4x4 value);

private:
    void SetupProgram (const char *vertexCode, const char *fragmentCode);
    void CheckShaderCompilationStatus (GLuint shaderHandle, const char *code) const;
    void FetchAttributesAndUniforms ();

    GLuint programHandle_;
    std::unordered_map <std::size_t, GLuint> uniformHandles_;
    std::unordered_map <std::size_t, GLuint> attributeHandles_;
};
