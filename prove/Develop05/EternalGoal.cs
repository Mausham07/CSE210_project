class EternalGoal : Goal
{
    public  EternalGoal(string mb_name, string mb_description, int mb_points) : base(mb_name, mb_description, mb_points)
    {
        
    }
    public override void List(int i)
    { 
        
        Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()})");
        
    }
    
}
