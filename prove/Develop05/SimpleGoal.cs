class SimpleGoal : Goal
{
    // Constructor for SimpleGoal
    public SimpleGoal(string mb_name, string mb_description, int mb_points, bool mb_isCompleted)
        : base(mb_name, mb_description, mb_points)
    {
        // Set the isCompleted field for SimpleGoal
        this._mb_isCompleted = mb_isCompleted;
    }

    // Override the List method to customize how SimpleGoal is displayed
    public override void List(int i)
    {
        if (_mb_isCompleted)
        {
            Console.WriteLine($"{i}. [X] {base.getName()} ({base.getDescription()})");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()})");
        }
    }

    // Override the SaveFile method to provide a custom string representation for saving
    public override string SaveFile()
    {
        // Return a formatted string containing information about the SimpleGoal
        return $"SimpleGoal,{base.getName()},{base.getDescription()},{base.getPoints()},{_mb_isCompleted}";
    }
}
