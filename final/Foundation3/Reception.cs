class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, string street, string city, string state, string zipCode, string rsvpEmail)
        : base(title, description, date, time, street, city, state, zipCode)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
}
