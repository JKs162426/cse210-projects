using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        Activities activity1 = new Activities();
        int userInput = 0;
        int activityCount = -1;

        while (userInput != 4)
        {   
            activityCount ++;
            activity1.DisplayMenu();
            userInput = int.Parse(Console.ReadLine());
            Console.Clear();

            if (userInput == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }

            else if (userInput == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }

            else if (userInput == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if(userInput >= 5)
            {
                Console.WriteLine("Invalid option. Please enter a number between 1 and 4.");
                Thread.Sleep(3000);
            }
        }
        if (activityCount > 0)
        {
            Console.WriteLine($"You did {activityCount} activities today!");
            Thread.Sleep(1000);
            Console.WriteLine("\nWell done!");
            Thread.Sleep(1000);
            Console.WriteLine("\nHave a great day!");
        }
        else
        {
            Console.WriteLine("It looks like you didn't complete any activity this time.");
            Thread.Sleep(1000);
            Console.WriteLine("\nWe look forward to seeing you soon so that you can continue to strengthen your well-being!");
        }

    }
}