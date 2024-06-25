using System;

class Word
{
    private List<string> _words = new List<string>();

    public Word(string scriptureP)
    {
        string[] array = scriptureP.Split(" ");

        foreach (string a in array)
        {
            _words.Add(a);
        }
    }
    public void Underscore(int i)
    {
        _words[i] = "___";
    }

    public void Underscore3()
    {
        Random random = new Random();
        HashSet<int> indices = new HashSet<int>();
        while (indices.Count < 3)
        {
            int r = random.Next(0, _words.Count);
            if (_words[r] != "___")
            {
                Underscore(r);
                indices.Add(r);
            }
        }
    }
    public void ScriptureOut()
    {
        foreach(string e in _words)
        {
            Console.Write(e + " ");
        }
    }

}