using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int computer_number = rand.Next(1,100); // Generate the random number

        bool flag = true; // Initialize the 'flag' variable to use in  while

        int num_of_guesses = 0;
        while(flag){
            Console.Write("What is the your guess?: ");
            int response = int.Parse(Console.ReadLine());

            if (response == computer_number){
                num_of_guesses += 1;
                Console.WriteLine("You Guessed it.");
                Console.WriteLine($"The number of guesses you made is {num_of_guesses}.");
                flag = false;
            }
            else if(response > computer_number){
                num_of_guesses += 1;
                Console.WriteLine("Higher");
            }
            else if(response < computer_number){
                num_of_guesses +=1;
                Console.WriteLine("Lower");
            }
        }
    }
}