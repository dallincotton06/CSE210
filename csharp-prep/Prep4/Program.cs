using System;

class Program
{
    static void Main(string[] args) {
        List<int> numbers = new List<int>();
        int numberToAdd;
        do {
            Console.WriteLine("Enter a Number (Enter 0 when finished): ");
            numberToAdd = int.Parse(Console.ReadLine());
            if (numberToAdd != 0) numbers.Add(numberToAdd);
        } while (numberToAdd != 0);

        Console.WriteLine("The Sum of the list is: " + numbers.Sum());
        Console.WriteLine("The Average of the list is: " + numbers.Average());
        Console.WriteLine("The Min of the list is: " + numbers.Min());
        Console.WriteLine("The Max of the list is: " + numbers.Max());

    }
}