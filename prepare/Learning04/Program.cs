using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        MathAssignment test = new MathAssignment("Words Name", "Topic", "1.4", "6-10 Evens");
        Console.WriteLine(test.GetSummary());
        Console.WriteLine(test.GetHomeworkList());


        WritingAssignment test1 = new WritingAssignment("Words Name", "Topic", "Essay Title");
        Console.WriteLine(test1.GetSummary());
        Console.WriteLine(test1.GetWritingInformation());

        
    }

}