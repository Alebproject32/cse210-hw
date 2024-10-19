using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop03 World!");
        // Create a scripture
        var reference = new Reference("Proverbs", 3, 5, 6);
        var words = new List<Word>
        {
            new Word("Trust"),
            new Word("in"),
            new Word("the"),
            new Word("Lord"),
            new Word("with"),
            new Word("all"),
            new Word("your"),
            new Word("heart;"),
            new Word("lean"),
            new Word("not"),
            new Word("on"),
            new Word("your"),
            new Word("own"),
            new Word("understanding."),
            new Word("In"),
            new Word("all"),
            new Word("your"),
            new Word("ways"),
            new Word("acknowledge"),
            new Word("Him,"),
            new Word("and"),
            new Word("He"),
            new Word("will"),
            new Word("make"),
            new Word("your"),
            new Word("paths"),
            new Word("straight.")
        };
        var scripture = new Scripture(reference, words);

        Console.Clear();

        // Main loop to interact with the user
        while (true)
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish:");

            string input = Console.ReadLine();
            if (string.Equals(input, "quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3); // Hide 3 random words
                if (scripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("All words are hidden. Exiting the program.");
                    break;
                }
            }
        }
    }
}