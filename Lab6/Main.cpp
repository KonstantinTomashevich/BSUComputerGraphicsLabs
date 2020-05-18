#include <glad/glad.h>
#include "Constants.hpp"
#include "Shader.hpp"
#include "Geometry.hpp"
#include "Drawable.hpp"
#include "PerspectiveCamera.hpp"
#include "EmptyMaterial.hpp"
#include "Models.hpp"

#include <imgui.h>
#include <examples/imgui_impl_glfw.h>
#include <examples/imgui_impl_opengl3.h>
#include <glm/gtc/type_ptr.hpp>

#define GLFW_INCLUDE_NONE
#include <GLFW/glfw3.h>

#include <cstdlib>
#include <cstdio>

#define CAMERA_MOVE_SPEED 5.0f
#define GRID_SIZE 10.0f

struct
{
    double deltaTime = 0.0;
    ImGuiIO *imGuiIO_ = nullptr;
    GLFWwindow *window = nullptr;

    AbstractCamera *activeCamera = nullptr;
    Shader *shader = nullptr;
    AbstractMaterial *material = nullptr;
    AbstractCamera *perspectiveCamera = nullptr;

    AbstractGeometry *symbolGeometry = nullptr;
    AbstractGeometry *gridGeometry = nullptr;

    Drawable *symbolDrawable = nullptr;
    Drawable *gridOXYDrawable = nullptr;
    Drawable *gridOXZDrawable = nullptr;
    Drawable *gridOYZDrawable = nullptr;

    bool showOXYGrid = true;
    bool showOXZGrid = false;
    bool showOYZGrid = false;
} Context;

static void ErrorCallback (int error, const char *description);
static void KeyCallback (GLFWwindow *window, int key, int scancode, int action, int mods);
static void MoveCamera (int xDir, int yDir, int zDir);
static void MatrixToString (const glm::mat4x4 &matrix, std::string &string);

static void FreeResources ();
static void SetupScene ();
static void SetupImGUI ();
static void SetupGLFW ();

static void RenderScene(const glm::mat4x4 &projection);
static void UpdateCamera ();
static void UpdateViewport (glm::mat4x4 &projectionOutput);
static void RenderUI (const glm::mat4x4 &projection);

int main (int argumentCount, char **arguments)
{
    SetupGLFW ();
    SetupImGUI ();
    SetupScene ();

    double lastFrameTime = glfwGetTime ();
    while (!glfwWindowShouldClose (Context.window))
    {
        double currentFrameTime = glfwGetTime ();
        Context.deltaTime = currentFrameTime - lastFrameTime;
        lastFrameTime = currentFrameTime;

        glm::mat4x4 projection;
        UpdateViewport (projection);
        RenderScene (projection);
        RenderUI (projection);

        glfwSwapBuffers (Context.window);
        glfwPollEvents ();
        UpdateCamera ();
    }

    FreeResources ();
    exit (EXIT_SUCCESS);
}

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

static void MoveCamera (int xDir, int yDir, int zDir)
{
    const glm::vec3 &cameraPosition = Context.activeCamera->GetLocalPosition ();
    Context.activeCamera->SetLocalPosition (glm::vec3 (
        cameraPosition[0] + (float) Context.deltaTime * (float) xDir * CAMERA_MOVE_SPEED,
        cameraPosition[1] + (float) Context.deltaTime * (float) yDir * CAMERA_MOVE_SPEED,
        cameraPosition[2] + (float) Context.deltaTime * (float) zDir * CAMERA_MOVE_SPEED));
}

static void MatrixToString (const glm::mat4x4 &matrix, std::string &string)
{
    string = "";
    const float *value = glm::value_ptr (matrix);

    for (unsigned int row = 0; row < 4; ++row)
    {
        for (unsigned int col = 0; col < 4; ++col)
        {
            string += std::to_string (value[row * 4 + col]) + " ";
        }

        string += "\n";
    }
}

