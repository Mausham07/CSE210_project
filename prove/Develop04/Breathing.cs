using System;
using System.Threading;

class Breathing : Activity {

    public Breathing(string mb_name, string mb_description) : base(mb_name, mb_description)
    {

    }
    public void startActivity(){
        base.startActivity();

        Random rnd = new Random();
        int mb_totalTime = getDuration() * 1000;
        while(mb_totalTime > 0){
            int mb_breathIn = 4000;
            int mb_breathOut = 6000;

            if (mb_totalTime >= (mb_breathIn + mb_breathOut))
            {
                // Breathe in
                mb_totalTime -= mb_breathIn;
                Console.Write("\nBreathe in...");
                CountDown(mb_breathIn);

                // Breathe out
                mb_totalTime -= mb_breathOut;
                Console.Write("\nBreathe out...");
                CountDown(mb_breathOut);
            }
            else{
                int mb_new_time = mb_totalTime / 2;
                Console.Write("\nBreathe in...");
                CountDown(mb_breathIn);

                Console.Write("\nBreathe out...");
                CountDown(mb_breathOut);
                mb_totalTime = 0;
               }
        }
        
    }

    public void EndActivity(){
        base.EndActivity();
    }
    public void CountDown(int time){
        for (int i = time; i >= 0; i -= 1000){
            Console.Write($"{i/1000}  ");
            Thread.Sleep(1000);
        }
    }

}