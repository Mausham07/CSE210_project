class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description)
    {
        Points = points;
    }

    public override void MarkComplete()
    {
        // Eternal goals never complete, but they accumulate points
        Points += 100;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Goal Type: Eternal");
    }
}
