using System;

public class Reference
{
    private string book;
    private int chapter;
    private int verse;

    public Reference()
    {
        book = "1 Nephi";
        chapter = 3;
        verse = 7;
    }

    public string GetBook()
    {
        return book;
    }

    public void SetBook(string newBook)
    {
        book = newBook;
    }

    public int GetChapter()
    {
        return chapter;
    }

    public void SetChapter(int newChapter)
    {
        chapter = newChapter;
    }

    public int GetVerse()
    {
        return verse;
    }

    public void SetVerse(int newVerse)
    {
        verse = newVerse;
    }

    public void DisplayReference()
    {
        Console.WriteLine($"{book} {chapter}:{verse}");
    }
}