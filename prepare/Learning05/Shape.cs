using System.Drawing;

namespace Learning05;

public class Shape {
    private string color;

    public Shape(string color) {
        this.color = color;
    }

    public virtual double getArea() {
        return 0;
    }

    public string getColor() {
        return color;
    }

    public void setColor(string color) {
        this.color = color;
    }
}