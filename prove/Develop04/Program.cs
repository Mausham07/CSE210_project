using System;

class Program
{
    static void Main(string[] args)
    {   
        List<string> mb_user_activity = new List<string> {"Breathing", "Reflecting", "Listing", "Quit"};
        List<string> mb_user_description = new List<string> {"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                                            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                                            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                                            "Quit"};

        List<int> mb_log = new List<int>{0,0,0};

        bool mb_program_on = true;

        while(mb_program_on){
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit\n");

            Console.Write("Select a choice from the menu: ");
            int mb_choice = Int32.Parse(Console.ReadLine());

            string mb_chosen_activity = mb_user_activity[mb_choice-1];
            string mb_chosen_description = mb_user_description[mb_choice -1];
            // Activity activity = new Activity(mb_chosen_activity, mb_chosen_description);
            if (mb_choice == 1){
                Breathing breath = new Breathing(mb_chosen_activity, mb_chosen_description);
                breath.breathStartActivity();
                breath.breathEndActivity();
                mb_log[mb_choice-1] += 1;
            }
            else if (mb_choice == 2){
                Reflecting reflect = new Reflecting(mb_chosen_activity, mb_chosen_description);
                reflect.reflectStartActivity();
                reflect.displayQuestion();
                reflect.reflectEndActivity();
                mb_log[mb_choice-1] += 1;
            }
            else if (mb_choice == 3){
                Listing reflect = new Listing(mb_chosen_activity, mb_chosen_description);
                reflect.listStartActivity();
                reflect.listEndActivity();
                mb_log[mb_choice-1] += 1;
            }

            else if (mb_choice == 4){
                Console.WriteLine("\nActivity Log:");
                for(int i =0; i < 3; i++){
                    Console.WriteLine($"{mb_user_activity[i]}: Performed {mb_log[i]} time(s)");
                }
                mb_program_on = false;
            }
            else {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }
            
    }
}