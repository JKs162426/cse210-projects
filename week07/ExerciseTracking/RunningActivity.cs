using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class RunningActivity : Activity
{
    public RunningActivity(int distance, int minutes) : base (distance, minutes)
    {

    }

    public override double GetDistance()
    {
        return base.GetDistance();
    }

    public override double GetSpeed()
    {
        return base.GetSpeed();
    }

    public override double GetPace()
    {
        return base.GetPace();
    }

    public override string GetStringRepresentation()
    {
        return $"Running {base.GetStringRepresentation()}";
    }
}