using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("Dec 1", 30, 3.0),
            new Cycling("Dec 2", 45, 15.0),
            new Swimming("Dec 3", 60, 20)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetDate()} Activity:");
            Console.WriteLine($"Distance: {activity.GetDistance():0.0} miles");
            Console.WriteLine($"Speed: {activity.GetSpeed():0.0} mph");
            Console.WriteLine($"Pace: {activity.GetPace():0.0} min per mile");
            Console.WriteLine();
        }
    }
}
