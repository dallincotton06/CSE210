public class MathAssignment : Assignment{

    private string textbookSelection;

    private string problems;

    public MathAssignment(string studentName, string topic, string textbookSelection, string problems) : base(studentName, topic) {
        this.textbookSelection = textbookSelection;
        this.problems = problems;
    }

    public string getHomeworkList() {
        return this.textbookSelection + " - " + this.problems;
    }
}