static void FreeResources ()
{
    delete Context.shader;
    delete Context.material;
    delete Context.perspectiveCamera;

    delete Context.symbolGeometry;
    delete Context.gridGeometry;

    delete Context.symbolDrawable;
    delete Context.gridOXYDrawable;
    delete Context.gridOXZDrawable;
    delete Context.gridOYZDrawable;

    ImGui_ImplOpenGL3_Shutdown ();
    ImGui_ImplGlfw_Shutdown ();
    ImGui::DestroyContext ();

    glfwDestroyWindow (Context.window);
    glfwTerminate ();
}

static void SetupScene ()
{
    Context.shader = new Shader (vertexColorVertexShader, vertexColorFragmentShader);
    Context.material = new EmptyMaterial ();
    Context.material->SetLinkedShader (Context.shader);

    Context.gridGeometry = Generate2DGrid (21, 21, {150, 0, 0});
    Context.gridOXYDrawable = new Drawable (Context.gridGeometry, Context.material);
    Context.gridOXYDrawable->SetLocalScale ({GRID_SIZE, GRID_SIZE, GRID_SIZE});

    Context.gridOXZDrawable = new Drawable (Context.gridGeometry, Context.material);
    Context.gridOXZDrawable->SetLocalScale ({GRID_SIZE, GRID_SIZE, GRID_SIZE});
    Context.gridOXZDrawable->SetLocalRotation ({M_PI / 2, 0.0f, 0.0f});

    Context.gridOYZDrawable = new Drawable (Context.gridGeometry, Context.material);
    Context.gridOYZDrawable->SetLocalScale ({GRID_SIZE, GRID_SIZE, GRID_SIZE});
    Context.gridOYZDrawable->SetLocalRotation ({0.0f, M_PI / 2, 0.0f});

    Context.symbolGeometry = GenerateTSymbol ();
    Context.symbolDrawable = new Drawable (Context.symbolGeometry, Context.material);

    Context.perspectiveCamera = new PerspectiveCamera (M_PI / 3, 0.01f, 100.0f);
    Context.perspectiveCamera->SetLocalPosition ({0.0f, -10.0f, 5.0f});
    Context.perspectiveCamera->SetLocalRotation ({M_PI / 4, 0.0f, 0.0f});
    Context.activeCamera = Context.perspectiveCamera;
}

static void SetupImGUI ()
{
    IMGUI_CHECKVERSION();
    ImGui::CreateContext ();
    Context.imGuiIO_ = &ImGui::GetIO ();

    ImGui_ImplGlfw_InitForOpenGL (Context.window, true);
    ImGui_ImplOpenGL3_Init ("#version 150");
    ImGui::StyleColorsDark ();
    Context.imGuiIO_->Fonts->AddFontDefault ();
}

static void SetupGLFW ()
{
    glfwSetErrorCallback (ErrorCallback);

    if (!glfwInit ())
    {
        exit (EXIT_FAILURE);
    }

    glfwWindowHint (GLFW_CONTEXT_VERSION_MAJOR, 2);
    glfwWindowHint (GLFW_CONTEXT_VERSION_MINOR, 0);

    Context.window = glfwCreateWindow (1200, 900,
        "Konstantin Tomashevich CG Lab 6", NULL, NULL);

    if (!Context.window)
    {
        glfwTerminate ();
        exit (EXIT_FAILURE);
    }

    glfwSetKeyCallback (Context.window, KeyCallback);
    glfwMakeContextCurrent (Context.window);
    glfwSwapInterval (1);

    gladLoadGLLoader ((GLADloadproc) glfwGetProcAddress);
    glEnable (GL_DEPTH_TEST);
}

