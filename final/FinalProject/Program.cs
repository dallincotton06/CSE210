using System;
using FinalProject.Rendering;
using FinalProject.Shape;
using FinalProject.Triangulator;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
class Program {

    private static ShapeBatch batch = new();
    
    public static void Main(string[] args) {

        EarClippingTriangulator triangulator = new();
        triangulator.computeTriangles(new Polygon(new float[] {
            0.75f, -0.3f,       // Vertex 1 (right)
            0.425f, -0.083f,    // Vertex 2 (top-right)
            0.175f, -0.083f,    // Vertex 3 (top-left)
            0.05f, -0.3f,       // Vertex 4 (left)
            0.175f, -0.517f,    // Vertex 5 (bottom-left)
            0.425f, -0.517f     // Vertex 6 (bottom-right)
        }.ToList()));
        GLWindow window = new GLWindow();
        window.Run();
    }
}