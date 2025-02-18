using System;

public class CyclingActivity : Activity
{
    public CyclingActivity(int distance, int minutes) : base (distance, minutes)
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
        return $"Cycling {base.GetStringRepresentation()}";
    }
}