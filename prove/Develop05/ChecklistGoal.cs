using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override int RecordEvent()
    {
        if (_isComplete) 
        {
            return 0;
        }

        _currentCount++;
        int earned = _points;

        if (_currentCount >= _targetCount)
        {
            _isComplete = true;
            earned += _bonusPoints;
        }

        return earned;
    }

    public override string GoalToText()
    {
        return $"Checklist|{_name}|{_description}|{_points}|{_currentCount}|{_targetCount}|{_bonusPoints}|{_isComplete}";
    }
}