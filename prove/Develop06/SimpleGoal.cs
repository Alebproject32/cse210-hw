[Serializable]
public class SimpleGoal : Goal
{
    public bool Completed { get; private set; }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        Completed = false;
    }

    public override bool IsComplete => Completed;

    public override void RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            Console.WriteLine($"Goal completed: {Name}. {Description}. You gained {Points} points.");
        }
        else
        {
            Console.WriteLine($"Goal already completed: {Name} {Description}.");
        }
    }
}