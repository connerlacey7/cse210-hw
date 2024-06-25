public class Program
{
    public static void Main()
    {
        Console.WriteLine("Do you want to memorize Scripture ref? (yes or no)");
        string response = Console.ReadLine().ToLower();

        if (response == "yes")
        {
            Reference reference = new Reference();
            Scripture scripture = new Scripture();
            Word word = new Word(scripture.GetScripture());

            reference.DisplayReference();
            word.ScriptureOut();

            while (true)
            {
                Console.WriteLine("Press Enter to remove three words, or type 'stop' to exit...");
                string input = Console.ReadLine().ToLower();
                if (input == "stop")
                {
                    Console.WriteLine("Program terminated.");
                    break;
                }
                word.Underscore3();
                word.ScriptureOut();
            }
        }
        else
        {
            Console.WriteLine("Program terminated.");
        }
    }
}