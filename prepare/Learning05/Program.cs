using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 5);

        
        Rectangle rectangle = new Rectangle ("Green", 5, 6);

       

        Circle circle = new Circle("White", 3);

        

        List<Shape> shapes = [square, rectangle, circle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");

        }


    }
}
