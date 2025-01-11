using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine($"What is the magic number? {magicNumber}");
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        int guessValue = int.Parse(guess);
        int guessCount = 1;

        while (guessValue != magicNumber)
        {
            guessCount = guessCount + 1;
            if (guessValue > magicNumber)
            {
                Console.WriteLine("Lower");
                guess = Console.ReadLine();
                guessValue = int.Parse(guess);
            }
            else if (guessValue < magicNumber)
            {
                Console.WriteLine("Higher");
                guess = Console.ReadLine();
                guessValue = int.Parse(guess);
            }
        }
        Console.WriteLine("You guessed it!");
        Console.WriteLine($"Total attemps: {guessCount}");
    }
}