

public class Scripture
{
    private Reference _ref;
    private List<Word> _verse = new List<Word>();

    public Scripture(Reference refer, string verse)
    {
        _ref = refer;
        string[] verseSplit = verse.Split(" ");
        foreach (string word in verseSplit)
        {
            _verse.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Write(_ref.GetRef() + " ");
        string verse = "";
        foreach (Word word in _verse)
        {
            verse += word.GetHidableWord();
            verse += " ";
        }
        Console.WriteLine(verse);
    }

    public bool WordsAllHidden()
    {
        foreach (Word word in _verse)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void HideNext()
    {
        if (WordsAllHidden())
        {
            return;
        }
        int hideSuccess = 0;
        while (hideSuccess < 3)
        {
            Random random = new Random();
            int ind = random.Next(0, _verse.Count());
            if (!_verse[ind].IsHidden())
            {
                _verse[ind].SetHidden(true);
                hideSuccess++;
            }
            if (WordsAllHidden())
            {
                return;
            }
        }
    }
    
    public string StorageString()
    {
        string ret = _ref.StorageString();
        ret += "$%$";
        foreach(Word word in _verse)
        {
            ret += word.GetWord() + " ";
        }
        return ret;
    }
}