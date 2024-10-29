public class ListingActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Run()
    {
        StartActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine(selectedPrompt);
        ShowCountdown(5); // 5 seconds to think

        List<string> items = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item (or type 'done' to finish): ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            items.Add(item);
        }

        Console.WriteLine($"You listed {items.Count} items.");
        EndActivity("Listing");
    }
    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(100);
        }
        Console.WriteLine();
    }
}