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
        return _isComplete;
    }

    public override string GetListDisplay()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {GetName()} ({GetDescription()})";
    }

    public override string GetSaveData()
    {
        return base.GetSaveData();
    }

}