class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual int RecordEvent()
    {
        return -1;
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetListDisplay()
    {
        return "";
    }

    public virtual string GetSaveData()
    {
        return "";
    }
    
}