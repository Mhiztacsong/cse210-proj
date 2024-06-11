using System;
using System.IO.Compression;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string userInput = Console.ReadLine();

        int percent = int.Parse(userInput);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //stretch challange 1      
        string sign = "";

        float lastDigit = percent % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // stretch challenge 2
        if (percent >= 93)
        {
            sign = "";
        }

        // stretch challenge 3
        if (letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations!!, You've passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry you'd have to retake the course. Better luck next time.");
        }
        
        

    }
}