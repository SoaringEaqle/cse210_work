using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        List<int> myList = new List<int>();
        myList.Add(10);
        myList.Add(20);
        myList.Add(30);

        int count = myList.Count();

        Console.WriteLine($"The count is {count}");

        int total = 0;

        foreach (int item in myList)
        {
            total += item;
        }
    }
}