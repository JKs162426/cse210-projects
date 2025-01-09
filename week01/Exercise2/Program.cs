using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int intValue = int.Parse(grade);
        string letter = "";

        if (intValue >= 90)
        {
            letter = "A";
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (intValue >= 80)
        {
            letter = "B";
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (intValue >= 70)
        {
            letter = "C";
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (intValue >= 60)
        {
            letter = "D";
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            letter = "F";
            Console.WriteLine($"Your grade is {letter}");
        }

        if (intValue > 70)
        {
            Console.WriteLine("Congratulations!");
        }
        else 
        {
            Console.WriteLine("Keep going. You can do it better next time.");
        }
    }
}