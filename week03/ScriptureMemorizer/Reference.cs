/// <summary>
/// Reference class - Represents a scripture reference (book, chapter, verse)
/// Supports both single verses (e.g., "John 3:16") and verse ranges (e.g., "3 Nephi 1:15-31")
/// </summary>
public class Reference
{
    // The book name (e.g., "John", "1 Nephi", "Alma")
    private string _book;
    
    // The chapter number
    private int _chapter;
    
    // The starting verse number
    private int _verse;
    
    // The ending verse number (same as _verse for single verses)
    private int _endVerse;

    /// <summary>
    /// Constructor for a single verse reference
    /// </summary>
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    /// <summary>
    /// Constructor for a verse range reference
    /// </summary>
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    /// <summary>
    /// Returns the formatted display text of the reference
    /// Single verse: "John 3:16"
    /// Verse range: "1 Nephi 3:7-10"
    /// </summary>
    public string GetDisplayText()
    {
        if (_endVerse == _verse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
    
}