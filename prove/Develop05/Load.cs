class Load{

    public Load(){

    }

    public void LoadFromFile(List<Goal> goals){
        Console.WriteLine("What is the filename of the goal? ");
        string mb_file = Console.ReadLine();

        using (StreamReader sr = new StreamReader(mb_file)){
            string line;
            while((line =sr.ReadLine()) != null){
                string[]parts = line.Split(',');

                if (parts.Length == 8)
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isCompleted = bool.Parse(parts[4]);
                    int currentGoal = int.Parse(parts[5]);
                    int bonusPoints = int.Parse(parts[6]);
                    int bonus = int.Parse(parts[7]);
                    
                    CheckListGoal goal = new CheckListGoal(name, description, points, bonus, bonusPoints);
                    
                    goals.Add(goal);
                    }
                else if (parts.Length == 5)
                {
                   
                    if (parts[0]=="SimpleGoal"){
                        string simple_name = parts[1];
                        string simple_description = parts[2];
                        int simple_points = int.Parse(parts[3]);
                        bool simple_isCompleted = bool.Parse(parts[4]);

                    SimpleGoal simple_goal = new SimpleGoal(simple_name, simple_description, simple_points, simple_isCompleted);
                        
                    goals.Add(simple_goal);
                    }
                    else{
                        string eternal_name = parts[1];
                        string eternal_description = parts[2];
                        int eternal_points = int.Parse(parts[3]);
                        

                    EternalGoal eternal_goal = new EternalGoal(eternal_name, eternal_description, eternal_points);
                        
                    goals.Add(eternal_goal);
                    }
                    
            }
        }
    }
}
}