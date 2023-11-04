using System;
using System.Diagnostics;

class Listing : Activity{
    private List<string> _mb_questions;
    private List<string> _mb_userResponse;
    public Listing() : base(){
        _mb_questions = new List<string>();
        _mb_userResponse = new List<string>();
    }

    public Listing(string mb_name, string mb_description): base(mb_name, mb_description){
        _mb_questions = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
         _mb_userResponse = new List<string>();
    }

    public void listStartActivity(){
        base.startActivity();

        Console.WriteLine("List as many responses you can to the following prompt:\n");

        displayPrompt();
        

    }

    public void listEndActivity(){
        base.EndActivity();
    }


    public void displayPrompt(){

        Random rnd = new Random();
        int mb_rand_question_index = rnd.Next(_mb_questions.Count-1);
        string mb_rand_question = _mb_questions[mb_rand_question_index];

        Console.WriteLine(" ---"+mb_rand_question+"---\n");

        Console.Write("You may beign in 5 seconds.\n");
        base.ShowLoadingAnimation();

        int time = base.getDuration();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine($"Begin:");

        while (stopwatch.Elapsed.Seconds < time) {
            if (Console.KeyAvailable) {
                string mb_userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(mb_userInput)){
                    _mb_userResponse.Add(mb_userInput);
                }
            }
            // Give a small delay to prevent the loop from consuming too much CPU
            Thread.Sleep(100); // 100ms delay
        }
        Console.Write($"\nYou listed {_mb_userResponse.Count} items!\n");

        
    }
}