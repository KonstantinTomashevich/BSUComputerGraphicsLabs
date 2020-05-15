cmake_minimum_required(VERSION 3.15)
project(Lab6)

set(CMAKE_CXX_STANDARD 14)
set(GLFW_BUILD_DOCS OFF CACHE BOOL "" FORCE)
set(GLFW_BUILD_TESTS OFF CACHE BOOL "" FORCE)
set(GLFW_BUILD_EXAMPLES OFF CACHE BOOL "" FORCE)

add_subdirectory(../glfw ${CMAKE_BINARY_DIR}/glfw_build)
add_subdirectory(../glad ${CMAKE_BINARY_DIR}/glad_build)
add_subdirectory(../glm ${CMAKE_BINARY_DIR}/glm_build)
include_directories(../imgui)

add_executable(Lab6 Main.cpp Constants.cpp Constants.hpp
        Shader.cpp Shader.hpp AbstractMaterial.hpp DiffuseColorMaterial.cpp DiffuseColorMaterial.hpp
        AbstractGeometry.hpp Geometry.cpp Geometry.hpp AbstractGeometry.cpp PositionedObject.cpp PositionedObject.hpp
        Drawable.cpp Drawable.hpp AbstractMaterial.cpp AbstractCamera.cpp AbstractCamera.hpp
        PerspectiveCamera.cpp PerspectiveCamera.hpp Vertex.cpp Vertex.hpp Vertex.cpp
        EmptyMaterial.cpp EmptyMaterial.hpp Models.cpp Models.hpp ../imgui/imgui.cpp ../imgui/imgui.h
        ../imgui/imgui_draw.cpp ../imgui/imgui_widgets.cpp ../imgui/imgui_internal.h
        ../imgui/examples/imgui_impl_opengl3.cpp ../imgui/examples/imgui_impl_opengl3.h
        ../imgui/examples/imgui_impl_glfw.cpp ../imgui/examples/imgui_impl_glfw.h)

target_compile_definitions(Lab6 PUBLIC IMGUI_IMPL_OPENGL_LOADER_GLAD)
target_link_libraries(Lab6 glfw glad glm m)
