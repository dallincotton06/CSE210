namespace Learning05;

public class Rectangle : Shape {
    private double width;
    private double height;

    public Rectangle(double width, double height, string color) : base(color) {
        this.width = width;
        this.height = height;
    }

    public override double getArea() {
        return width * height;
    }
}