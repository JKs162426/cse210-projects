using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSumary());


        MathAssignment assignment2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSumary());
        Console.WriteLine(assignment2.GetHomeWorkList());

        WritingAssignment assignment3 = new WritingAssignment("Mary Water", "European History", "The Cause of World War II by Mary Waters");
        Console.WriteLine(assignment3.GetSumary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}