using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "What are things that make you happy?"
    };

    public ListingActivity()
        : base("Listing",
        "This activity will help you reflect by listing as many positive things as you can.")
    { }

    public void Run()
    {
        StartActivity();
        Random rand = new Random();

        Console.WriteLine("\nList responses to the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nBegin in:");
        PauseCountdown(5);

        List<string> responses = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {responses.Count} items!");
        EndActivity();
    }
}
