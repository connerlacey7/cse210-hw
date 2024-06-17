using System;

using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void WriteNewEntry(string prompt)
    {
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        entries.Add(new Entry(prompt, response, date));
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry._prompt);
                writer.WriteLine(entry._response);
                writer.WriteLine(entry._dayEntry);
            }
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load the journal: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            entries.Clear();

            string[] lines = File.ReadAllLines(filename);
            for (int i = 0; i < lines.Length; i += 3)
            {
                string prompt = lines[i];
                string response = lines[i + 1];
                string date = lines[i + 2];

                entries.Add(new Entry(prompt, response, date));
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
