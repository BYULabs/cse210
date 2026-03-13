using System;

class Program
{
    // Entry point of the program
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        Console.WriteLine("Welcome to the Journal Program!\n");

        bool continueProgram = true;
        while (continueProgram)
        {
            DisplayMenu();
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal);
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    SaveJournal(journal);
                    break;
                case "4":
                    LoadJournal(journal);
                    break;
                case "5":
                    continueProgram = false;
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-5.\n");
                    break;
            }
        }
    }

    // Display the main menu options to the user
    static void DisplayMenu()
    {
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
        Console.Write("Select an option (1-5): ");
    }

    // Create a new journal entry with a random prompt
    static void WriteNewEntry(Journal journal)
    {
        string prompt = journal.GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Entry entry = new Entry(prompt, response, date);
        journal.AddEntry(entry);
        
        Console.WriteLine($"Entry added for {date}.\n");
    }

    // Display all journal entries
    static void DisplayJournal(Journal journal)
    {
        journal.DisplayAll();
    }

    // Save the journal to a file
    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    // Load the journal from a file
    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}