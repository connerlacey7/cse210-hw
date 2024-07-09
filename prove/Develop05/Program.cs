using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();
        bool running = true;

        while (running)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Daily Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Save Goals");
            Console.WriteLine("8. Load Goals");
            Console.WriteLine("9. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateSimpleGoal(tracker);
                    break;
                case "2":
                    CreateDailyGoal(tracker);
                    break;
                case "3":
                    CreateChecklistGoal(tracker);
                    break;
                case "4":
                    RecordEvent(tracker);
                    break;
                case "5":
                    tracker.DisplayGoals();
                    break;
                case "6":
                    tracker.DisplayScore();
                    break;
                case "7":
                    SaveGoals(tracker);
                    break;
                case "8":
                    LoadGoals(tracker);
                    break;
                case "9":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateSimpleGoal(GoalTracker tracker)
    {
        Console.Write("Enter the name of the simple goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the value of the simple goal: ");
        int value = int.Parse(Console.ReadLine());
        tracker.CreateSimpleGoal(name, value);
    }

    static void CreateDailyGoal(GoalTracker tracker)
    {
        Console.Write("Enter the name of the daily goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the value of the daily goal: ");
        int value = int.Parse(Console.ReadLine());
        tracker.CreateDailyGoal(name, value);
    }

    static void CreateChecklistGoal(GoalTracker tracker)
    {
        Console.Write("Enter the name of the checklist goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the value of the checklist goal: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter the target count of the checklist goal: ");
        int targetCount = int.Parse(Console.ReadLine());
        Console.Write("Enter the bonus of the checklist goal: ");
        int bonus = int.Parse(Console.ReadLine());
        tracker.CreateChecklistGoal(name, value, targetCount, bonus);
    }

    static void RecordEvent(GoalTracker tracker)
    {
        Console.Write("Enter the name of the goal to record: ");
        string name = Console.ReadLine();
        tracker.RecordEvent(name);
    }

    static void SaveGoals(GoalTracker tracker)
    {
        Console.Write("Enter the file path to save goals: ");
        string filePath = Console.ReadLine();
        tracker.SaveGoals(filePath);
    }

    static void LoadGoals(GoalTracker tracker)
    {
        Console.Write("Enter the file path to load goals: ");
        string filePath = Console.ReadLine();
        tracker.LoadGoals(filePath);
    }
}

class GoalTracker
{
    private List<Goals> goals;
    private int score;

    public GoalTracker()
    {
        goals = new List<Goals>();
        score = 0;
    }

    public void CreateSimpleGoal(string name, int value)
    {
        goals.Add(new SimpleGoal(name, value));
    }

    public void CreateDailyGoal(string name, int value)
    {
        goals.Add(new DailyGoal(name, value));
    }

    public void CreateChecklistGoal(string name, int value, int targetCount, int bonus)
    {
        goals.Add(new ChecklistGoal(name, value, targetCount, bonus));
    }

    public void RecordEvent(string name)
    {
        foreach (var goal in goals)
        {
            if (goal._name == name)
            {
                score += goal.Record();
                break;
            }
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.Display());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {score}");
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(score);
            foreach (var goal in goals)
            {
                writer.WriteLine(goal.Save());
            }
        }
    }

    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                score = int.Parse(reader.ReadLine());
                goals = new List<Goals>();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    int value = int.Parse(parts[2]);
                    bool completed = bool.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            SimpleGoal simpleGoal = new SimpleGoal(name, value);
                            simpleGoal.SetCompleted(completed); // Use the method to set _completed
                            goals.Add(simpleGoal);
                            break;
                        case "DailyGoal":
                            DailyGoal dailyGoal = new DailyGoal(name, value);
                            goals.Add(dailyGoal);
                            break;
                        case "ChecklistGoal":
                            int currentCount = int.Parse(parts[4]);
                            int targetCount = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, value, targetCount, bonus)
                            {
                                _currentCount = currentCount
                            };
                            checklistGoal.SetCompleted(completed); // Use the method to set _completed
                            goals.Add(checklistGoal);
                            break;
                    }
                }
            }
        }
    }
}
