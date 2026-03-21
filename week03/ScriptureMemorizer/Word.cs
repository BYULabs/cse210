/// <summary>
/// Word class - Represents a single word in a scripture
/// Each word can be shown (visible text) or hidden (displays as "____")
/// </summary>
public class Word
{
    // The actual text of the word
    private string _text;
    
    // Tracks whether this word is hidden from view
    private bool _isHidden;

    /// <summary>
    /// Constructor - Creates a new word that is initially visible
    /// </summary>
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    /// <summary>
    /// Hides this word from view (for memorization practice)
    /// </summary>
    public void Hide()
    {
        _isHidden = true;
    }

    /// <summary>
    /// Shows this word (reveals the text)
    /// </summary>
    public void Show()
    {
        _isHidden = false;
    }

    /// <summary>
    /// Checks if this word is currently hidden
    /// </summary>
    public bool IsHidden()
    {
        return _isHidden;
    }

    /// <summary>
    /// Returns the display text for this word
    /// Hidden words display as "____", visible words show the actual text
    /// </summary>
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "____";
        }
        else
        {
            return _text;
        }
    }
 
}