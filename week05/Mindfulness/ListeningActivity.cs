class ListingActivity : Activity
{
    private string[] Prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(1500);

        string selectedPrompt = GetRandomItemWithoutRepeating("ListingPrompts", Prompts);

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {selectedPrompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");

        ShowCountdown(5);

        int itemCount = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {itemCount} items!");

        DisplayEndingMessage();
    }
}