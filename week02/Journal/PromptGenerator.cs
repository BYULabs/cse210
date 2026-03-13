using System;
using System.Collections.Generic;

class PromptGenerator
{
    // Member variables
    private List<string> _prompts;
    private Random _random;

    // Constructor
    public PromptGenerator()
    {
        _prompts = new List<string>();
        _random = new Random();
        InitializePrompts();
    }

    // Initialize the list of prompts
    private void InitializePrompts()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was something I learned today?",
            "Who did I help today and how?",
            "What am I grateful for today?"
        };
    }

    // Get a random prompt
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}
