using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        Thread.Sleep(1500);
        Console.Clear();

        GoalManager manager = new GoalManager();

        while (true)
        {   
            manager.Start();
            var userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                manager.CreateGoal();
            }
            else if (userInput == 2)
            {
                manager.ListGoalDetails();
            }
            else if (userInput == 3)
            {
                Console.WriteLine("Enter the name of the file to save the goals:");
                string fileName = Console.ReadLine();
                manager.SaveGoals(fileName);
            }
            else if (userInput == 4)
            {
                Console.WriteLine("Enter the name of the file to load the goals from:");
                string fileName = Console.ReadLine();
                manager.LoadGoals(fileName);
            }
            else if (userInput == 5)
            {
                manager.RecordEvent();
            }
            else if(userInput == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please enter a number between 1 and 6");
            }
        }
    }
}