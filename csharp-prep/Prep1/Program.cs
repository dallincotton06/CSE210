using System;
class Program {
    static void Main(string[] args) {
        string firstname = prompt("What is your first name? ");
        string lastname = prompt("What is your last name? ");

        Console.WriteLine("Your name is " + lastname + ", " + firstname + " " + lastname);
    }

    static string prompt(string promptText) {
        Console.WriteLine(promptText);
        return Console.ReadLine();
    }

}