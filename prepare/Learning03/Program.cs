using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(3, 4);
        

        // // Display the initial fractions
        // Console.WriteLine("Initial fractions");
        // Console.WriteLine($"frac1: {frac1.GetFractionString()}");
        // Console.WriteLine($"frac2: {frac2.GetFractionString()}");
        // Console.WriteLine($"frac3: {frac3.GetFractionString()}");

        // // Test the setters
        // frac1.SetTop(7);
        // frac1.SetBottom(8);
        // frac2.SetTop(4);
        // frac2.SetBottom(5);
        // frac3.SetTop(6);
        // frac3.SetBottom(7);

        // // Display the fractions after using the setters
        // Console.WriteLine("Fraction after using setter");
        // Console.WriteLine($"frac1: {frac1.GetFractionString()}");
        // Console.WriteLine($"frac2: {frac2.GetFractionString()}");
        // Console.WriteLine($"frac3: {frac3.GetFractionString()}");

        // // Test the getters
        // Console.WriteLine($"frac1 numerator: {frac1.GetTop()}");
        // Console.WriteLine($"frac1 denominator: {frac1.GetBottom()}");

        // Console.WriteLine($"frac2 numerator: {frac2.GetTop()}");
        // Console.WriteLine($"frac2 denominator: {frac2.GetBottom()}");

        // Console.WriteLine($"frac3 numerator: {frac3.GetTop()}");
        // Console.WriteLine($"frac3 denominator: {frac3.GetBottom()}");


        Console.WriteLine(frac1.GetFractionString());
        Console.WriteLine(frac1.GetDecimalValue());

        Console.WriteLine(frac2.GetFractionString());
        Console.WriteLine(frac2.GetDecimalValue());

        Console.WriteLine(frac3.GetFractionString());
        Console.WriteLine(frac3.GetDecimalValue());

        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine(frac4.GetFractionString());
        Console.WriteLine(frac4.GetDecimalValue());

    }
}