using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                break;
            }

            numbers.Add(userNumber);
        }
        Console.WriteLine();
        
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        
        Console.WriteLine($"The sum is: {sum}");
        
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number  is: {max}");

        // Stretch challenge 1
        int min = numbers[0];

        foreach (int number  in numbers)
        {
            if ((number < min) && (number > 0))
            {
                min = number;
            }
        }
        Console.WriteLine($"The smallest positive number  is: {min}");

        // Stretch challenge 2
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}