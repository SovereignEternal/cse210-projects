using System;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1} - {_goals[i].GetGoalStatus()}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index < 0 || index >= _goals.Count)
        {
            return;
        }

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GoalToText());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "Simple")
            {
                SimpleGoal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }

            if (type == "Eternal")
            {
                EternalGoal goal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                _goals.Add(goal);
            }

            if (type == "Checklist")
            {
                ChecklistGoal goal = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[5]),int.Parse(parts[6]));
                int current = int.Parse(parts[4]);
                for (int j = 0; i < current; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }
    }
}