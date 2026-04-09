using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference reference = new Reference("Helaman",5,12);
        string scriptureText = "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.";
        Scripture scripture = new Scripture(reference,scriptureText);

        Console.WriteLine("Press Enter to continue, or type quit.");

        scripture.DisplayScripture();
        userInput = Console.ReadLine();

        while (true)
        {
            bool allHidden = scripture.AllHidden();
            if (allHidden || userInput == "quit" || userInput == "Quit")
            {
                break;   
            }
            else
            {
                scripture.HideWords();
                scripture.DisplayScripture();
                userInput = Console.ReadLine();
            }
        }
    }
}