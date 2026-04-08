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
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetListDisplay()
    {
        return base.GetListDisplay();
    }

    public override string GetSaveData()
    {
        return base.GetSaveData();
    }
}