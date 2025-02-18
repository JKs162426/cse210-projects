using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        RunningActivity act1 = new RunningActivity(40, 450);
        RunningActivity act2 = new RunningActivity(26, 380);

        SwimmingActivity act3 = new SwimmingActivity(6, 12, 10);
        SwimmingActivity act4 = new SwimmingActivity(10, 4, 15);

        CyclingActivity act5 = new CyclingActivity(20, 30);
        CyclingActivity act6 = new CyclingActivity(24, 27);


        GetSummary summary = new GetSummary();
        summary.AddActivity(act1);
        summary.AddActivity(act2);
        summary.AddActivity(act3);
        summary.AddActivity(act4);
        summary.AddActivity(act5);
        summary.AddActivity(act6);

        summary.GetSummaryActivities();
    }
}