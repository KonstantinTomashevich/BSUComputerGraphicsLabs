#include <glad/gl.h>
#include "Constants.hpp"
#include "Shader.hpp"
#include "Geometry.hpp"
#include "Drawable.hpp"
#include "PerspectiveCamera.hpp"
#include "Vertex.hpp"
#include "EmptyMaterial.hpp"
#include "Models.hpp"

#define GLFW_INCLUDE_NONE
#include <GLFW/glfw3.h>

#include <linmath.h>

#include <cstdlib>
#include <cstdio>

#define CAMERA_MOVE_SPEED 5.0f

struct
{
    double deltaTime = 0.0;
    AbstractCamera *activeCamera = nullptr;
    bool keyDown[GLFW_KEY_LAST + 1] = {false};
} Context;

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

    if (action == GLFW_PRESS && key != GLFW_KEY_UNKNOWN)
    {
        Context.keyDown[key] = true;
    }
    else if (action == GLFW_RELEASE && key != GLFW_KEY_UNKNOWN)
    {
        Context.keyDown[key] = false;
    }
}

static void MoveCamera (int xDir, int yDir, int zDir)
{
    const vec3 &cameraPosition = Context.activeCamera->GetLocalPosition ();
    Context.activeCamera->SetLocalPosition (
        cameraPosition[0] + (float) Context.deltaTime * (float) xDir * CAMERA_MOVE_SPEED,
        cameraPosition[1] + (float) Context.deltaTime * (float) yDir * CAMERA_MOVE_SPEED,
        cameraPosition[2] + (float) Context.deltaTime * (float) zDir * CAMERA_MOVE_SPEED);
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
    glEnable (GL_DEPTH_TEST);

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

    AbstractGeometry *gridGeometry = Generate2DGrid (21, 21, {150, 0, 0});

    auto *gridDrawable = new Drawable ();
    gridDrawable->SetLinkedGeometry (gridGeometry);
    gridDrawable->SetLinkedMaterial (&material);

    gridDrawable->SetLocalPosition (0.0f, 0.0f, 0.0f);
    gridDrawable->SetLocalScale (10.0f, 10.0f, 10.0f);

    auto *drawable = new Drawable ();
    drawable->SetLinkedGeometry (geometry);
    drawable->SetLinkedMaterial (&material);

    drawable->SetLocalPosition (0.0f, 0.0f, 0.0f);
    drawable->SetLocalScale (1.0f, 2.0f, 1.0f);

    auto *camera = new PerspectiveCamera (M_PI / 3, 0.01f, 100.0f);
    camera->SetLocalPosition (0.0f, 0.0f, 5.0f);
    camera->SetLocalRotation (45.0f, 0.0f, 0.0f);
    Context.activeCamera = camera;

    double lastFrameTime = glfwGetTime ();
    while (!glfwWindowShouldClose (window))
    {
        double currentFrameTime = glfwGetTime ();
        Context.deltaTime = currentFrameTime - lastFrameTime;
        lastFrameTime = currentFrameTime;

        int width, height;
        glfwGetFramebufferSize (window, &width, &height);

        glViewport (0, 0, width, height);
        glClear (GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

        MoveCamera (
            Context.keyDown[GLFW_KEY_A] ? -1 : (Context.keyDown[GLFW_KEY_D] ? 1 : 0),
            Context.keyDown[GLFW_KEY_S] ? -1 : (Context.keyDown[GLFW_KEY_W] ? 1 : 0),
            Context.keyDown[GLFW_KEY_Q] ? -1 : (Context.keyDown[GLFW_KEY_E] ? 1 : 0)
        );

        mat4x4 projection;
        camera->GetViewMatrix (width, height, projection);

        gridDrawable->Draw (projection);
        drawable->SetLocalRotation (0.0f, 0.0f,
                                    drawable->GetLocalRotation ()[2] + (float) (Context.deltaTime * M_PI));
        drawable->Draw (projection);

        glfwSwapBuffers (window);
        glfwPollEvents ();
    }

    delete drawable;
    delete shader;
    delete camera;
    delete geometry;

    delete gridGeometry;
    delete gridDrawable;
    glfwDestroyWindow (window);

    glfwTerminate ();
    exit (EXIT_SUCCESS);
}
