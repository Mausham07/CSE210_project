using System;



class Reflecting:Activity{
    private List<string> _mb_reflect;

    public Reflecting(): base(){
        _mb_reflect = new List<string>();
    }
    public Reflecting(string mb_name, string mb_description) : base(mb_name, mb_description){
        _mb_reflect = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public void reflectStartActivity(){

        base.startActivity();
        string mb_prompt = base.getPrompt();
        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine("  ---"+mb_prompt+"---");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        ConsoleKeyInfo keyInfo;
        do{
            keyInfo = Console.ReadKey(true);
            if(keyInfo.Key == ConsoleKey.Enter){
                break;
            }
        } while (true);

        Console.WriteLine("Now ponder on each of the following questions as they related to the experience.");
        Console.Write("You may beign in 5 seconds.");
        Thread.Sleep(5000);
        


    }

    public void displayQuestion(){
        Console.Clear();


        int mb_time = base.getDuration();
        while(mb_time > 0){

            int mb_questionTime = Math.Min(10, mb_time);

            Random rnd = new Random();
            int index = rnd.Next(_mb_reflect.Count-1);
            string mb_randomPrompt = _mb_reflect[index];

            Console.WriteLine(mb_randomPrompt);
           
            // Adding a "Loading" animation using periods (dots)
            for (int i = 0; i < mb_questionTime; i++)  // Displaying 5 dots
            {
                Console.Write(".");
                Thread.Sleep(1000);  // Pauses for 1000 milliseconds
            }
            Console.Write("\n");  // Move to the next line
    

            mb_time -= mb_questionTime;
        }

        
    }

    public void reflectEndActivity(){
        base.EndActivity();
    }
}