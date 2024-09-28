using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        string valueFromUser = Console.ReadLine();
        int x = int.Parse(valueFromUser);
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;
        string letter = "";
        if (x >= A)
        {
            letter = "A";
            if (x >= 97)
            {
                Console.WriteLine($"{letter}+");
            }
            else if (x < 93)
            {
                Console.WriteLine($"{letter}-");
            }
            else
            {
                Console.WriteLine($"{letter}");
            }

        }
        else if (x >= B)
        {
            letter = "B";
            if (x >= 87)
            {
                Console.WriteLine($"{letter}+");
            }
            else if (x < 83)
            {
                Console.WriteLine($"{letter}-");
            }
            else
            {
                Console.WriteLine($"{letter}");
            }
        }
        else if (x >= C)
        {
            letter = "C";
            if (x >= 77)
            {
                Console.WriteLine($"{letter}+");
            }
            else if (x < 73)
            {
                Console.WriteLine($"{letter}-");
            }
            else
            {
                Console.WriteLine($"{letter}");
            }
        }
        else if (x >= D)
        {
            letter = "D";
            if (x >= 67)
            {
                Console.WriteLine($"{letter}+");
            }
            else if (x < 63)
            {
                Console.WriteLine($"{letter}-");
            }
            else
            {
                Console.WriteLine($"{letter}");
            }
        }
        else
        {
            letter = "F";
        }
        if (x >= D)
        {
            Console.WriteLine("Congratulation to approve the course.");
        }
        else
        {
            Console.WriteLine("You didn´t pass the course this time, but we know you will do it better next one.");
        }
        Console.WriteLine($"Your final grade in this course is {letter}");
    }
}