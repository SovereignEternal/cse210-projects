using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine($"\n{_description}\n");

        Console.Write($"\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    public void EndMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        ShowEllipsis(6);
    }

    public void ShowEllipsis(int seconds)
    {

        int timePassed = 0;
        Console.Write(". ");
        while (timePassed < seconds)
        {
            
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(500);
            Console.Write(". ");
            Thread.Sleep(1000);

            Console.Write($"\b\b\b\b    \b\b\b\b");
            timePassed += 2;

        }
        
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Write(" ");
    }

    public int GetDuration()
    {
        return _duration;
    }
}