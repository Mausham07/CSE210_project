using System;

class Program
{


    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        SimpleGoal marathonGoal = new SimpleGoal("Run a Marathon", "Complete a full marathon", 1000);
        EternalGoal scripturesGoal = new EternalGoal("Read Scriptures", "Read scriptures daily", 100);
        ChecklistGoal templeGoal = new ChecklistGoal("Attend Temple", "Visit the temple", 50, 10);

        goals.Add(marathonGoal);
        goals.Add(scripturesGoal);
        goals.Add(templeGoal);

        Console.WriteLine("Welcome to the Eternal Quest program!");

        // Mark goals as completed (simulated)
        scripturesGoal.MarkComplete();
        templeGoal.MarkComplete();
        templeGoal.MarkComplete();


        Console.ReadLine();
        
    } 

}