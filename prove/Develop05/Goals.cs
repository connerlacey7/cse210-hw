using System;

abstract class Goals
{
    public string _name { get; set; }
    public int _value { get; set; }
    public bool _completed { get; protected set; }

    public Goals(string name, int value)
    {
        _name = name;
        _value = value;
        _completed = false;
    }

    public abstract int Record();
    public abstract string Display();
    public abstract string Save();
    
    // Method to set _completed from outside the class
    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }
}
