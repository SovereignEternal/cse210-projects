using System;

class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you apply this in the future?"
    };
    private Random _random = new Random();

    public ReflectionActivity() : base("Reflection Activity","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        StartMessage();

        Console.WriteLine("\nGet ready...");
        ShowEllipsis(6);

        int duration = GetDuration();
        int timePassed = 0;

        int randomIndex = _random.Next(_prompts.Count);
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($" --- {_prompts[randomIndex]} ---");

        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine($"\nNow ponder on the following questions as they related to this experience.");
        ShowCountdown(5);
        Console.Clear();

        while (timePassed < duration)
        {
            int questionIndex = _random.Next(_questions.Count);

            Console.WriteLine(_questions[questionIndex]);
            ShowEllipsis(4);

            timePassed += 4;
        }

        EndMessage();
    }
}