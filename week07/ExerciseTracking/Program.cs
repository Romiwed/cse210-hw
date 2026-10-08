using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("08 Oct 2026", 30, 5.0));
        activities.Add(new Cycling("08 Oct 2026", 45, 18.0));
        activities.Add(new Swimming("08 Oct 2026", 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}