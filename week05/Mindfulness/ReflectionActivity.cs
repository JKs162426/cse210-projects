using System;

public class ReflectionActivity : Activities
{
    List<string> _prompts = new List<string>();
    private int _count;

    public ReflectionActivity()
    {
        
    }

    public ReflectionActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
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

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}