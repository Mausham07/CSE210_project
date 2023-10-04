using System;

class Program
{
    static void Main(string[] args)
    {
        Prompt promptGenerator = new Prompt();
        Journal journal = new Journal("Mausham Bista");

        promptGenerator._mb_prompt.Add("What is your favorite memory?");
        promptGenerator._mb_prompt.Add("Describe a place you visited.");
        promptGenerator._mb_prompt.Add("Who was the most interesting person you interacted with today");
        promptGenerator._mb_prompt.Add("What was the strongest emotion you felt?");
        promptGenerator._mb_prompt.Add("If you had one thing you could do over today, what would it be?");

        while (true){
            Console.WriteLine("\n Journal Program Menu");
            Console.WriteLine("1. Write a new Journal entry");
            Console.WriteLine("2. Generate a journal prompt");
            Console.WriteLine("3. Display all entries");
            Console.WriteLine("4. Save entries to a file");
            Console.WriteLine("5. Load entries from a file");
            Console.WriteLine("6. Exit");

            Console.Write("Select an option (1-6: )");
            string _mb_choice = Console.ReadLine();

            

            switch (_mb_choice)
            {
                case "1":

                    Console.Write("Enter the location: ");
                    string mb_location = Console.ReadLine();

                    string mb_generatedPrompt = promptGenerator.GeneratePrompt();

                    Console.WriteLine(mb_generatedPrompt);

                    Console.Write("Enter your response: ");
                    string mb_response = Console.ReadLine();

                    journal.AddEntry(DateTime.Now, mb_generatedPrompt, mb_location, mb_response);
                    Console.WriteLine("Journal entry added successfully.");
                    break;

                case "2":
                    string mb_generatedPrompts = promptGenerator.GeneratePrompt();
                    Console.WriteLine($"Journal Prompt: {mb_generatedPrompts}");
                    break;
                case "3":
                    Console.WriteLine($"Journal entries for {journal.GetUserName()}:");
                    journal.Display();
                    break;
                case "4":
                    journal.SaveToFile();
                    Console.WriteLine("Journal entries saved to file.");
                    break;
                case "5":
                    journal.LoadFromFile();
                    Console.WriteLine("Journal entries loaded from file.");
                    break;
                case "6":
                    Console.WriteLine("Exiting the journal program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }

        }
    }
}