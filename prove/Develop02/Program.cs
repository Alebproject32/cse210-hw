using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    static Journal journal = new Journal();
    static PromptGenerator promptGenerator = new PromptGenerator();
    //static Entry entry = new Entry();

    static void Main(string[] args)
    {
        
        WriteEntry();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        WriteEntry();
                        break;
                    case 2:
                        DisplayEntries();
                        break;
                    case 3:
                        LoadJournalFromFile();
                        break;
                    case 4:
                        SaveJournalToFile();
                        break;
                    case 5:
                        running = false; // Exit the program
                        break;

                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                // Add a prompt to press enter to continue for better user experience
                Console.Write("\nPress Enter to continue...");
                Console.ReadLine();
                //Journal journal;
                //journal = new Journal();
                //Console.WriteLine(journal.AddEntry(Entry newEntry));
            }
        }
    }

    static void WriteEntry()
    {
        string randomPrompt = promptGenerator.GetRandomPrompt();

        Entry newEntry = new Entry(randomPrompt);

        // Prompt user for a response and save it to newEntry.Response
        // Set date for newEntry

        journal.AddEntry(newEntry);
        Console.ReadLine();
    }

    static void DisplayEntries()
    {
        journal.DisplayAll();
    }

    static void SaveJournalToFile()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        journal.SaveToFile(filename);
    }

    static void LoadJournalFromFile()
    {
        Console.Write("Enter file name: ");
        string filename = Console.ReadLine();

        journal.LoadFromFile(filename);
    }
}