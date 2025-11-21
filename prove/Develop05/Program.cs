using System;

/*
CREATIVITY / EXCEEDING REQUIREMENTS:
I added a simple LEVEL-UP feature to make it motivating and fun.
For example Every time the user reaches a multiple of 1000 points,
 a “LEVEL UP” message is displayed.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int lastLevel = 0;

        while (true)
        {
            Console.WriteLine("\n==============================");
            Console.WriteLine($"🏆 Your current score: {manager.GetScore()}");
            Console.WriteLine("==============================");

            int currentLevel = manager.GetScore() / 1000;
            if (currentLevel > lastLevel)
            {
                Console.WriteLine("\n🚀🎉 LEVEL UP! Keep going!");
                lastLevel = currentLevel;
            }

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.DisplayGoals();
            }
            else if (choice == "3")
            {
                manager.RecordEvent();
            }
            else if (choice == "4")
            {
                manager.SaveGoals();
            }
            else if (choice == "5")
            {
                manager.LoadGoals();
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }
}
