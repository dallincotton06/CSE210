using OpenTK.Graphics.OpenGL4;

namespace FinalProject.Rendering;

using FinalProject.Shape;
public class ShapeBatch {
    
    List<Shape> drawabels = new List<Shape>();
    
    

    private void draw(Shape shape) {
        int vertexBufferObject;
        int vertexArrayObject;
        List<float> vertices = shape.batch();
        
    }

    public void drawAll() {
        
    }

    public void add(Shape shape) {
        drawabels.Add(shape);
    }

    public void remove(Shape shape) {
        drawabels.Remove(shape);
    }

    public void clear() {
        drawabels.Clear();
    }
}