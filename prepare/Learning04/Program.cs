using System;

class Program {
    static void Main(string[] args) {
        WritingAssignment writingAssignment = new WritingAssignment("Dallin", "Research", "Probability and Statistics in Science");
        System.Console.WriteLine(writingAssignment.getSummary());
        System.Console.WriteLine(writingAssignment.getWritingInformation());
    }
}