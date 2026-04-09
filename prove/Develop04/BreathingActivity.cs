using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity","This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.Write("Get ready");
        ShowEllipsis(4);

        int timePassed = 0;

        int duration = GetDuration();

        while (timePassed < duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);

            timePassed += 6;
        }

        EndMessage();
    }
}