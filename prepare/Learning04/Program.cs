using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput = 1;
        int sum = 0;
        int maximum = 0;
        float average = 0;

        while (userInput != 0)
        {
            Console.Write("What number would you like to add to the list? To continue to computations, enter 0. ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > maximum)
            {
                maximum = numbers[i];
            }
        }
        float sumFloat = sum;
        if (sum > 0)
        {
            average = sumFloat / numbers.Count;
        }
        Console.WriteLine($"Sum of numbers in list: {sum}");
        Console.WriteLine($"Average of numbers in list: {average}");
        Console.WriteLine($"Highest value in list: {maximum}");

    }
}