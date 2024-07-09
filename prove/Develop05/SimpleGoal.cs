using System;

class SimpleGoal : Goals
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override int Record()
    {
        if (!_completed)
        {
            _completed = true;
            return _value;
        }
        return 0;
    }

    public override string Display()
    {
        string status = _completed ? "[X]" : "[ ]";
        return $"{status} Simple Goal: {_name} - {_value} points";
    }

    public override string Save()
    {
        return $"SimpleGoal|{_name}|{_value}|{_completed}";
    }
}
