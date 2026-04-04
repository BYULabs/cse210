class BreathingActivity : Activity
{
    private const int CycleSeconds = 4;
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        int elapsedSeconds = 0;
        bool breatheIn = true;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(1000);
        Console.Write("\b \b");

        Console.WriteLine();

        while (elapsedSeconds < GetDuration())
        {
            int remainingSeconds = GetDuration() - elapsedSeconds;
            int secondsToCountDown = Math.Min(CycleSeconds, remainingSeconds);

            if (breatheIn && elapsedSeconds > 0)
            {
                Console.WriteLine();
            }

            Console.Write(breatheIn ? "Breathe in... " : "Now Breathe out... ");

            ShowCountdown(secondsToCountDown);

            Console.WriteLine();
            elapsedSeconds += secondsToCountDown;
            breatheIn = !breatheIn;
        }

        DisplayEndingMessage();
    }
}
