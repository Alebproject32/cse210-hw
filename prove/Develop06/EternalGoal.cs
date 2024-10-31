[Serializable]
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override bool IsComplete => false;

    public override void RecordEvent()
    {
        Console.WriteLine($"Eternal goal recorded: {Name}. {Description}. You gained {Points} points.");
    }
}