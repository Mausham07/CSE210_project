class SimpleGoal : Goal
{
    public SimpleGoal(string mb_name, string mb_description, int mb_points, bool mb_isCompleted) : base(mb_name, mb_description, mb_points)
    {
        this._mb_isCompleted = mb_isCompleted;
    }

    public override void List(int i)
    {
        if(_mb_isCompleted){
            
            Console.WriteLine($"{i}. [X] {base.getName()} ({base.getDescription()})");

            Console.WriteLine($"You have {base.getPoints()} points.");
        }

        else{
            
            Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()})");
        }
    }

}
