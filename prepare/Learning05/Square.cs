namespace Learning05;

public class Square : Shape {
    private double side;

    public Square(double side, string color) : base(color) {
        this.side = side;
    }

    public override double getArea() {
        return side * side;
    }
}