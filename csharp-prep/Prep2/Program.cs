using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade Percentage?");
        float gradePercentage = float.Parse(Console.ReadLine());

        if (gradePercentage > 90)
        {
            Console.WriteLine("You got an A. Good Job.");
        }
        else if (gradePercentage >= 80 && gradePercentage <= 89)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (gradePercentage >= 70 && gradePercentage <= 79)
        {
            Console.WriteLine("Your grade is a C");
        } 
        else if (gradePercentage >= 60 && gradePercentage <= 69)
        {
            Console.WriteLine("Your grade is a D");
        }  
        else if(gradePercentage <= 59)
        {
            Console.WriteLine("Your grade is a F");
        } 

        if (gradePercentage > 70)
        {
            Console.WriteLine("You passed the class! Good Job");
        }                      
        else
        {
            Console.WriteLine("You didn't pass this time. Bettre luck next time.");
        }
    }
}