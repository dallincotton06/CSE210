using System;

class Program {
    static void Main(string[] args) {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(2, 3);

        System.Console.WriteLine(fraction1.getFractionDecimal());
        System.Console.WriteLine(fraction1.getFractionString());

        System.Console.WriteLine(fraction2.getFractionDecimal());
        System.Console.WriteLine(fraction2.getFractionString());

        System.Console.WriteLine(fraction3.getFractionDecimal());
        System.Console.WriteLine(fraction3.getFractionString());
    }
}