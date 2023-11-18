using System;

class Program
{


    static void Main(string[] args)
    {   

        List<string> mb_user_activity = new List<string> {"Simple Goal", "Eternal Goal", "Checklist Goal"};

        bool mb_is_on = true;
        int mb_points = 0;
        List<Goal> goals = new List<Goal>();
        while(mb_is_on)
        {
             // Console.Clear();
            Console.WriteLine($"You have {mb_points} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goal");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            Console.Write("Select a choice from the menu: ");
            int mb_choice = Int32.Parse(Console.ReadLine());
            
            if (mb_choice == 1){
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. CheckList Goal");

                Console.Write("Which type of goal would you like to create? ");
                int mb_user_goal = Int32.Parse(Console.ReadLine());

                if (mb_user_goal == 1){
                    Console.Write("What is the name of your goal? ");
                    string mb_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string mb_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int mb_point = Int32.Parse(Console.ReadLine());

                    SimpleGoal goal = new SimpleGoal(mb_name, mb_description, mb_point,false);
                    goals.Add(goal);
                }
                else if (mb_user_goal == 2){
                    Console.Write("What is the name of your goal? ");
                    string mb_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string mb_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int mb_point = Int32.Parse(Console.ReadLine());

                    EternalGoal goal = new EternalGoal(mb_name, mb_description, mb_point);
                    goals.Add(goal);
                }
                else if (mb_user_goal == 3){
                    Console.Write("What is the name of your goal? ");
                    string mb_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string mb_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int mb_point = Int32.Parse(Console.ReadLine());

                    Console.Write("How many times the goal need to be accomplished for a bonus? ");
                    int mb_bonus = Int32.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int mb_bonus_point = Int32.Parse(Console.ReadLine());

                    CheckListGoal goal = new CheckListGoal(mb_name, mb_description, mb_point, mb_bonus, mb_bonus_point);
                    goals.Add(goal);
                }
            }

            else if (mb_choice == 2){
                Console.WriteLine("The goals are: ");
                int count = 1;
                foreach(Goal g in goals){
                    g.List(count);
                    count += 1;
                }
            }


            else if(mb_choice == 6){
                mb_is_on = false;
            }
        }

        
    } 

}