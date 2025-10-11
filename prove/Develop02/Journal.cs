namespace Develop02;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>(){
        "What was I most looking forward to today, and how did it turn out?",
        "What was the best part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "Who was the most interesting person I talked to today?",
        "What memories did I make today that I will always remember?"
    };
    
    
    
    public void Write()
    {
        Entry ent = new Entry();
        DateTime dt = DateTime.Now;
        ent._date = dt.ToShortDateString() + " " + dt.ToShortTimeString();
        ent._prompt = Prompt();
        ent._journal = Console.ReadLine();
        _entries.Add(ent);
        Console.Write("Entry added");
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
        filename.Trim();
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry ent in _entries)
            {
                outputFile.WriteLine(ent.toFileString());
            }
        }
        Console.WriteLine($"Your journal has been saved to {filename}.");
    }

    public void Load(string filename)
    {
        if (string.IsNullOrEmpty(filename))
        {
            return;
        }
        
        filename.Trim();
        
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] split = line.Split("%!%");
                _entries.Add(Entry.buildFromFile(split));
            }
            
            Console.WriteLine("File successfully loaded.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File \"{filename}\" cannot be found. Please try again.");
            Console.Write("What is the filename? ");
            Load(Console.ReadLine());
        }
    }
}