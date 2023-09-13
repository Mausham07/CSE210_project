using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade: ");
        string grades = Console.ReadLine();
        int grade = int.Parse(grades);

        string letter = ""; // Initialize the variable with an empty string

        if (grade >= 90)
        {
            letter = "A"; 
        }
        else if (grade >= 80)
        {
            letter = "B"; 
        }
        else if (grade >= 70)
        {
            letter = "C"; 
        }
        else if (grade >= 60)
        {
            letter = "D"; 
        }
        else 
        {
            letter = "F"; 
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congrats, you passed.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. Try hard next time.");
        }
    }
}