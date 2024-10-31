using System.Text.Json;
[Serializable]
public class User
{
    private List<Goal> goals;
    public int Score { get; private set; }

    public User()
    {
        goals = new List<Goal>();
        Score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(string goalName)
    {
        var goal = goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            Score += goal.Points;
            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete)
            {
                Score += checklistGoal.BonusPoints;
            }
        }
        else
        {
            Console.WriteLine($"Goal not found: {goalName}");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine($"Total goals added: {goals.Count}");
        for (int i = 0; i < goals.Count; i++)
        {
            var goal = goals[i];
            string status = goal.IsComplete ? "[X]" : "[ ]";
            string details = goal is ChecklistGoal checklistGoal
                ? $"Completed {checklistGoal.CurrentCount}/{checklistGoal.TargetCount} times"
                : string.Empty;
            string description = goal.Description;
            Console.WriteLine($"{i + 1}. {status} {goal.Name} ({description}) {details}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"You have {Score} points.");
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(Score);
            foreach (var goal in goals)
            {
                string type = goal.GetType().Name;
                string data = $"{type}|{goal.Name}|{goal.Description}|{goal.Points}|{goal.IsComplete}";
                if (goal is ChecklistGoal checklistGoal)
                {
                    data += $"|{checklistGoal.CurrentCount}|{checklistGoal.TargetCount}|{checklistGoal.BonusPoints}";
                }
                writer.WriteLine(data);
            }
        }
    }

    public static User LoadGoals(string filePath)
    {
        User user = new User();
        string[] lines = File.ReadAllLines(filePath);

        if (lines.Length > 0)
        {
            user.Score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('|');
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                Goal goal;

                switch (type)
                {
                    case "SimpleGoal":
                        goal = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            (goal as SimpleGoal).RecordEvent();
                        }
                        break;
                    case "EternalGoal":
                        goal = new EternalGoal(name, description, points);
                        break;
                    case "ChecklistGoal":
                        int currentCount = int.Parse(parts[5]);
                        int targetCount = int.Parse(parts[6]);
                        int bonusPoints = int.Parse(parts[7]);
                        goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                        for (int j = 0; j < currentCount; j++)
                        {
                            (goal as ChecklistGoal).RecordEvent();
                        }
                        break;
                    default:
                        throw new InvalidDataException("Unknown goal type");
                }

                user.AddGoal(goal);
            }
        }

        return user;
    }
}
