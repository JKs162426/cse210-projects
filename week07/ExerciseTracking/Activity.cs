using System;

public class Activity
{
    private double _distance;
    private int _minutes;

    public Activity(double distance, int minutes)
    {
        _distance = distance;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public void SetMinutes(int minutes)
    {
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return Math.Round(_distance, 2);
    }

    public virtual double GetSpeed()
    {
        return Math.Round(_distance / _minutes, 2);
    }

    public virtual double GetPace()
    {
        return Math.Round(_minutes / _distance, 2);
    }

    public virtual string GetStringRepresentation()
    {   
        return $"({_minutes} min) - Distance: {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}