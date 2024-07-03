class Program
{
    static void Main()
    {
        Dictionary<string, Func<int, Activity>> activities = new Dictionary<string, Func<int, Activity>>
        {
            { "1", duration => new Breathe(duration) },
            { "2", duration => new Reflect(duration) },
            { "3", duration => new Listing(duration) }
        };

        while (true)
        {
            Console.WriteLine("\nMindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            if (choice == "4")
            {
                break;
            }

            if (activities.ContainsKey(choice))
            {
                Console.Write("Enter duration in seconds: ");
                int duration = int.Parse(Console.ReadLine());
                var activity = activities[choice](duration);
                activity.Run();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid activity.");
            }
        }
    }
}