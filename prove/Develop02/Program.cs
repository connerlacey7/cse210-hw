using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Prompt prompt = new Prompt();
        string generatedPrompt = prompt.GetRandomPrompt();
        Console.WriteLine(generatedPrompt);
    }
}