using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("\nHow many seconds would you like to spend on this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nGet ready...");
        PauseSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"You completed {_duration} seconds of the {_name} Activity.");
        PauseSpinner(3);
    }

    protected void PauseSpinner(int time)
    {
        DateTime end = DateTime.Now.AddSeconds(time);
        string[] frames = { "/", "-", "\\", "|" };
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(frames[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % frames.Length;
        }
    }

    protected void PauseCountdown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
