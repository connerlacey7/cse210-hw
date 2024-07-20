using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Python 101", "An introductory lecture on Python.", "2024-08-01", "10:00 AM", "123 Main St", "Anytown", "Anystate", "12345", "Dr. John Doe", 50);
        Reception reception = new Reception("Company Gala", "An evening of networking and fun.", "2024-08-05", "7:00 PM", "456 Elm St", "Othertown", "Otherstate", "67890", "rsvp@company.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "A fun outdoor gathering for all.", "2024-08-10", "1:00 PM", "789 Oak St", "Sometown", "Somestate", "11223", "Sunny and warm");

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (Event e in events)
        {
            Console.WriteLine("Standard Details:\n" + e.GetStandardDetails());
            Console.WriteLine("\nFull Details:\n" + e.GetFullDetails());
            Console.WriteLine("\nShort Description:\n" + e.GetShortDescription());
            Console.WriteLine("\n" + new string('-', 50) + "\n");
        }
    }
}
