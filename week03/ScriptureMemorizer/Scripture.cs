/// <summary>
/// Scripture class - Represents a scripture with its reference, text, and a study topic
/// Stores the scripture as a list of Word objects and manages hiding/showing words for memorization
/// </summary>
public class Scripture
{
    // Scripture reference (book, chapter, verse)
    private Reference _reference;
    
    // Study topic to help users understand what the scripture is about
    private string _topic;
    
    // List of individual words in the scripture text
    private List<Word> _words;

    /// <summary>
    /// Constructor - Creates a new scripture with a reference, text, and optional topic
    /// Splits the scripture text into individual words and stores them as Word objects
    /// </summary>
    public Scripture(Reference reference, string text, string topic = "")
    {
        _reference = reference;
        _topic = topic;
        _words = new List<Word>();
        
        // Split the scripture text by spaces and create a Word object for each word
        string[] wordTexts = text.Split(' ');
        foreach (string wordText in wordTexts)
        {
            _words.Add(new Word(wordText));
        }
    }
    
    /// <summary>
    /// Returns the topic/theme of the scripture for study purposes
    /// </summary>
    public string GetTopic()
    {
        return _topic;
    }

    /// <summary>
    /// Hides 1-3 consecutive unhidden words at random
    /// Finds a random unhidden word, counts consecutive unhidden words, and hides up to 3 of them
    /// </summary>
    public void HideRandomWord()
    {
        Random random = new Random();
        int randomIndex;
        
        // Find a random unhidden word (skip any already hidden words)
        while (true)
        {
            randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                break;
            }
        }
        
        // Count how many consecutive unhidden words are available starting from randomIndex
        int consecutiveCount = 0;
        for (int i = randomIndex; i < _words.Count && !_words[i].IsHidden(); i++)
        {
            consecutiveCount++;
        }
        
        // Hide up to 3 words (or however many consecutive unhidden words remain)
        int wordsToHide = Math.Min(3, consecutiveCount);
        for (int i = 0; i < wordsToHide; i++)
        {
            _words[randomIndex + i].Hide();
        }
    }

    /// <summary>
    /// Returns the display text of the scripture with reference and words
    /// Hidden words appear as "____", visible words show their text
    /// </summary>
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    /// <summary>
    /// Checks if all words in the scripture are hidden
    /// Returns true if the user has completed the memorization exercise
    /// </summary>
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Returns a progress string showing how many words have been hidden
    /// Example: "Progress: 12/45 words hidden (27%)"
    /// Helps users track their memorization progress
    /// </summary>
    public string GetProgress()
    {
        int totalWords = _words.Count;
        int hiddenWords = 0;
        
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenWords++;
            }
        }
        
        int percentage = (totalWords > 0) ? (hiddenWords * 100) / totalWords : 0;
        return $"Progress: {hiddenWords}/{totalWords} words hidden ({percentage}%)";
    }

}

