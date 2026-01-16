using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //variable setup
        string gameStatus = "continue";
        Random randomGenerator = new Random();
        int guessCounter = 0;
        string keepPlaying = "Y";

        Console.Write("Let's play a game! Try and guess the magic number, between 1 and 100. What's your guess? ");
        while (keepPlaying == "Y" || keepPlaying == "y")
        {
            int randomNumber = randomGenerator.Next(1,100);
            while (gameStatus != "end")
            {
                int guess = int.Parse(Console.ReadLine());
                if (guess < randomNumber)
                {
                    Console.WriteLine("Higher! ");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Lower! ");
                }
                else if (guess == randomNumber)
                {
                    Console.WriteLine("You guessed it!");
                    gameStatus = "end"; 
                }
                guessCounter += 1;
            }
            Console.WriteLine($"It took you {guessCounter} guesses.");
            Console.Write("Would you like to play again? (Y/N) ");
            keepPlaying = Console.ReadLine();
            if (keepPlaying == "Y" || keepPlaying == "y")
            {
                gameStatus = "continue";
                guessCounter = 0;
                Console.Write("Alright, new number. Guess again! ");
            }
        }
    }
}