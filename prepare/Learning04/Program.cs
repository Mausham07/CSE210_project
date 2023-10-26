using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Enter your name.");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the topic.");
        string topic = Console.ReadLine();

        Assignment assignment = new Assignment(name, topic);

        assignment.GetSummary();


    }
}