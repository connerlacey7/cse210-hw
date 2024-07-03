using System;

class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public virtual void Run()
    {
        // Default implementation (if any)
    }

    public void StartMessage(string name, string description)
    {
        Console.WriteLine($"\nStarting {name} Activity");
        Console.WriteLine(description);
        Console.WriteLine($"Duration: {duration} seconds");
        Pause("Get ready...");
    }

    public void EndMessage(string name)
    {
        Console.WriteLine($"\nYou have completed the {name} activity.");
        Console.WriteLine($"Duration: {duration} seconds");
        Pause("Well done!");
    }

    public void Pause(string message, int seconds = 3)
    {
        Console.WriteLine(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\n");
    }
}