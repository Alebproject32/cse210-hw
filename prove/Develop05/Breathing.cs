public class BreathingActivity : Activity
{
    public void Run()
    {
        StartActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Console.WriteLine();
            ShowCountdown(4); // 4 seconds

            Thread.Sleep(2500);


            Console.WriteLine("Now breathe out...");
            Console.WriteLine();
            ShowCountdown(4); // 4 seconds

            Thread.Sleep(2500);

        }

        EndActivity("Breathing");
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