class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void DisplayScore()
    {
        Console.WriteLine($"Current score: {_score}");
    }
}