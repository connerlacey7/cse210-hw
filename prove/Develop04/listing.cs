class Listing : Activity
{
    private static readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt a sense of peace this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(int duration) : base(duration) { }

    public override void Run()
    {
        StartMessage("Listing", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Pause("Think about this prompt...", 5);
        DateTime startTime = DateTime.Now;
        int count = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.Write("List item: ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You have listed {count} items.");
        EndMessage("Listing");
    }
}