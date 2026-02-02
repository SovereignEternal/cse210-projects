using System;

public class Job
{
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public void DisplayJobInfo()
    {
        Console.WriteLine($"           Company: {_company}");
        Console.WriteLine($"         Job Title: {_jobTitle}");
        Console.WriteLine($"Start to End Dates: {_startYear} - {_endYear}");
    }

}