static void RenderScene (const glm::mat4x4 &projection)
{
    if (Context.showOXYGrid)
    {
        Context.gridOXYDrawable->Draw (projection);
    }

    if (Context.showOXZGrid)
    {
        Context.gridOXZDrawable->Draw (projection);
    }

    if (Context.showOYZGrid)
    {
        Context.gridOYZDrawable->Draw (projection);
    }

    Context.symbolDrawable->Draw (projection);
}

static void UpdateCamera ()
{
    if (!Context.imGuiIO_->WantCaptureKeyboard)
    {
        MoveCamera (
            Context.imGuiIO_->KeysDown[GLFW_KEY_A] ? -1 : (Context.imGuiIO_->KeysDown[GLFW_KEY_D] ? 1 : 0),
            Context.imGuiIO_->KeysDown[GLFW_KEY_S] ? -1 : (Context.imGuiIO_->KeysDown[GLFW_KEY_W] ? 1 : 0),
            Context.imGuiIO_->KeysDown[GLFW_KEY_Q] ? -1 : (Context.imGuiIO_->KeysDown[GLFW_KEY_E] ? 1 : 0)
        );
    }
}

static void UpdateViewport (glm::mat4x4 &projectionOutput)
{
    int width, height;
    glfwGetFramebufferSize (Context.window, &width, &height);

    glViewport (0, 0, width, height);
    glClear (GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
    Context.activeCamera->GetViewMatrix (width, height, projectionOutput);
}

static void RenderUI (const glm::mat4x4 &projection)
{
    ImGui_ImplOpenGL3_NewFrame ();
    ImGui_ImplGlfw_NewFrame ();
    ImGui::NewFrame ();

    ImGui::SetNextWindowPos (ImVec2 (0, 0), ImGuiCond_Appearing);
    ImGui::Begin ("Configuration Window");

    if (ImGui::CollapsingHeader ("Transform"))
    {
        glm::vec3 position = Context.symbolDrawable->GetLocalPosition ();
        glm::quat qRotation = Context.symbolDrawable->GetLocalRotation ();
        glm::vec3 eulerRotation = glm::degrees (glm::eulerAngles (qRotation));

        glm::vec3 scale = Context.symbolDrawable->GetLocalScale ();
        ImGui::InputFloat3 ("Position: ", glm::value_ptr (position));
        ImGui::InputFloat4 ("Rotation: ", glm::value_ptr (qRotation));

        if (ImGui::InputFloat3 ("Rotation (euler, degrees): ", glm::value_ptr (eulerRotation)))
        {
            qRotation = glm::quat (glm::radians (eulerRotation));
        }

        ImGui::InputFloat3 ("Scale: ", glm::value_ptr (scale));
        Context.symbolDrawable->SetLocalPosition (position);
        Context.symbolDrawable->SetLocalRotation (qRotation);
        Context.symbolDrawable->SetLocalScale (scale);
    }

    if (ImGui::CollapsingHeader ("Grids"))
    {
        ImGui::Checkbox ("OXY", &Context.showOXYGrid);
        ImGui::Checkbox ("OXZ", &Context.showOXZGrid);
        ImGui::Checkbox ("OYZ", &Context.showOYZGrid);
    }

    std::string stringBuffer;
    if (ImGui::CollapsingHeader ("View Space Matrix"))
    {
        MatrixToString (projection, stringBuffer);
        ImGui::Text ("%s", stringBuffer.c_str ());
    }

    if (ImGui::CollapsingHeader ("Model Space Matrix"))
    {
        MatrixToString (Context.symbolDrawable->GetMatrix (), stringBuffer);
        ImGui::Text ("%s", stringBuffer.c_str ());
    }

    if (ImGui::CollapsingHeader ("Combined Matrix"))
    {
        MatrixToString (projection * Context.symbolDrawable->GetMatrix (), stringBuffer);
        ImGui::Text ("%s", stringBuffer.c_str ());
    }

    ImGui::End ();
    ImGui::Render ();
    ImGui_ImplOpenGL3_RenderDrawData (ImGui::GetDrawData ());
}

