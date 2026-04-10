using System;

class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps / 20;
    }

    public override double GetSpeed()
    {
        return GetDistance() * 60 / _duration;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}