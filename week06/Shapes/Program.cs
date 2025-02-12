using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.Clear();

        Square square = new Square();
        square.SetColor("Orange");
        square.SetSide(8);
        square.GetArea();

        Rectangle rectangle = new Rectangle();
        rectangle.SetColor("Red");
        rectangle.SetLenght(5.5);
        rectangle.SetWidth(7);

        Circle circle = new Circle();
        circle.SetColor("Pink");
        circle.SetRadius(15.8);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape sh in shapes)
        {   
            string color = sh.GetColor();
            Console.WriteLine($"Color {color} and Area {sh.GetArea()}");
        }
    }
}