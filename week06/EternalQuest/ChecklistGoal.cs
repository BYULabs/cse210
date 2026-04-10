class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, int amountCompleted, int targetAmount, int bonusPoints) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _targetAmount = targetAmount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }

        _amountCompleted++;
        int pointsEarned = GetPoints();

        if (IsComplete())
        {
            pointsEarned += _bonusPoints;
        }

        return pointsEarned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetListDisplay()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_targetAmount} times";
    }

    public override string GetSaveData()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_targetAmount}|{_bonusPoints}";
    }
}