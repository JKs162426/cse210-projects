using System;

public class BreathingActivity : Activities
{   
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
 
    }
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {   
        _name = "Breathing Activity";
        _description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {   
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready");
        ShowSpinner(3);
        Thread.Sleep(_duration * 1000);
        Console.Clear();
        DisplayEndingMessage();
        Thread.Sleep(3000);

    }
}