using System;
namespace Foundation1;
class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);

        Console.WriteLine("Radius: " + circle.GetRadius());
        Console.WriteLine("Area: " + circle.CalculateArea());

    }
}