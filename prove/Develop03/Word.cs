public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void SetHidden(bool hidden)
    {
        _hidden = hidden;
    }
    public bool IsHidden()
    {
        return _hidden;
    }

    public string GetHidableWord()
    {
        string ret = "";
        if (_hidden)
        {
            for (int i = 0; i < _word.Length; i++)
            {
                //Leave puncuation alone.
                switch (_word[i])
                {
                    case '.':
                    case ',':
                    case ';':
                    case ':':
                        ret += _word[i];
                        break;
                    default:
                        ret += "_";
                        break;
                }
            }
        }
        else
        {
            ret = _word;
        }
        return ret;
    }

    public string GetWord()
    {
        return _word;
    }
}