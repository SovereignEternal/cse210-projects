using System;

class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string speakerName, int capacity, Address address) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}Event Type: Lecture\nSpeaker: {_speakerName}\nEvent Capacity: {_capacity}";
    }

    public override string GetShortDetails()
    {
        return $"Event Type: Lecture\nTitle: {_title}\nDate: {_date}";
    }
}