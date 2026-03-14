using System;

class Program
{
    // EXCEEDS REQUIREMENTS:
    // - Added mood/emotion tracking to each entry to save additional information
    // - Implemented CSV export/import functionality with proper Excel compatibility
    //   (handles commas and quotation marks correctly in entry content)
    // - Added entry search by keyword to help users find past entries
    // - Added statistics display showing total entries, word count, and averages
    // - Display word count for each entry to provide writing insights
    // - Entries now store mood, providing emotional context to reflections

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
                    SaveJournalAsCSV(journal);
                    break;
                case "6":
                    LoadJournalFromCSV(journal);
                    break;
                case "7":
                    SearchJournal(journal);
                    break;
                case "8":
                    DisplayStatistics(journal);
                    break;
                case "9":
                    continueProgram = false;
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!\n");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1-9.\n");
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
        Console.WriteLine("5. Save journal as CSV (Excel)");
        Console.WriteLine("6. Load journal from CSV");
        Console.WriteLine("7. Search entries by keyword");
        Console.WriteLine("8. View statistics");
        Console.WriteLine("9. Quit");
        Console.Write("Select an option (1-9): ");
    }

    // Create a new journal entry with a random prompt and mood tracking
    static void WriteNewEntry(Journal journal)
    {
        string prompt = journal.GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        
        Console.Write("How are you feeling? (happy/sad/neutral/excited/thoughtful): ");
        string mood = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(mood))
        {
            mood = "neutral";
        }
        
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Entry entry = new Entry(prompt, response, date, mood);
        journal.AddEntry(entry);
        
        Console.WriteLine($"Entry added for {date}.\n");
    }

    // Display all journal entries
    static void DisplayJournal(Journal journal)
    {
        journal.DisplayAll();
    }

    // Save the journal to a plain text file
    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    // Load the journal from a plain text file
    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }

    // Save the journal as a CSV file (Excel-compatible)
    static void SaveJournalAsCSV(Journal journal)
    {
        Console.Write("Enter the CSV filename to save to: ");
        string filename = Console.ReadLine();
        journal.SaveAsCSV(filename);
    }

    // Load the journal from a CSV file
    static void LoadJournalFromCSV(Journal journal)
    {
        Console.Write("Enter the CSV filename to load from: ");
        string filename = Console.ReadLine();
        journal.LoadFromCSV(filename);
    }

    // Search the journal for entries containing a keyword
    static void SearchJournal(Journal journal)
    {
        Console.Write("Enter a keyword to search for: ");
        string keyword = Console.ReadLine();
        journal.SearchEntries(keyword);
    }

    // Display statistics about the journal
    static void DisplayStatistics(Journal journal)
    {
        journal.DisplayStatistics();
    }
}