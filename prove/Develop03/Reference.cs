public class Reference
{
    private string _book;
    private int _chapter;
    private int _begVerse;
    private int _endVerse;
    public Reference(string book, int chap, int begVerse)
    {
        _book = book;
        _chapter = chap;
        _begVerse = begVerse;
        _endVerse = begVerse;
    }
    public Reference(string book, int chap, int begVerse, int endVerse)
    {
        _book = book;
        _chapter = chap;
        _begVerse = begVerse;
        _endVerse = endVerse;
    }

    public string GetRef()
    {
        string verseRange;
        if (_endVerse == _begVerse)
        {
            verseRange = _begVerse.ToString();
        }
        else
        {
            verseRange = _begVerse.ToString() + "-" + _endVerse.ToString();
        }
        return $"{_book} {_chapter}: {verseRange}";
    }

    
    public string StorageString()
    {
        string ret = _book;
        ret += "~%~" + _chapter + "~%~" + _begVerse;
        if (_endVerse != _begVerse)
        {
            ret += "~%~" + _endVerse;
        }
        return ret;
    }
}