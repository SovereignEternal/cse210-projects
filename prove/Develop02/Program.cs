using System;
using System.Net;
/*
DisplayMenu()
DisplayFiles()
SelectJournal()
*/
class Program
{
    static bool DisplayMenu(Journal journal)
    {
        bool continueLoop = true;

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("Select an option: ");
        string response = Console.ReadLine();
        if (response == "1")
        {
            journal.AddEntry();
        }
        else if (response == "2")
        {
            journal.DisplayEntries();
        }
        else if (response == "3")
        {
            journal.LoadFromFile();
        }
        else if (response == "4")
        {
            journal.SaveToFile();
        }
        else if (response == "5")
        {
            continueLoop = false;
        }
        else
        {
            Console.WriteLine("Error: Invalid Input. Please input a number from 1 to 5");
        }
        return continueLoop;
    }

    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool continueLoop = true;
        while (continueLoop == true)
        {
            continueLoop = Program.DisplayMenu(journal);
        }
    }
}