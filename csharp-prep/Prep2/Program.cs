using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade: ");
        string grades = Console.ReadLine();
        int grade = int.Parse(grades);

        // if (grade >= 90)
        // {
        //     Console.WriteLine("You got an A");
        // }
        // else if (grade >= 80)
        // {
        //     Console.WriteLine("You got a B");
        // }
        // else if (grade >= 70)
        // {
        //     Console.WriteLine("You got a C");
        // }
        // else if (grade >= 60)
        // {
        //     Console.WriteLine("You got a D");
        // }
        // else 
        // {
        //     Console.WriteLine("You Failed.");
        // }

        if (grade>=70)
        {
            Console.WriteLine("Congrats you passed.");
        }
        else{
            Console.WriteLine("Sorry, you failed.");
        }
    }
}