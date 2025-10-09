namespace Develop02;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>() {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };


    public void Write()
    {
        Entry ent = new Entry();
        ent._date = DateTime.Now.ToShortDateString();
        ent._prompt = Prompt();
        ent._journal = Console.ReadLine();
        _entries.Add(ent);
    }

    public string Prompt()
    {
        Random rand = new Random();
        string promp = _prompts[rand.Next(0, _prompts.Count - 1)];
        Console.WriteLine(promp);
        Console.Write("> ");
        return promp;
    }

    public void Display()
    {
        foreach (Entry ent in _entries)
        {
            ent.Display();
        }
    }

    
    


    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry ent in _entries)
            {
                outputFile.WriteLine(ent.toFileString());
            }
        }
    }

    public void Load(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] split = line.Split("%!%");
            _entries.Add(Entry.buildFromFile(split));
        }
    }
}