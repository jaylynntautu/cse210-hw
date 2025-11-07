using System;

class Program
{
    // EXTRA CREDIT: Count how many total activities the user completes.
    static int _totalRuns = 0;

    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
                _totalRuns++;
            }
            else if (choice == 2)
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
                _totalRuns++;
            }
            else if (choice == 3)
            {
                ListingActivity l = new ListingActivity();
                l.Run();
                _totalRuns++;
            }
            else if (choice == 4)
            {
                Console.WriteLine($"\nYou completed {_totalRuns} total activities today.");
                Console.WriteLine("Goodbye!");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
