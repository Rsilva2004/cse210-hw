// Exceeding requirements: the program randomly chooses a scripture
// from a small scripture library each time it starts.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetReferenceText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}

