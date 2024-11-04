using System;

class Program
{
    static void Main(string[] args) {
        displayWelcome();
        displayResult(PromptUserName(), squareNumber(PromptUserNumber()));
    }

    static void displayWelcome() {
        Console.WriteLine("Welcome to the Program! ");
    }

    static String PromptUserName() {
        Console.WriteLine("What is your Name? ");
        return Console.ReadLine();
    }

    static int PromptUserNumber() {
        Console.WriteLine("What is your Favorite Number? ");
        return int.Parse(Console.ReadLine());
    }

    static int squareNumber(int number) {
        return number * number;
    }

    static void displayResult(String name, int squaredNumber) {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}