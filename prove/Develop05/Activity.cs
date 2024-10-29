
public abstract class Activity
{
    protected int _duration;
    public string _name;
    public string _description;

    public void StartActivity(string _name, string _description)
    {
        Console.Clear();
        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.Write("Enter the duration for this activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        ShowAnimation(); // Show animation while pausing
        Thread.Sleep(300); // Pause for 3 seconds
    }

    protected void EndActivity(string _name)
    {
        Console.WriteLine("Good job!");
        ShowAnimation(); // Show animation while pausing
        Thread.Sleep(300); // Pause for 3 seconds
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
    }

    protected void ShowAnimation()
    {
        Console.Write("[");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("+");
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(300);
        }
        Console.WriteLine("]");
    }
}