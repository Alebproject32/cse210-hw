using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        //Practice topic, Adding Items to the List.
        //List<string> words = new List<string>();
        //words.Add("phone");
        //words.Add("keyboard");
        //words.Add("mouse");

        //Getting the list size
        //Console.WriteLine(words.Count);

        //Iterating through a List
        //foreach (string word in words)
        //{
        //    Console.WriteLine(word);
        //}

        //this is the same way to output the list 
        //but searching foreach in the code (backend) 
        //by index or number not by name
        //for (int i = 0; i < words.Count; i++)
        //{
        //    Console.WriteLine(words[i]);
        //}

        //Assignmeent about List

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int answer = -1;
        do
        {
            Console.Write("Enter number: ");
            string numberanswer = Console.ReadLine();
            answer = int.Parse(numberanswer);

            if (answer != 0)
            {
                numbers.Add(answer);
            }
        } while (answer != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        decimal average = ((decimal)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average} ");


        Console.WriteLine($"The largest number is: {numbers.Max()}");


        Console.WriteLine($"The smallest positive number is: {numbers.Min()}");

        Console.WriteLine($"The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine($"{number}");
        }
    }
}

