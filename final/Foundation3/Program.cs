using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Expounding on Inheritance","A lecture on the benefits of inheritance in programming with classes.","April 23, 2026","19:00","John Doe",200,new Address("510 S Center St Lecture Hall","Rexburg","Idaho","USA"));
        Reception reception = new Reception("Tucker & Annie's Wedding Reception","Come celebrate the marriage of Tucker and Annie!","March 21st, 2026","17:00","johndoe@gmail.com",new Address("Church at Church St","Santa Clarita","California","USA"));
        Outdoor outdoor = new Outdoor("One Republic Outdoor Concert","Enjoy some great music!","June 3rd, 2026","14:00","Clear Skies",new Address("Random Field","Houston","Texas","USA"));

        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetShortDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor.GetShortDetails());
        Console.WriteLine();
    }
}