using System;

class Entry
{
    // Member variables
    private string _date;
    private string _promptText;
    private string _entryText;
    private string _mood;

    // Constructor
    public Entry(string promptText, string entryText, string date, string mood = "neutral")
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
        _mood = mood;
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

    public string Mood
    {
        get { return _mood; }
    }

    public int WordCount
    {
        get { return _entryText.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length; }
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText} ({WordCount} words)");
        Console.WriteLine();
    }

    // Method to format entry for saving to file (pipe-delimited format)
    public string FormatForFile()
    {
        // Using "~|~" as separator since it's unlikely to appear in user input
        return $"{_date}~|~{_mood}~|~{_promptText}~|~{_entryText}";
    }

    // Method to format entry as CSV with proper escaping
    public string FormatAsCSV()
    {
        // Escape quotes by doubling them and wrap in quotes if contains comma or quote
        string EscapeCSV(string field)
        {
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
            {
                return "\"" + field.Replace("\"", "\"\"") + "\"";
            }
            return field;
        }

        return $"{EscapeCSV(_date)},{EscapeCSV(_mood)},{EscapeCSV(_promptText)},{EscapeCSV(_entryText)}";
    }

    // Method to parse CSV line back into an Entry
    public static Entry ParseFromCSV(string csvLine)
    {
        var fields = ParseCSVLine(csvLine);
        if (fields.Count >= 4)
        {
            return new Entry(fields[2], fields[3], fields[0], fields[1]);
        }
        return null;
    }

    // Helper method to parse CSV line respecting quoted fields
    private static List<string> ParseCSVLine(string line)
    {
        var fields = new List<string>();
        string currentField = "";
        bool insideQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (c == '"')
            {
                if (insideQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    // Double quote means literal quote
                    currentField += "\"";
                    i++;
                }
                else
                {
                    // Toggle quote state
                    insideQuotes = !insideQuotes;
                }
            }
            else if (c == ',' && !insideQuotes)
            {
                fields.Add(currentField);
                currentField = "";
            }
            else
            {
                currentField += c;
            }
        }

        fields.Add(currentField);
        return fields;
    }
}
