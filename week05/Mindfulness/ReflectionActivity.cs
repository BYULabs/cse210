class ReflectionActivity : Activity
{
    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("[Part 1] Reflection activity logic will be added next.");
        DisplayEndingMessage();
    }
}
