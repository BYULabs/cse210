class ListingActivity : Activity
{
    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();
        Console.WriteLine("[Part 1] Listing activity logic will be added next.");
        DisplayEndingMessage();
    }
}