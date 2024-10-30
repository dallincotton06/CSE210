using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("What Percent did you get in the class? ");
        string grade = calculateGrade(int.Parse(Console.ReadLine()));
        Console.WriteLine("You recieved the grade, " + grade + "!");
    }

    static string calculateGrade(int percent) {
        string letter;
        if (percent >= 90) {
            letter = "A";
        } else if (percent >= 80) {
            letter = "B";
        } else if (percent >= 70) {
            letter = "C";
        } else if (percent >= 60) {
            letter = "D";
        } else {
            letter = "F";
        } 

        return letter + getSign(percent);
    }

    static string getSign(int percent) {
        if (percent % 10 >= 7) {
            return "+";
        } else if (percent % 10 < 3) {
            return "-";
        }
        return "";
    }
}