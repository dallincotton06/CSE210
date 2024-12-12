using FinalProject.Shape;
using FinalProject.Triangulator;

namespace FinalProject.Benchmark;

public class TriangulatorBenchmark {
    
    private TriangulatorBatch batch;

    public TriangulatorBenchmark() {
        batch = new TriangulatorBatch();
        batch.add(new Polygon(new float[] {
            0.75f, -0.3f,       // Vertex 1 (right)
            0.425f, -0.083f,    // Vertex 2 (top-right)
            0.175f, -0.083f,    // Vertex 3 (top-left)
            0.05f, -0.3f,       // Vertex 4 (left)
            0.175f, -0.517f,    // Vertex 5 (bottom-left)
            0.425f, -0.517f     // Vertex 6 (bottom-right)
        }.ToList()));
        
        batch.add(new Polygon(new float[] {
            0.85f, -0.41f,       // Vertex 1 (right)
            0.535f, -0.183f,    // Vertex 2 (top-right)
            0.275f, -0.183f,    // Vertex 3 (top-left)
            0.15f, -0.4f,       // Vertex 4 (left)
            0.275f, -0.617f,    // Vertex 5 (bottom-left)
            0.525f, -0.627f     // Vertex 6 (bottom-right)
        }.ToList()));
        
        batch.compileAll();
    }

    public void run() {
        batch.computeTrianglesForAll();
    }
}