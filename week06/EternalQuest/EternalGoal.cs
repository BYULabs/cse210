class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
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