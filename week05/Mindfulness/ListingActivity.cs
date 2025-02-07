using System;

public class ListingActivity : Activities
{   
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    public ListingActivity()
    {
        
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
        Thread.Sleep(_duration * 1000);
        Console.Clear();
        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {

    }
    public void GetList()
    {

    }
}