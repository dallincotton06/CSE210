public class Streak {
    int days = 0;
    long timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
    

    public void save() {
        using (StreamWriter outputFile = new StreamWriter("Streak.txt")) {
            outputFile.Flush();
            outputFile.WriteLine(days);
            outputFile.WriteLine(timestamp);
        }
    }

    public void load() {
         if (!File.Exists("Streak.txt")) {
            using (StreamWriter outputFile = new StreamWriter("Streak.txt")) {
                outputFile.WriteLine(days);
                outputFile.WriteLine(timestamp);
            }
        }
        days = int.Parse(System.IO.File.ReadAllLines("Streak.txt")[0]);
        timestamp = long.Parse(System.IO.File.ReadAllLines("Streak.txt")[1]);
    }

    public int getDays() {
        return days;
    }

    public long getTimestamp() {
        return timestamp;
    }

    public void incrementStreak() {
        days++;
    }

    public void resetStreak() {
        days = 0;
    }
}