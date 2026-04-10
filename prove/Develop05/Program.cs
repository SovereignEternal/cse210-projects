using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        
        Console.Clear();

        while (true)
        {
            bool continueLoop = true;
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            int userInput = int.Parse(Console.ReadLine());

            Console.Clear();

            switch (userInput)
            {
                case 1:
                    CreateGoal(manager);
                    break;
                
                case 2:
                    manager.DisplayGoals();
                    break;
                
                case 3:
                    Console.Write("Input Filename: ");
                    manager.SaveGoals(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Input Filename: ");
                    manager.LoadGoals(Console.ReadLine());
                    break;

                case 5:
                    manager.DisplayGoals();
                    Console.Write("Select a goal #: ");
                    manager.RecordEvent(int.Parse(Console.ReadLine())-1);
                    break;

                case 7:
                    continueLoop = false;
                    return;
            }
            if (!continueLoop)
            {
                break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple\n2. Eternal\n3. Checklist");
        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            manager.AddGoal(new SimpleGoal(name,description,points));
        }
        else if (type == 2)
        {
            manager.AddGoal(new EternalGoal(name, description, points));
        }
        else if (type == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetCount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            manager.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
        }
    }
}