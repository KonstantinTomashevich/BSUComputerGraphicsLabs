#include <string>
#include "Constants.hpp"

const char *simpleVertexShader =
    "#version 110\n"
    "uniform mat4 MVP;\n"
    "attribute vec3 vPos;\n"
    "void main()\n"
    "{\n"
    "    gl_Position = MVP * vec4(vPos, 1.0);\n"
    "}\n";

const char *diffuseFragmentShader =
    "#version 110\n"
    "uniform vec3 vDiffuseColor;\n"
    "void main()\n"
    "{\n"
    "    gl_FragColor = vec4(vDiffuseColor, 1.0);\n"
    "}\n";

const std::size_t mvpUniformNameHash = std::hash <std::string> {} ("MVP");

const std::size_t diffuseColorUniformNameHash = std::hash <std::string> {} ("vDiffuseColor");

const std::size_t positionAttributeNameHash = std::hash <std::string> {} ("vPos");

const vec3 xAxis = {1, 0, 0};

const vec3 yAxis = {0, 1, 0};

const vec3 zAxis = {0, 0, 1};
