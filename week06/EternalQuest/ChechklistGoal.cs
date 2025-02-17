using System;

public class ChecklistGoal : Goal
{   
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetTarget()
    {
        return _target;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {   
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            if (_amountCompleted >= _target)
            {
                GetBonus();
            }
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetdetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return $"{base.GetStringRepresentation()} -- Currently completed: {_amountCompleted}/{_target}";
    }
}