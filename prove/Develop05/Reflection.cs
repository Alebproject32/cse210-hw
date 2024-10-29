
public class ReflectionActivity : Activity
{
    private readonly List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private readonly List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void Run()
    {
        StartActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Random random = new Random();
        string selectedPrompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine(selectedPrompt);
        ShowCountdown(5); // 5 seconds to think

        while (DateTime.Now < endTime)
        {
            string selectedQuestion = questions[random.Next(questions.Count)];
            Console.WriteLine(selectedQuestion);
            ShowCountdown(10); // 10 seconds to reflect
        }

        EndActivity("Reflection");
    }
    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}... ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}