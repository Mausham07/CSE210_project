class CheckListGoal : Goal
{
    // Fields specific to CheckListGoal
    private int _mb_currentGoal;
    private int _mb_bonus;
    private int _mb_bonusPoint;

    // Constructor
    public CheckListGoal(string mb_name, string mb_description, int mb_points, int mb_bonus, int mb_bonus_point) : base(mb_name, mb_description, mb_points)
    {
        // Initialize fields specific to CheckListGoal
        _mb_bonus = mb_bonus;
        _mb_bonusPoint = mb_bonus_point;
    }

    // Override List method
    public override void List(int i)
    {
        if (_mb_isCompleted)
        {
            Console.WriteLine($"{i}. [X] {base.getName()} ({base.getDescription()}) -- Currently Completed: {_mb_currentGoal}/{_mb_bonus}");
        }
        else
        {
            Console.WriteLine($"{i}. [ ] {base.getName()} ({base.getDescription()}) -- Currently Completed: {_mb_currentGoal}/{_mb_bonus}");
        }
    }

    // Override Complete method
    public override int Complete()
    {
        if (_mb_isCompleted == false)
        {
            _mb_currentGoal += 1;
            if (_mb_currentGoal == _mb_bonus)
            {
                _mb_isCompleted = true;
                return base.getPoints() + _mb_bonusPoint;
            }
            else
            {
                return base.getPoints();
            }
        }
        else
        {
            return 0;
        }
    }

    // Override SaveFile method
    public override string SaveFile()
    {
        return $"CheckListGoal,{base.getName()},{base.getDescription()},{base.getPoints()},{_mb_isCompleted}, {_mb_currentGoal}, {_mb_bonusPoint}, {_mb_bonus}";
    }
}
