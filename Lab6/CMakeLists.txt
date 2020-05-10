cmake_minimum_required(VERSION 3.15)
project(Lab6)

set(CMAKE_CXX_STANDARD 14)
set(GLFW_BUILD_DOCS OFF CACHE BOOL "" FORCE)
set(GLFW_BUILD_TESTS OFF CACHE BOOL "" FORCE)
set(GLFW_BUILD_EXAMPLES OFF CACHE BOOL "" FORCE)

add_subdirectory(../glfw ${CMAKE_BINARY_DIR}/glfw_build)
include_directories(../glfw/deps)

add_executable(Lab6 Main.cpp ../glfw/deps/glad/gl.h ../glfw/deps/glad_gl.c Constants.cpp Constants.hpp
        Shader.cpp Shader.hpp AbstractMaterial.hpp DiffuseColorMaterial.cpp DiffuseColorMaterial.hpp
        AbstractGeometry.hpp Geometry.cpp Geometry.hpp AbstractGeometry.cpp PositionedObject.cpp PositionedObject.hpp Drawable.cpp Drawable.hpp AbstractMaterial.cpp AbstractCamera.cpp AbstractCamera.hpp PerspectiveCamera.cpp PerspectiveCamera.hpp Vertex.cpp Vertex.hpp Vertex.cpp EmptyMaterial.cpp EmptyMaterial.hpp)
target_link_libraries(Lab6 glfw m)
