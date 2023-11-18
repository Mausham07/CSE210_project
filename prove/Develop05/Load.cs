class Load
{
    // Constructor
    public Load()
    {
        // No specific initialization logic in the constructor
    }

    // Method to load goals from a file
    public void LoadFromFile(List<Goal> goals)
    {
        Console.WriteLine("What is the filename of the goal? ");
        string mb_file = Console.ReadLine();

        // Using statement ensures that the StreamReader is properly disposed of when done
        using (StreamReader sr = new StreamReader(mb_file))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                // Split the line into parts using comma as the delimiter
                string[] parts = line.Split(',');

                // Check the length of the parts array to determine the type of goal
                if (parts.Length == 8)
                {
                    // If there are 8 parts, it's a CheckListGoal
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isCompleted = bool.Parse(parts[4]);
                    int currentGoal = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);

                    // Create a new CheckListGoal and add it to the list of goals
                    CheckListGoal goal = new CheckListGoal(name, description, points, bonus, bonusPoints);
                    goals.Add(goal);
                }
                else if (parts.Length == 5)
                {
                    // If there are 5 parts, it's either a SimpleGoal or an EternalGoal
                    if (parts[0] == "SimpleGoal")
                    {
                        // It's a SimpleGoal
                        string simple_name = parts[1];
                        string simple_description = parts[2];
                        int simple_points = int.Parse(parts[3]);
                        bool simple_isCompleted = bool.Parse(parts[4]);

                        // Create a new SimpleGoal and add it to the list of goals
                        SimpleGoal simple_goal = new SimpleGoal(simple_name, simple_description, simple_points, simple_isCompleted);
                        goals.Add(simple_goal);
                    }
                    else
                    {
                        // It's an EternalGoal
                        string eternal_name = parts[1];
                        string eternal_description = parts[2];
                        int eternal_points = int.Parse(parts[3]);

                        // Create a new EternalGoal and add it to the list of goals
                        EternalGoal eternal_goal = new EternalGoal(eternal_name, eternal_description, eternal_points);
                        goals.Add(eternal_goal);
                    }
                }
            }
        }
    }
}
