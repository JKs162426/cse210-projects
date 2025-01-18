using System;
using System.IO;

class Program
{ 
   static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        int choice = 0;
        Journal journal = new Journal();
        while (choice != 5)
        {   
            journal.DisplayOptionsMenu();
            choice = int.Parse(Console.ReadLine());
            
            // Write option
            if (choice == 1)
            {
                PromptGenerator randomPrompt = new PromptGenerator();
                string prompt = randomPrompt.GetRandomPrompt();
                Console.WriteLine(prompt);
                string userEntry = Console.ReadLine();
                journal.AddEntry(prompt, userEntry);
            }

            // Display option
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }

            //Load option
            else if (choice == 3)
            {   
                Console.WriteLine("Enter the name of the file to load the journal from:");
                string fileName = Console.ReadLine();
                journal.LoadEntry(fileName);
            }

            // Save option
            else
            {  
                Console.WriteLine("Enter the name of the file to save the journal:");
                string fileName = Console.ReadLine();
                journal.SaveEntry(fileName);
            }
        }


    }
}