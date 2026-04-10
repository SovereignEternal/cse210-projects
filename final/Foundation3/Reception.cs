using System;

class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, string rsvpEmail, Address address) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}Event Type: Reception\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDetails()
    {
        return $"Event Type: Reception\nTitle: {_title}\nDate: {_date}";
    }
}