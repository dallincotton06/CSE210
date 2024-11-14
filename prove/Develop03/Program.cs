using System;

class Program {

    private static Scripture selectedScripture = new Scripture(new Verse[]{new Verse(12, "And now, my sons, remember, " + 
    "remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build " +
    "your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind" +
    ", yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to " +
    "drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is " +
    "a sure foundation, a foundation whereon if men build they cannot fall.")}.ToList(), "Helaman 5:12");
    private static Obfuscator obfuscator = new Obfuscator(selectedScripture.getText());
    static void Main(string[] args) {
        Console.WriteLine("Welcome to the Scripture Memorizing Program!");
        while (true) {
            getUserInput();

        }
    }


    private static void clearAndDisplay(string text) {
        Console.Clear();
        System.Console.WriteLine(selectedScripture.getReference() + "\n");
        System.Console.WriteLine(text);
    }

    private static void getUserInput() {
        System.Console.WriteLine("Press Enter to continue, 'restart' to restart, or 'quit' to stop. ");
        string response = Console.ReadLine();
        if (response == "") { // if enter is pressed without input
            clearAndDisplay(obfuscator.obfuscate(5));
        } else if (response == "restart") {
            clearAndDisplay(obfuscator.undoObfuscation());
        } else if (response == "quit") {
            Environment.Exit(0);
        } else {
            System.Console.WriteLine("Error: That is an invlid response");
        }
    }
}