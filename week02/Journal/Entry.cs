using System;

class Entry
{
    // Member variables
    private string _date;
    private string _promptText;
    private string _entryText;

    // Constructor
    public Entry(string promptText, string entryText, string date)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Properties
    public string Date
    {
        get { return _date; }
    }

    public string PromptText
    {
        get { return _promptText; }
    }

    public string EntryText
    {
        get { return _entryText; }
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine();
    }

    // Method to format entry for saving to file
    public string FormatForFile()
    {
        // Using "~|~" as separator since it's unlikely to appear in user input
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }
}
