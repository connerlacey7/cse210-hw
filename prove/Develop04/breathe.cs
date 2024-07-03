class Breathe : Activity
{
    public Breathe(int duration) : base(duration) { }

    public override void Run()
    {
        StartMessage("Breathing", 
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing.");
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine("Breathe in...");
            Pause("", 4);
            Console.WriteLine("Breathe out...");
            Pause("", 4);
        }
        EndMessage("Breathing");
    }
}