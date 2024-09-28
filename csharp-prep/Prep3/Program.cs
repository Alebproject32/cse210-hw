using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        //Practice for While loop (alone)
        //string response = "yes";
        //while (response == "yes")
        //{
        //Console.WriteLine("Do you want to continue? ");
        //response = Console.ReadLine();
        //}

        //Practice Do-While Loops (alone)
        //string answer;
        //do
        //{
        //Console.WriteLine("Do you want to continue? ");
        //answer = Console.ReadLine();
        //} //while (answer == "yes");

        //Practice sintaxys For Loops(alone)
        //for (int i = 0; i < 10; i++)
        //{
        //  Console.WriteLine(i);
        //}

        //for (int i = 2; i <= 20; i = i + 2)
        //{
        //    Console.WriteLine(i);
        //}

        //Practice sintaxys Foreach Loops (alone)
        //foreach (string color in colors)
        //{
        //    Console.WriteLine(color);
        //}

        //Random Numbers
        //Random randomGenerator = new Random();
        //int number = randomGenerator.Next(1, 11);

        // Assignment Guess My Number game

        //First requirements at point #1 and #2
        //string valueFromUser;

        //Second requirements at point #3
        Random randomGenerator = new Random();
        int x = randomGenerator.Next(1, 100);


        int y = -1;
        do
        {
            Console.Write("What is your guess? ");
            y = int.Parse(Console.ReadLine());
            //First Requirements at point #1 and #2
            //int x = int.Parse(valueFromUser);
            //int y = 20;
            if (x > y)
            {
                Console.WriteLine("Higher.");
            }
            else if (x < y)
            {
                Console.WriteLine("Lower.");
            }
            else
            {
                //First requirements at point #1 and #2
                //Console.WriteLine($"What is the magic number? {y}");
                Console.WriteLine($"What is the magic number? {x}");
                //First requirements at point #1 and #2
                //Console.WriteLine($"What is your guess? {x}");
                Console.WriteLine($"What is your guess? {y}");
                Console.WriteLine("You guessed it!");
            }
            //First requirements at point #1 and #2
            //while (valueFromUser != y);

            //Second requirements at point #3
        } while (y != x);
    }
}

