using System;
using System.Collections.Generic;

public class ListingActivity : Activities
{   
    List<string> _prompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(5);
        GetRandomPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetList();
        }
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Console.WriteLine($"\n--- {prompt} ---");
        Console.WriteLine("\nYou may begin in:");
        ShowCountdown(5);
    }
    public void GetList()
    {   
        Console.Write("> ");
        Console.ReadLine();
    }
}