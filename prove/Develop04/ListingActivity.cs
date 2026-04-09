using System;


class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base("Listing Activity","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.Write("\nGet ready...");
        ShowEllipsis(4);

        int duration = GetDuration();
        int itemCount = 0;

        int randomIndex = _random.Next(_prompts.Count);
        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[randomIndex]} ---");

        Console.Write("\nYou may begin in:");
        ShowCountdown(5);

        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {itemCount} items.");

        EndMessage();
    }
}