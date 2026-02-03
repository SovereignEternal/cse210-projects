using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "McDonald's";
        job1._jobTitle = "Crew Member";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Deseret Industries";
        job2._jobTitle = "Forklift Operator";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Job job3 = new Job();
        job3._company = "Wendy's";
        job3._jobTitle = "Crew Member";
        job3._startYear = 2025;
        job3._endYear = 2026;

        Resume resume = new Resume();
        resume._name = "Tanner Lyche";
        resume._jobs = [job1,job2,job3];
        
        resume.DisplayResume();
    }
}