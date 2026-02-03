using System;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"{_name}'s Resume: ");
        Console.WriteLine("Jobs:");
        foreach (var item in _jobs)
        {
            item.DisplayJobInfo();
        }
    }
}