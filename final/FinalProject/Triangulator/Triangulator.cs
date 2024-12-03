using FinalProject.Shape;

namespace FinalProject.Triangulator;

public abstract class Triangulator {
    private Polygon polygon;

    public abstract List<Triangle> computeTriangles();
}