using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Scripture getScripture = new Scripture();
        string entry = "";

        while (entry != "quit")
        {   
            Console.Clear();
            Console.WriteLine(getScripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finsish.");
            entry = Console.ReadLine();
            if (entry == "quit")
            {
                break;
            }
            getScripture.HideRandomNumber();
            Console.WriteLine(getScripture.GetDisplayText());

            if (getScripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}