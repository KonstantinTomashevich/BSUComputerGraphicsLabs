#include "Shader.hpp"

Shader::Shader (const char *vertexCode, const char *fragmentCode)
    : uniformHandles_ (),
      attributeHandles_ ()
{
    SetupProgram (vertexCode, fragmentCode);
    FetchAttributesAndUniforms ();
}

Shader::~Shader ()
{
    glDeleteProgram (programHandle_);
}

void Shader::Apply () const
{
    glUseProgram (programHandle_);
}

GLuint Shader::GetAttributeHandle (std::size_t nameHash) const
{
    return attributeHandles_.at (nameHash);
}

void Shader::SetVec3f (std::size_t nameHash, vec3 value)
{
    glUniform3f (uniformHandles_.at (nameHash), value[0], value[1], value[2]);
}

void Shader::SetMat4x4f (std::size_t nameHash, mat4x4 value)
{
    glUniformMatrix4fv (uniformHandles_.at (nameHash), 1, GL_FALSE, (const GLfloat *) value);
}

void Shader::SetupProgram (const char *vertexCode, const char *fragmentCode)
{
    GLuint vertexShader = glCreateShader (GL_VERTEX_SHADER);
    glShaderSource (vertexShader, 1, &vertexCode, NULL);
    glCompileShader (vertexShader);

    GLuint fragmentShader = glCreateShader (GL_FRAGMENT_SHADER);
    glShaderSource (fragmentShader, 1, &fragmentCode, NULL);
    glCompileShader (fragmentShader);

    programHandle_ = glCreateProgram ();
    glAttachShader (programHandle_, vertexShader);
    glAttachShader (programHandle_, fragmentShader);
    glLinkProgram (programHandle_);

    glDeleteShader (vertexShader);
    glDeleteShader (fragmentShader);
}

void Shader::FetchAttributesAndUniforms ()
{
    GLint count;
    GLint size;
    GLenum type;

    const GLsizei maxNameLength = 32;
    GLchar name[maxNameLength + 1];
    GLsizei nameLength;

    glGetProgramiv (programHandle_, GL_ACTIVE_ATTRIBUTES, &count);
    for (GLint index = 0; index < count; index++)
    {
        glGetActiveAttrib (programHandle_, (GLuint) index, maxNameLength, &nameLength, &size, &type, name);
        name[nameLength] = '\0';

        attributeHandles_[std::hash <std::string> {} (name)] = glGetAttribLocation (programHandle_, name);
        printf ("Debug: found attribute #%d Type: %u Name: %s\n", index, type, name);
    }

    glGetProgramiv (programHandle_, GL_ACTIVE_UNIFORMS, &count);
    for (GLint index = 0; index < count; index++)
    {
        glGetActiveUniform (programHandle_, (GLuint) index, maxNameLength, &nameLength, &size, &type, name);
        name[nameLength] = '\0';

        uniformHandles_[std::hash <std::string> {} (name)] = glGetUniformLocation (programHandle_, name);
        printf ("Debug: found uniform #%d Type: %u Name: %s\n", index, type, name);
    }
}
