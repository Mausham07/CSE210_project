class ChecklistGoal : Goal
{
    private int completionCount;
    private int completionTarget;

    public ChecklistGoal(string name, string description, int points, int target) : base(name, description)
    {
        Points = points;
        completionCount = 0;
        completionTarget = target;
    }

    public override void MarkComplete()
    {
        completionCount++;
        if (completionCount == completionTarget)
        {
            // Bonus points when the checklist is completed
            Points += 500;
        }
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Goal Type: Checklist");
        Console.WriteLine($"Completed {completionCount}/{completionTarget} times");
    }
}