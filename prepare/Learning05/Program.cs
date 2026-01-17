using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int birthYear = 2000;

        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptFavoriteNumber();
        PromptUserBirthYear(out birthYear);
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNumber, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please input your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptFavoriteNumber()
    {
        Console.Write("What is your favorite number: ");
        int favoriteNumber = int.Parse(Console.ReadLine());
        return favoriteNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int factor)
    {
        int product = factor * factor;
        return product;
    }

    static void DisplayResult(string userName, int squaredNumber, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}. ");
        int age = 2026 - birthYear;
        Console.WriteLine($"{userName}, you will turn {age} this year. ");
    }
}