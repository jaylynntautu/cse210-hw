using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber, birthYear);
    }

    // --- Function 1 ---
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // --- Function 2 ---
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // --- Function 3 ---
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // --- Function 4 ---
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    // --- Function 5 ---
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // --- Function 6 ---
    static void DisplayResult(string name, int squared, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, the square of your number is {squared}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}
