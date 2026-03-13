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
                
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string promptText = parts[1];
                    string entryText = parts[2];
                    
                    Entry entry = new Entry(promptText, entryText, date);
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
}
