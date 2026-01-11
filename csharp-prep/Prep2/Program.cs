using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";
        Console.Write("What was your grade percentage in this class? Do not include decimal points. ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        Console.WriteLine($"Your grade in this class was: {letterGrade}.");

        if (letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congratulations on passing the class!");
        } 
        else
        {
            Console.WriteLine("Don't worry, you'll do better next time!");
        }
    }   
}