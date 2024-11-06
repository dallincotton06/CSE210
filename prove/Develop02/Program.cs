using System;

class Program {

    static Journal currentJournal = new Journal();
    static void Main(string[] args) {
        System.Console.WriteLine("Welomce to the Journal Program!");
        while (true) {
            selectOption();
        }
    }

    static void displayOptions() {
        System.Console.WriteLine("Please select one of the following choices: ");
        System.Console.WriteLine(" 1. Write \n 2. Display \n 3. Save \n 4. Load \n 5. Quit");
        System.Console.WriteLine("What would you like to do? ");

    }

    static void selectOption() {
        displayOptions();
        string option = Console.ReadLine();
        if (option == "1") {
            string prompt = new Prompts().getRandomPrompt();
            System.Console.WriteLine(prompt);
            currentJournal.addEntry(new Entry(DateTime.Now.ToShortDateString(), prompt, Console.ReadLine()));
        } else if(option == "2") {
            foreach (Entry entry in currentJournal.GetEntries()) {
                entry.display();
            }
        } else if(option == "3") {
            System.Console.WriteLine("Enter the name of the file to save to: ");
            currentJournal.saveToFile(Console.ReadLine());
        } else if(option == "4") {
            System.Console.WriteLine("Enter the name of the file to load from: ");
            currentJournal.loadFromFile(Console.ReadLine());
        } else if(option == "5") {
            Streak streak = new Streak();
            streak.load();
            if (streak.getTimestamp() < DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 172800 ) { // if more than 48 hours has passed
                streak.resetStreak();
                System.Console.WriteLine("Oh no! Your streak has reset because you forgot to do it yesterday!");
                streak.save();
            } else if (streak.getTimestamp() < DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 82800) { // if 23 hours has passed, to give an extra hour of leeway
                streak.incrementStreak();
                System.Console.WriteLine($"Congrats! Your streak has increased to: {streak.getDays()}");
                streak.save();
            } else {
                System.Console.WriteLine($"You've already journaled today! Your streak has remained the same!");
            }
            System.Console.WriteLine("Thanks for writing today!");
            Environment.Exit(0);

        } else {
            System.Console.WriteLine("That is not a valid option, please select a number 1-5. ");
        }
    }
}