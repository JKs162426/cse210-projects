using System;

public class Activities
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public Activities()
    {

    }

    public Activities(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"\nThis activity will help you {_description}");
        Console.WriteLine("\nHow long, seconds, would you like for your session?");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {   
        Console.WriteLine("\nWell done!");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}");
        Thread.Sleep(5000);
    }

    public void DisplayMenu()
    {   
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine("Select a choise a choice from the menu: ");
    }

    public void ShowSpinner(int seconds)
    {

        List<string> animation = new List<string> {"|", "/", "-", "\\"};
        //List<string> animation = new List<string> {"🔵", "🟢", "🟡", "🔴"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in animation)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}