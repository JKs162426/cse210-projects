using System;

public class SwimmingActivity : Activity
{   
    private int _laps;
    public SwimmingActivity(int laps, double distance, int minutes) : base (distance, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
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
        return $"Swimming {base.GetStringRepresentation()}";
    }
}