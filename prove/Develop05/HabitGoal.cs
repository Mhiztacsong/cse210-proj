public class HabitGoal : Goal
{
    private int _daysCompleted;
    private int _targetDays;
    private int _bonus;

    public HabitGoal(string name, string description, int points, int bonus) : base(name, description, points)
    {
        _daysCompleted = 0;
        _targetDays = 30;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _daysCompleted++;
        if (_daysCompleted >= _targetDays)
        {
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _daysCompleted >= _targetDays;
    }

    public override string GetDetailsString()
    {
        string status;
        if (IsComplete())
        {
            status = "[X]";
        }
        else
        {
            status = "[ ]";
        }
        return $"{status} {base.GetShortName()} - {base.GetDescription()}: {base.GetPoints()} points each time, {_bonus} bonus point after {_targetDays} completions (Completed {_daysCompleted}/{_targetDays})";
    }

    public override string GetStringRepresentation()
    {
        return $"HabitGoal|{base.GetShortName()}|{base.GetDescription()}|{base.GetPoints()}|{_daysCompleted}|{_targetDays}|{_bonus}";
    }
}
 