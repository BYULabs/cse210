public class Scripture{

    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        
        string[] wordTexts = text.Split(' ');
        foreach (string wordText in wordTexts)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWord()
    {
        
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

