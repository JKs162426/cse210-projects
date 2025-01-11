using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        int sum = 0;

        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        foreach (int numbersInList in numbers)
        {
            sum += numbersInList;
        }
        int largestNumber = numbers.Max();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/(numbers.Count - 1)}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }    
}
