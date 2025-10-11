using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int ask = 0;
        bool isSaved = true;
        
        
        while(ask < 5)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new Entry\n2. Display your Journal Entries\n3. Load a Journal\n4. Save your Journal\n5. Quit program");
            Console.Write("Please select an option: ");
            ask = int.Parse(Console.ReadLine());
            if (ask == 1)
            {
                journal.Write();
                isSaved = false;
            }
            else if (ask == 2)
            {
                journal.Display();
            }
            else if (ask == 3)
            {
                Console.Write("What is the filename? ");
                journal.Load(Console.ReadLine());
            }
            else if (ask == 4)
            {
                Console.Write("What is the filename? ");
                journal.Save(Console.ReadLine());
                isSaved = true;
                
            }
            Console.WriteLine();
        } 

        
        if (!isSaved)
        {
            Console.Write("Your journal is not saved.\nWould you like to save your journal? ");
            bool yes;
            switch(Console.ReadLine())
            {
                case "yes":
                case "true":
                case "Yes" :
                case "True":
                case "TRUE":
                    yes = true;
                    break;
                default:
                    yes = false;
                    break;
            }
            if (yes)
            {
                Console.WriteLine("What is the Filename?");
                journal.Save(Console.ReadLine());
            }
        }
        
        Console.WriteLine("You have successfully quit the journal\n\tThank You");
    }
}