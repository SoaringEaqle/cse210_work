using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        int last = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter a number: ");
            last = int.Parse(Console.ReadLine());
            if (last == 0)
            {
                break;
            }
            num.Add(last);
        } 

        int total = 0;
        int largest = 0;
        for (int i = 0; i < num.Count - 1; i++)
        {
            total += num[i];
            if (num[i] > largest)
            { 
                largest = num[i];
            }
        }
        
        float ave = total / (float)num.Count;
        
        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {ave}");
        Console.WriteLine($"The largest number is {largest}");
    }
}