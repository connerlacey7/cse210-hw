using System;

class Entry

{
    public string _dayEntry;

    public string _prompt;
    public string _response;
    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _dayEntry = date;
    }

    public override string ToString()
    {
        return $"Date: {_dayEntry}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }
}
