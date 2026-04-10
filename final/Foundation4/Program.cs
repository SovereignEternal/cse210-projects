using System;

class Program
{
    static void Main(string[] args)
    {
        Activity running = new Running("04/22/26",20,4.0);
        Activity cycling = new Cycling("04/23/26",30,40);
        Activity swimming = new Swimming("04/25/26",30,50);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}