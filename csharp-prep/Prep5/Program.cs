using System;

class Program
{
    static void DisplayProgram(){
            Console.WriteLine("Welcome to the program!");
        }
    static string GetName(){
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
    static int GetNumber(){
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
    
    static int SquareNum(int number){
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square){
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
    static void Main(string[] args)
    {
       DisplayProgram();
       string name = GetName();
       int number = GetNumber();
       int square = SquareNum(number);
       DisplayResult(name, square);

    }
}