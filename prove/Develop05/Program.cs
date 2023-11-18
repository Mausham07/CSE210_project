using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize variables and objects
        bool mb_is_on = true;
        int mb_total_points = 0;
        List<Goal> goals = new List<Goal>();
        Save save = new Save();
        Load load = new Load();

        while (mb_is_on)
        {
            // Display menu options
            Console.WriteLine($"\nYou have {mb_total_points} points.\n");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goal");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");

            // User input for menu choice
            Console.Write("Select a choice from the menu: ");
            int mb_choice = Int32.Parse(Console.ReadLine());

            if (mb_choice == 1)
            {
                // Create a new goal based on user input
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. CheckList Goal");

                Console.Write("Which type of goal would you like to create? ");
                int mb_user_goal = Int32.Parse(Console.ReadLine());

                if (mb_user_goal == 1)
                {
                    // Create a SimpleGoal
                    Console.Write("What is the name of your goal? ");
                    string mb_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string mb_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int mb_point = Int32.Parse(Console.ReadLine());

                    SimpleGoal goal = new SimpleGoal(mb_name, mb_description, mb_point, false);
                    goals.Add(goal);
                }
                else if (mb_user_goal == 2)
                {
                    // Create an EternalGoal
                    Console.Write("What is the name of your goal? ");
                    string mb_name = Console.ReadLine();

                    Console.Write("What is the short description of it? ");
                    string mb_description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this goal? ");
                    int mb_point = Int32.Parse(Console.ReadLine());

                    EternalGoal goal = new EternalGoal(mb_name, mb_description, mb_point);
                    goals.Add(goal);
                }
                else if (mb_user_goal == 3)
                {
                    // Create a CheckListGoal
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
            else if (mb_choice == 2)
            {
                // Display the list of goals
                Console.WriteLine("The goals are: ");
                int count = 1;
                foreach (Goal g in goals)
                {
                    g.List(count);
                    count += 1;
                }
            }
            else if (mb_choice == 3)
            {
                // Save goals to a file
                save.SaveToFile(goals);
            }
            else if (mb_choice == 4)
            {
                // Load goals from a file
                load.LoadFromFile(goals);
            }
            else if (mb_choice == 5)
            {
                // Record an event and update points
                Console.WriteLine("The goals are: ");
                int count = 1;
                foreach (Goal g in goals)
                {
                    g.List(count);
                    count += 1;
                }

                Console.Write("Which goal did you accomplish? ");
                string mb_goal_choice = Console.ReadLine();
                mb_total_points += goals[int.Parse(mb_goal_choice) - 1].Complete();
                Console.WriteLine($"Congratulations. You now have {mb_total_points} points.");
            }
            else if (mb_choice == 6)
            {
                // Ask for confirmation before quitting
                Console.WriteLine("Do you want us to remind you for a task? (Yes/No)");
                string mb_remind = Console.ReadLine().ToLower();
                if (mb_remind == "no")
                {
                    Console.WriteLine("Thank You. See you again!");
                }
                else
                {
                    Console.WriteLine("When do you want us to remind? (DD/MM)");
                    string mb_time = Console.ReadLine();
                    Console.WriteLine($"Thank you. We will remind you on {mb_time}. Have a great time.");
                }
                mb_is_on = false; // Exit the loop and end the program
            }
        }
    }
}
