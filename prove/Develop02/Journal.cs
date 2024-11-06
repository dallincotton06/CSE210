using System.IO;

public class Journal {
    string author = "";
    string name = "";
    List<Entry> entries = new List<Entry>();

    public void addEntry(Entry entry) {
        entries.Add(entry);
    }

    public void saveToFile(string fileName) {
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            foreach(Entry entry in entries) {
                outputFile.WriteLine($"{entry.date},{entry.prompt},{entry.text}");
            }
        }
    }

    public void loadFromFile(string fileName) {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines) {
            string[] parsedData = line.Split(",");
            entries.Add(new Entry(parsedData[0], parsedData[1], parsedData[2]));
        }
    }

    public List<Entry> GetEntries() {
        return entries;
    }
}