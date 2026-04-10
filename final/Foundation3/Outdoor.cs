using System;

class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string weather, Address address) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}Event Type: Outdoor Event\nWeather Conditions: {_weather}";
    }

    public override string GetShortDetails()
    {
        return $"Event Type: Outdoor Event\nTitle: {_title}\nDate: {_date}";
    }
}