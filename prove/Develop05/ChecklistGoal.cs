using System;

class ChecklistGoal : Goals
{
    public int _targetCount { get; set; }
    public int _currentCount { get; set; }
    public int _bonus { get; set; }

    public ChecklistGoal(string name, int value, int targetCount, int bonus) : base(name, value)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int Record()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                _completed = true;
                return _value + _bonus;
            }
            return _value;
        }
        return 0;
    }

    public override string Display()
    {
        string status = _completed ? "[X]" : "[ ]";
        return $"{status} Checklist Goal: {_name} - {_value} points ({_currentCount}/{_targetCount} completed, Bonus: {_bonus} points)";
    }

    public override string Save()
    {
        return $"ChecklistGoal|{_name}|{_value}|{_completed}|{_currentCount}|{_targetCount}|{_bonus}";
    }
}
