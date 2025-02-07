using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Activities activity1 = new Activities();
        string userInput = "";

        while (userInput != "4")
        {   
            activity1.DisplayMenu();
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
            BreathingActivity activity = new BreathingActivity();
            activity.Run();
            }

            else if (userInput == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }

            else if (userInput == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        }

    }
}