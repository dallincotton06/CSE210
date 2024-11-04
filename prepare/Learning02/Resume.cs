class Resume {
    private string name;
    private List<Job> jobs;


    public Resume(string name, List<Job> jobs) {
        this.name = name;
        this.jobs = jobs;
    }
    public void display() {
        Console.WriteLine($"Name: {name}");
        foreach (Job job in jobs) {
            job.display();
        }
    }
}