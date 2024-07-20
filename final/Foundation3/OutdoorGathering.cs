class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, string date, string time, string street, string city, string state, string zipCode, string weatherStatement)
        : base(title, description, date, time, street, city, state, zipCode)
    {
        _weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Outdoor Gathering\nWeather: {_weatherStatement}";
    }
}
