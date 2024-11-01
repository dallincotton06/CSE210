using System;

class Program {

    static int magicNUmber = 0;
    static void Main(string[] args) {
        magicNUmber = new Random().Next(1, 100);
        loopUntilComplete();
    }

    static Boolean respond(int guess) {
        if (guess == magicNUmber) {
            Console.WriteLine("Correct! You guessed the right number!");
            return false;
        } else if (guess > magicNUmber) {
            Console.WriteLine("Nope! Too High!");
            return true;
        } else  {
            Console.WriteLine("Nope! Too Low!");
            return true;
        }
    }

    static void loopUntilComplete() {
        int guess;
        do {
            Console.WriteLine("What is your Guess? ");
            guess = int.Parse(Console.ReadLine());
        } while (respond(guess));
    }
}