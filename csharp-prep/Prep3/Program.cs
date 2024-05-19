using System;

class Program
{
    static void Main(string[] args)
    {
    Random randomGenerator = new Random();
    int magicNumber = int.Parse(Console.ReadLine());

    int guess = -1;

    while (guess != magicNumber)
    {
        Console.Write("what is your guess?");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You done guessed it!");
        }
    }
    }
}