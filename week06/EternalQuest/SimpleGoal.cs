class SimpleGoal : Goal
{
    private bool _isComplete;
    
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
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