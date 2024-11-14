public class Scripture {
    
    private List<Verse> verses;
    private string referecne;

    public Scripture(List<Verse> verses, string referecne) {
        this.verses = verses;
        this.referecne = referecne;
    }

    public List<Verse> getVerses() {
        return this.verses;
    }

    public string getReference() {
        return this.referecne;
    }

    public string getText() {
        string builtText = "";
        foreach (Verse verse in verses) {
            builtText = builtText + verse.getNumber() + " " + verse.getText();
        }

        return builtText;
    }
}