using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    // Member variables
    private List<Entry> _entries;
    private PromptGenerator _promptGenerator;

    // Constructor
    public Journal()
    {
        _entries = new List<Entry>();
        _promptGenerator = new PromptGenerator();
    }

    // Get a random prompt from the PromptGenerator
    public string GetRandomPrompt()
    {
        return _promptGenerator.GetRandomPrompt();
    }

    // Add a new entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all entries
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.\n");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    // Display statistics about the journal
    public void DisplayStatistics()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to analyze.\n");
            return;
        }

        int totalWords = 0;
        foreach (Entry entry in _entries)
        {
            totalWords += entry.WordCount;
        }

        double averageWords = (double)totalWords / _entries.Count;

        Console.WriteLine("\n--- Journal Statistics ---");
        Console.WriteLine($"Total Entries: {_entries.Count}");
        Console.WriteLine($"Total Words Written: {totalWords}");
        Console.WriteLine($"Average Words per Entry: {averageWords:F1}");
        Console.WriteLine();
    }

    // Search entries by keyword
    public void SearchEntries(string keyword)
    {
        List<Entry> results = new List<Entry>();

        foreach (Entry entry in _entries)
        {
            if (entry.EntryText.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                entry.PromptText.Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(entry);
            }
        }

        if (results.Count == 0)
        {
            Console.WriteLine($"No entries found containing '{keyword}'.\n");
            return;
        }

        Console.WriteLine($"\n--- Search Results for '{keyword}' ({results.Count} found) ---");
        foreach (Entry entry in results)
        {
            entry.Display();
        }
    }

    // Save journal to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.FormatForFile());
                }
            }
            string fullPath = Path.GetFullPath(filename);
            Console.WriteLine($"Journal saved to {fullPath}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving file: {ex.Message}\n");
        }
    }

    // Load journal from a file
    public void LoadFromFile(string filename)
    {
        try
        {
            _entries.Clear();
            
            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} not found.\n");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            
            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~");
                
                if (parts.Length == 4)
                {
                    string date = parts[0];
                    string mood = parts[1];
                    string promptText = parts[2];
                    string entryText = parts[3];
                    
                    Entry entry = new Entry(promptText, entryText, date, mood);
                    _entries.Add(entry);
                }
            }
            
            Console.WriteLine($"Journal loaded from {filename} ({_entries.Count} entries)\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}\n");
        }
    }

    // Save journal as CSV (Excel-compatible format)
    public void SaveAsCSV(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                // Write CSV header
                outputFile.WriteLine("Date,Mood,Prompt,Response");

                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.FormatAsCSV());
                }
            }
            string fullPath = Path.GetFullPath(filename);
            Console.WriteLine($"Journal saved as CSV to {fullPath}\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving CSV file: {ex.Message}\n");
        }
    }

    // Load journal from CSV file
    public void LoadFromCSV(string filename)
    {
        try
        {
            _entries.Clear();

            if (!File.Exists(filename))
            {
                Console.WriteLine($"File {filename} not found.\n");
                return;
            }

            string[] lines = File.ReadAllLines(filename);

            // Skip header line
            for (int i = 1; i < lines.Length; i++)
            {
                Entry entry = Entry.ParseFromCSV(lines[i]);
                if (entry != null)
                {
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded from CSV {filename} ({_entries.Count} entries)\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading CSV file: {ex.Message}\n");
        }
    }
}
