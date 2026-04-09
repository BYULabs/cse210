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
        return _amountCompleted >= _targetAmount;
    }

    public override string GetListDisplay()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_targetAmount} times";
    }

    public override string GetSaveData()
    {
        return base.GetSaveData();
    }
}