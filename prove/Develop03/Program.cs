using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        string filename = "scripturefile.txt";
        string[] values = System.IO.File.ReadAllLines(filename);

        string scriptString = values[new Random().Next(0, values.Length)];

        string[] parts = scriptString.Split("$%$");
        string[] refParts = parts[0].Split("~%~");

        Reference reference;
        if (refParts.Length > 3)
        {
            reference = new Reference(refParts[0], int.Parse(refParts[1]), int.Parse(refParts[2]), int.Parse(refParts[3]));
        }
        else
        {
            reference = new Reference(refParts[0], int.Parse(refParts[1]), int.Parse(refParts[2]));
        }

        Scripture script = new Scripture(reference, parts[1]);



        while (true)
        {
            Console.Clear();
            script.Display();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type \'quit\' to exit");

            string sub = Console.ReadLine();
            if (sub.Equals("quit"))
            {
                break;
            }
            // Sneaky Development Mode. Use this to add or remove scriptures

            else if (sub.Equals("dev"))
            {
                sub = Console.ReadLine();
                if (sub.Equals("new"))
                {
                    Console.Write("Book: ");
                    string book = Console.ReadLine();
                    Console.Write("Chapter: ");
                    int chap = int.Parse(Console.ReadLine());
                    Console.Write("Begin Verse: ");
                    int beg = int.Parse(Console.ReadLine());
                    Console.Write("End Verse: ");
                    string temp = Console.ReadLine();
                    Reference newRef;
                    if (string.IsNullOrEmpty(temp))
                    {
                        newRef = new Reference(book, chap, beg);
                    }
                    else
                    {
                        newRef = new Reference(book, chap, beg, int.Parse(temp));
                    }
                    Console.WriteLine("Verse:");
                    Scripture newScript = new Scripture(newRef, Console.ReadLine());



                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        foreach (string value in values)
                        {
                            outputFile.WriteLine(value);
                        }
                        outputFile.WriteLine(newScript.StorageString());
                    }
                    values = System.IO.File.ReadAllLines(filename);
                }
                else if (sub.Equals("remove"))
                {
                    Console.Write("Scripture");
                    int num = int.Parse(Console.ReadLine());

                    for (int i = 0; i < values.Length; i++)
                    {
                        if (i == num)
                        {
                            continue;
                        }
                        using (StreamWriter outputFile = new StreamWriter(filename))
                        {
                            outputFile.WriteLine(values[i]);
                        }
                    }
                    values = System.IO.File.ReadAllLines(filename);
                }
            }
            else if (script.WordsAllHidden())
            {
                break;
            }
            else
            {
                script.HideNext();
            }
        }
    }
}