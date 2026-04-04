class Activity
{
    private Random _random = new Random();
    private Dictionary<string, List<int>> _unusedItemIndexesByKey = new Dictionary<string, List<int>>();
    private string _name;
    private string _description;
    private int _duration;
    private const int SpinnerDelayMilliseconds = 120;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected void SetDuration(int duration)
    {
        _duration = duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");

        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a positive whole number: ");
        }

        SetDuration(duration);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Good job!");
        ShowSpinner(2000);
        Console.WriteLine($"You have completed another {GetDuration()} seconds of the {_name}.");
        ShowSpinner(2500);
        return;
    }

    protected string GetRandomItemWithoutRepeating(string key, string[] items)
    {
        if (!_unusedItemIndexesByKey.TryGetValue(key, out List<int> unusedIndexes))
        {
            unusedIndexes = new List<int>();
            _unusedItemIndexesByKey[key] = unusedIndexes;
        }

        if (unusedIndexes.Count == 0)
        {
            for (int index = 0; index < items.Length; index++)
            {
                unusedIndexes.Add(index);
            }
        }

        int selectedIndexPosition = _random.Next(unusedIndexes.Count);
        int selectedIndex = unusedIndexes[selectedIndexPosition];
        unusedIndexes.RemoveAt(selectedIndexPosition);

        return items[selectedIndex];
    }

    protected void ShowCountdown(int seconds)
    {
        for (int countdown = seconds; countdown > 0; countdown--)
        {
            Console.Write(countdown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    protected void ShowSpinner(int totalMilliseconds)
    {
        string[] spinnerFrames = { "|", "/", "-", "\\" };
        int elapsedMilliseconds = 0;
        int frameIndex = 0;

        while (elapsedMilliseconds < totalMilliseconds)
        {
            Console.Write(spinnerFrames[frameIndex]);
            Thread.Sleep(SpinnerDelayMilliseconds);
            Console.Write("\b");

            elapsedMilliseconds += SpinnerDelayMilliseconds;
            frameIndex = (frameIndex + 1) % spinnerFrames.Length;
        }
    }
}
