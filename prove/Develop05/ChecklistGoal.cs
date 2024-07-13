using System.ComponentModel;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    
    public override int RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted >= _target)
        {
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;

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
        return $"{status} {base.GetShortName()} - {base.GetDescription()}: {base.GetPoints()} points each time, {_bonus} bonus point after {_target} completions (Completed {_amountCompleted}/{_target})";
    }


    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{base.GetShortName()}|{base.GetDescription()}|{base.GetPoints()}|{_amountCompleted}|{_target}|{_bonus}";
    } 
}