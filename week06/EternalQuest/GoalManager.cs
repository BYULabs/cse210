class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void DisplayScore()
    {
        Console.WriteLine($"Current score: {_score}");
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
            return;
        }

        for (int goalIndex = 0; goalIndex < _goals.Count; goalIndex++)
        {
            Console.WriteLine($"{goalIndex + 1}. {_goals[goalIndex]. GetListDisplay()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine();
        
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points, false));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int targetAmount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            _goals.Add(new CheckListGoal(name, description, points, 0, targetAmount, bonusPoints));
        }
        else
        {
            Console.WriteLine("That is not a valid goal type.");
        }
    }

    public void SaveGoals(string filename)
    {
        List<string> lines = new List<string>();
        lines.Add(_score.ToString());

        foreach (Goal goal in _goals)
        {
            lines.Add(goal.GetSaveData());
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine($"Goals saved to {filename}.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Could not find {filename}.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = 0;

        if (lines.Length == 0)
        {
            Console.WriteLine("That file does not contain any goals.");
            return;
        }

        _score = int.Parse(lines[0]);

        for (int lineIndex = 1; lineIndex < lines.Length; lineIndex++)
        {
            string[] parts = lines[lineIndex].Split('|');

            if (parts.Length == 0)
            {
                continue;
            }

            string goalType = parts[0];

            if (goalType == "SimpleGoal" && parts.Length >= 5)
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
            }
            else if (goalType == "EternalGoal" && parts.Length >= 4)
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (goalType == "ChecklistGoal" && parts.Length >= 7)
            {
                _goals.Add(new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
            }
        }

        Console.WriteLine($"Goals loaded from {filename}.");
    }
}