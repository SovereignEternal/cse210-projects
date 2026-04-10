using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetGoalStatus()
    {
        return $"[ ] {_name}";
    }

    public override string GoalToText()
    {
        return $"Eternal|{_name}|{_description}|{_points}";
    }

}