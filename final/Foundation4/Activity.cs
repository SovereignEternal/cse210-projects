using System;

class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{_date} Exercise: {GetType().Name}\nDuration: {_duration}\nDistance: {GetDistance():0.0}\nSpeed: {GetSpeed():0.0}\nPace: {GetPace():0.0}";
    }
}