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

    public void startActivity(){

        base.startActivity();
        string mb_prompt = base.getPrompt();
        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine("  ---"+mb_prompt+"---");

        Random rnd = new Random();
        int index = rnd.Next(_mb_reflect.Count-1);
        string mb_randomPrompt = _mb_reflect[index];

        Console.WriteLine(mb_randomPrompt);



    }
}