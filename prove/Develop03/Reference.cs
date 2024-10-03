public class Reference
{
    private string _book;
    private int _chapter;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _endVerse = verse;
    }

    public Reference(string book, string chapter, int startVerse, int endVerse)
    {

    }
    public string GetDisplayText()
    {
        return $"In {_book}, Chapter {_chapter}, Verses {_endVerse} through {_endVerse}";

    }
}
