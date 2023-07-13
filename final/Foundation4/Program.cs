using System;
namespace Foundation4;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        activities.Add(running);

        Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 20);
        activities.Add(cycling);

        Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 10);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}