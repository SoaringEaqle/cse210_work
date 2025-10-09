namespace Develop02;

public class Entry
{
    public string _prompt;
    public string _journal;
    public string _date;
    
    

    public static Entry buildFromFile(string[] fileLine)
    {
        Entry ret = new Entry();

        ret._date = fileLine[0];
        ret._prompt = fileLine[1];
        ret._journal = fileLine[2];

        return ret;
    }

    public string toFileString()
    {
        string ret = _date + "%!%" + _prompt + "%!%" + _journal;
        return ret;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - Prompt: {_prompt}");
        Console.WriteLine($"> {_journal}");
        Console.WriteLine();
    }

}