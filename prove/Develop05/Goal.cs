class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public Goal(string name, string description)
    {
        Name = name;
        Description = description;
        Points = 0;
        IsCompleted = false;
    }

    public virtual void MarkComplete()
    {
        IsCompleted = true;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Goal: {Name}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Points: {Points}");
        Console.WriteLine($"Completed: {(IsCompleted ? "Yes" : "No")}");
    }
}