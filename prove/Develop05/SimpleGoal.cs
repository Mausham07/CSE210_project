class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description)
    {
        Points = points;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Goal Type: Simple");
    }
}
