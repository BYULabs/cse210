using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity(new DateTime(2026, 04, 3), 30, 3.0),
            new CyclingActivity(new DateTime(2026, 04, 04), 45, 12.0),
            new SwimmingActivity(new DateTime(2026, 04, 05), 40, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}