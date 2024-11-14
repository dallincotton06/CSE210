using System.Text;

public class Obfuscator {
    private string originalText;
    private string text;

    private int obfuscatedWords = 0;
    public Obfuscator(string originalText) {
        this.originalText = originalText;
        this.text = originalText;
    }

    public string undoObfuscation() {
        this.text = this.originalText;
        return this.originalText;
    }
    public string obfuscate(int amount) {
        List<string> words = text.Split(" ").ToList();
        for (int i = 0; i < getRemainingWordsToObfuscate(amount); i++) {
            obfuscateWordFromList(words);
        }
        text = string.Join(" ", words);
        obfuscatedWords += amount;
        return text;
    }

    private int getRemainingWordsToObfuscate(int amount) {
        int totalWords = originalText.Split(" ").Count();
        if (totalWords > amount + this.obfuscatedWords) {
            return amount;
        } else {
            return totalWords - this.obfuscatedWords;
        }
    }

    private string getOriginalText() {
        return originalText;
    }


    private bool checkIfObfuscated(string word) {
        if (word.StartsWith('_')) {
            return true;
        }
        return false;
    }

    private void obfuscateWordFromList(List<String> words) {
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, words.Count);
        string word = words[randomIndex];        
        if (!checkIfObfuscated(word)) {
            words[randomIndex] = obfuscateSingleWord(word);
        } else {
            obfuscateWordFromList(words); // I hate recursion, but here is an actually useful implementation of it
        }
    }

    private string obfuscateSingleWord(string word) {
        System.Console.WriteLine(word);
        StringBuilder result = new StringBuilder();
        foreach (char c in word) {
            if (c == ',' || c == '.' || c == '!' || c == ';') { //ignore puncuation
                result.Append(c);
            }
            else {
                result.Append('_');
            }
        }
        System.Console.WriteLine(result);
        return result.ToString();
    }
}