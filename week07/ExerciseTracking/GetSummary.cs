using System;
using System.Collections.Generic;
using System.Security.AccessControl;

public class GetSummary
{
    private List<Activity> _activities = new List<Activity>();

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public void GetSummaryActivities()
    {   
        DateTime dateTime = DateTime.Now;
        foreach (var act in _activities)
        {   
            Console.WriteLine($"\n{dateTime.ToString("dd MMM yyyy")} {act.GetStringRepresentation()}");
        }
    }
}