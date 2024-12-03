using System;
using FinalProject.Rendering;
using FinalProject.Shape;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Desktop;
using OpenTK.Mathematics;
class Program {

    private static ShapeBatch batch = new();
    
    public static void Main(string[] args) {
        batch.add(new Polygon(new float[] {
            
        }.ToList()));

        GLWindow window = new GLWindow();
        window.Run();
    }
}