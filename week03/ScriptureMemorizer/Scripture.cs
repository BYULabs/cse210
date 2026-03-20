public class Scripture{

    private Reference _reference;
    private string _topic;
    private List<Word> _words;

    public Scripture(Reference reference, string text, string topic = "")
    {
        _reference = reference;
        _topic = topic;
        _words = new List<Word>();
        
        string[] wordTexts = text.Split(' ');
        foreach (string wordText in wordTexts)
        {
            _words.Add(new Word(wordText));
        }
    }
    
    public string GetTopic()
    {
        return _topic;
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int randomIndex;
        
        // Find a random unhidden word
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
        
        // Hide up to 3 words (or however many are available)
        int wordsToHide = Math.Min(3, consecutiveCount);
        for (int i = 0; i < wordsToHide; i++)
        {
            _words[randomIndex + i].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

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

}

