using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2012;
        job1._endYear = 2020;


        Job job2 = new Job();
        job2._jobTitle = "Full Stack Developer";
        job2._company = "Apple";
        job2._startYear = 2016;
        job2._endYear = 2023;

        
        Console.WriteLine();

        Resume myResume = new Resume();
        myResume._name = "Johnson Nsisong";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}