using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;


public class Program
{
    public static void Main()
    {
        User user = new User();
        bool running = true;
        while (running)
        {
            Console.Clear();
            user.DisplayScore();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateGoal(user);
                    break;
                case 2:
                    user.DisplayGoals();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string savePath = Console.ReadLine();
                    user.SaveGoals(savePath);
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string loadPath = Console.ReadLine();
                    user = User.LoadGoals(loadPath);
                    break;
                case 5:
                    Console.Write("Which goal did you accomplish? ");
                    string goalType = Console.ReadLine();
                    user.RecordGoalEvent(goalType);
                    break;
                case 6:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            if (choice != 6)
            {
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }

    public static void CreateGoal(User user)
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of point associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        switch (goalType)
        {
            case 1:
                user.AddGoal(new SimpleGoal(name, description, points));
                break;
            case 2:
                user.AddGoal(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusPoints = int.Parse(Console.ReadLine());
                user.AddGoal(new ChecklistGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }
    }
}
