using System;

class DailyGoal : Goals
{
    public DailyGoal(string name, int value) : base(name, value) { }

    public override int Record()
    {
        return _value;
    }

    public override string Display()
    {
        return $"[∞] Daily Goal: {_name} - {_value} points per time";
    }

    public override string Save()
    {
        return $"DailyGoal|{_name}|{_value}|{_completed}";
    }
}
