namespace Learning05;

public class Circle : Shape {
    private double radius;

    public Circle(double side, string color) : base(color) {
        this.radius = side;
    }

    public override double getArea() {
        return Math.PI * (radius * radius);
    }
}