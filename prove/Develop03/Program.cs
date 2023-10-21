using System;
using System.Diagnostics.CodeAnalysis;

class Program {
    static void Main(string[] args) {
        Console.Clear(); // Clear the console screen to start with a clean display.

        // Create an instance of the Reference class to obtain scripture text and reference.
        Reference reference = new Reference();
        string mb_text = reference.getText(); // Get the scripture text from the user.
        string mb_reference = reference.getReference(); // Get the scripture reference from the user.

        // Create an instance of the Scripture class with the obtained text and reference.
        Scripture scripture = new Scripture(mb_text, mb_reference);

        // Continue displaying and manipulating the scripture until all words are hidden.
        while (!scripture.AreAllWordsHidden()) {
            Console.Clear(); // Clear the console for a clean display on each iteration.
            Console.WriteLine(scripture.ToString()); // Display the current state of the scripture.
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine(); // Read user input.

            if (input == "quit") {
                break; // If the user types 'quit', exit the loop and end the program.
            }

            scripture.HideRandomWord(); // Hide a random word in the scripture.
        }


        // Requirement exceeds from here
        Console.WriteLine("Do you want to set reminders for daily scripture practice? (Yes/No)");
        string mb_remind = Console.ReadLine();
        if (mb_remind.ToLower() == "yes"){
            Console.WriteLine("When do you want me to remind you? (For ex. Oct 1/ Oct 2) ");
            string mb_date = Console.ReadLine();
            Console.WriteLine($"I will remind you at {mb_date}.");
        }
        else{
            Console.WriteLine("Thank you see you again!!");
        }
    }
}
