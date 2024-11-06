public class Entry {

    public string date;
    public string prompt;
    public string text;

    public Entry(string date, string prompt, string text) {
        this.date = date;
        this.prompt = prompt;
        this.text = text;
    }

    public void display() {
        System.Console.WriteLine($"{date} - {prompt} \n{text} \n");
    }
}