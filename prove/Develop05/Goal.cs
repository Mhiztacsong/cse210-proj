public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
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
        return $"{status} {_shortName} - {_description}: {_points} points";
    }

    public abstract string GetStringRepresentation();

    public int GetPoints()
    {
        return _points;
    }

    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }   
}