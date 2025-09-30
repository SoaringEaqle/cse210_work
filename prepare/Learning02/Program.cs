using System;
using Learning02;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._company = "Apple";
        job1._startYear = 2000;
        job1._endYear = 2010;
        job2._jobTitle = "Development Lead";
        job2._company = "Electronic Arts";
        job2._startYear = 2010;
        job2._endYear = 2020;
       
        Resume resume = new Resume();
        resume._name = "Camden Nair";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}