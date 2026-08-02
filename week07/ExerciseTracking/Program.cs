using System;

class Program
{
    static void Main(string[] args)
    {
       Running run = new Running("03 Nov 2022", 30, 4.8);
        Cycling cycle = new Cycling("04 Nov 2022", 45, 20.0);
        Swimming swim = new Swimming("05 Nov 2022", 25, 20);

        List<Activity> activities = new List<Activity> { run, cycle, swim };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
    }
