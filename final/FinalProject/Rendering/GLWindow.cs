using OpenTK.Mathematics;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

class GLWindow : GameWindow {

    public GLWindow() : base(GameWindowSettings.Default, NativeWindowSettings.Default) { }

    protected override void OnLoad() {
        base.OnLoad();
        GL.ClearColor(Color4.CornflowerBlue);

        
        
        
        vertexArrayObject = GL.GenVertexArray();
        GL.BindVertexArray(vertexArrayObject);

        vertexBufferObject = GL.GenBuffer();
        GL.BindBuffer(BufferTarget.ArrayBuffer, vertexBufferObject);
        GL.BufferData(BufferTarget.ArrayBuffer, vertices.Length * sizeof(float), vertices, BufferUsageHint.StaticDraw);

        GL.VertexAttribPointer(0, 2, VertexAttribPointerType.Float, false, 2 * sizeof(float), 0);
        GL.EnableVertexAttribArray(0);
    }

    protected override void OnRenderFrame(FrameEventArgs e) {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        GL.UseProgram(shaderProgram);
        GL.BindVertexArray(vertexArrayObject);

        GL.Uniform4(GL.GetUniformLocation(shaderProgram, "uColor"), 1.0f, 1.0f, 1.0f, 1.0f);
        GL.DrawArrays(PrimitiveType.LineLoop, 0, 3);

        SwapBuffers();
    }

    protected override void OnUnload() {
        base.OnUnload();
        GL.DeleteBuffer(vertexBufferObject);
        GL.DeleteVertexArray(vertexArrayObject);
        GL.DeleteProgram(shaderProgram);
    }
}
