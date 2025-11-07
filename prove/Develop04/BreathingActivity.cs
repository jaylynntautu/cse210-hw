using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing", 
        "This activity will help you relax by guiding you through slow breathing.") {}

    public void Run()
    {
        StartActivity();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            PauseCountdown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            PauseCountdown(4);
            Console.WriteLine();
        }

        EndActivity();
    }
}
