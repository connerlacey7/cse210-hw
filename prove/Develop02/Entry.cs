using System;
using System.Security.Cryptography.X509Certificates;

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
}
