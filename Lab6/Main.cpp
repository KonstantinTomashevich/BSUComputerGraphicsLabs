#include <glad/gl.h>
#include "Constants.hpp"
#include "Shader.hpp"
#include "DiffuseColorMaterial.hpp"
#include "Geometry.hpp"
#include "Drawable.hpp"
#include "PerspectiveCamera.hpp"
#include "Vertex.hpp"
#include "EmptyMaterial.hpp"

#define GLFW_INCLUDE_NONE
#include <GLFW/glfw3.h>

#include <linmath.h>

#include <cstdlib>
#include <cstdio>
#include <iostream>

static void ErrorCallback (int error, const char *description)
{
    fprintf (stderr, "Error %d: %s\n", error, description);
}

static void KeyCallback (GLFWwindow *window, int key, int scancode, int action, int mods)
{
    if (key == GLFW_KEY_ESCAPE && action == GLFW_PRESS)
    {
        glfwSetWindowShouldClose (window, GLFW_TRUE);
    }
}

int main (int argumentCount, char **arguments)
{
    GLFWwindow *window;
    glfwSetErrorCallback (ErrorCallback);

    if (!glfwInit ())
    {
        exit (EXIT_FAILURE);
    }

    glfwWindowHint (GLFW_CONTEXT_VERSION_MAJOR, 2);
    glfwWindowHint (GLFW_CONTEXT_VERSION_MINOR, 0);

    window = glfwCreateWindow (1024, 768, "Konstantin Tomashevich CG Lab 6", NULL, NULL);
    if (!window)
    {
        glfwTerminate ();
        exit (EXIT_FAILURE);
    }

    glfwSetKeyCallback (window, KeyCallback);
    glfwMakeContextCurrent (window);
    gladLoadGL (glfwGetProcAddress);
    glfwSwapInterval (1);

    auto *shader = new Shader (vertexColorVertexShader, vertexColorFragmentShader);
    EmptyMaterial material;
    material.SetLinkedShader (shader);

    auto *geometry = new Geometry <Position3fColorUIntVertex, Position3fColor3ubVertexConfigurator> ();
    geometry->AddVertex ({-0.6f, -0.4f, 0.0f, 255, 0, 0});
    geometry->AddVertex ({0.6f, -0.4f, 0.0f, 0, 255, 0});
    geometry->AddVertex ({0.0f, 0.6f, 0.0f, 0, 0, 255});
    geometry->AddVertex ({0.0f, 1.0f, 0.0f, 0, 0, 255});

    geometry->SetPrimitiveType (GL_TRIANGLES);
    geometry->AddTriangle (0, 1, 2);
    geometry->AddTriangle (1, 2, 3);
    geometry->UpdateBuffers ();

    auto *drawable = new Drawable ();
    drawable->SetLinkedGeometry (geometry);
    drawable->SetLinkedMaterial (&material);

    drawable->SetLocalPosition (5.0f, 0.0f, -10.0f);
    drawable->SetLocalScale (1.0f, 2.0f, 1.0f);

    auto *camera = new PerspectiveCamera (M_PI / 3, 0.01f, 100.0f);
    camera->SetLocalPosition (5.0f, 0.0f, 0.0f);

    while (!glfwWindowShouldClose (window))
    {
        int width, height;
        glfwGetFramebufferSize (window, &width, &height);

        glViewport (0, 0, width, height);
        glClear (GL_COLOR_BUFFER_BIT);

        mat4x4 projection;
        camera->GetViewMatrix (width, height, projection);

        drawable->SetLocalRotation (0.0f, 0.0f, (float) glfwGetTime ());
        drawable->Draw (projection);

        glfwSwapBuffers (window);
        glfwPollEvents ();
    }

    delete drawable;
    delete shader;
    delete camera;
    delete geometry;
    glfwDestroyWindow (window);

    glfwTerminate ();
    exit (EXIT_SUCCESS);
}
