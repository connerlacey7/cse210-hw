class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Event(string title, string description, string date, string time, string street, string city, string state, string zipCode)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public string Address => $"{_street}, {_city}, {_state} {_zipCode}";

    public virtual string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {Address}";
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\nTitle: {_title}\nDate: {_date}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }
}
