using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Johnson Nsisong", "Surd");
        Console.WriteLine(assignment.GetSummary() + "\n");

        

        MathAssignment mathAssignment = new MathAssignment("Victor Oshimen", "Quadratic equation", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList() + "\n");

        WritingAssignment writingAssignment = new WritingAssignment("Ibinabo MacDede", "African History", "The Causes of the Civil War in Nigeria by Ibinabo MacDede");
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}