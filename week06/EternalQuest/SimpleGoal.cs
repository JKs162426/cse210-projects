using System;

public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string name, string description, string points, bool isComplete) : base(name, description, points)
    {
        _IsComplete = isComplete;
    }

    public override void RecordEvent()
    {
        GetPoints();
        _IsComplete = true;
    }

    public override bool IsComplete()
    {
        return _IsComplete;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}