using System;
using Learning05;

class Program {
    static void Main(string[] args) {
        List<Shape> shapes = new();
        shapes.Add(new Circle(3, "red"));
        shapes.Add(new Circle(33, "green"));
        shapes.Add(new Rectangle(34, 11, "blue"));
        shapes.Add(new Rectangle(9, 12, "yellow"));
        shapes.Add(new Rectangle(2, 2, "green"));
        shapes.Add(new Square(2, "blue"));
        shapes.Add(new Square(34, "yellow"));
        shapes.Add(new Square(2, "green"));

        foreach (Shape shape in shapes) {
            Console.WriteLine("[Color]: " + shape.getColor());
            Console.WriteLine("[Area]: " + shape.getArea());
        }
    }
}