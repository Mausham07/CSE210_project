class CheckListGoal : Goal
{
    private int _mb_currentGoal;
    private int _mb_bonus;
    private int _mb_bonusPoint;
    public CheckListGoal(string mb_name, string mb_description, int mb_points, int mb_bonus, int mb_bonus_point) : base(mb_name, mb_description, mb_points)
    {
        _mb_bonus = mb_bonus;
        _mb_bonusPoint = mb_bonus_point;
    }

    public override void List(int i)
    {
        if(_mb_isCompleted){
            
            Console.WriteLine($"{i}. [X] {base.getName()} ({base.getDescription()}) -- Currently Completed: {_mb_currentGoal}/{_mb_bonus}");

            Console.WriteLine($"You have {base.getPoints()} points.");
        }

        else{
            
            Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()}) -- Currently Completed: {_mb_currentGoal}/{_mb_bonus}");
        }
    }
}
