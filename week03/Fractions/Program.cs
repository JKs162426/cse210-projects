using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction = new Fraction(2,8);
        fraction.GetTop();
        fraction.GetBottom();

        string stringValue = fraction.GetFractionString();
        Console.WriteLine(stringValue);
        double decimalValue = fraction.GetDecimalValue();
        Console.WriteLine(decimalValue);

    }
}