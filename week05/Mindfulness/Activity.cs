class Activity
{
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
