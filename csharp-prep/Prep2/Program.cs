using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string inp = Console.ReadLine();
        int percentage = int.Parse(inp);

        string letter;
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if(percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "F")
        {
            if (percentage >= 40)
            {
                letter += "+";
            }
            else if (percentage <= 20)
            {
                letter += "-";
            }
        }
        else if (percentage % 10 >= 7 || percentage == 100)
        {
            letter += "+";
        }
        else if (percentage % 10 < 3)
        {
            letter += "-";
        }
        
        Console.WriteLine($"Your grade is {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Good Job!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}