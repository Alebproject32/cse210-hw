[Serializable]
public class ChecklistGoal : Goal
{
    public int TargetCount { get; private set; }
    public int CurrentCount { get; private set; }
    public int BonusPoints { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override bool IsComplete => CurrentCount >= TargetCount;

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            CurrentCount++;
            Console.WriteLine($"Checklist goal recorded: {Name}. {Description}. You gained {Points} points.");

            if (IsComplete)
            {
                Console.WriteLine($"Checklist goal complete: {Name}. {Description}. Bonus {BonusPoints} points!");
            }
        }
        else
        {
            Console.WriteLine($"Checklist goal already complete: {Name}. {Description}.");
        }
    }

    public int TotalPoints()
    {
        return (Points * CurrentCount) + (IsComplete ? BonusPoints : 0);
    }
}