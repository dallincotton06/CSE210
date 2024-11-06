public class Prompts {

    List<string> prompts = new string[] {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    }.ToList();

    public string getRandomPrompt() {
        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Count());
        return prompts.OrderBy(x => rand.Next()).ElementAt(randomIndex);    
    }

    public void displayToConsole() {

    }
}