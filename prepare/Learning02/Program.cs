using System;

class Program {
    static void Main(string[] args) {
        Job[] jobs = {
            new Job("Silverwood Theme Park", "Ride lead", 2020, 2024),
            new Job("BYUI", "Studnet", 2024, 2029)
        };
        Resume resume = new Resume("Dallins Resume", jobs.ToList());
        resume.display();
    }
}