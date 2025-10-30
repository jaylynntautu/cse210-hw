using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the constructors
        Fraction f1 = new Fraction();          // 1/1
        Fraction f2 = new Fraction(6);         // 6/1
        Fraction f3 = new Fraction(6, 7);      // 6/7

        // Display each fraction and decimal value
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Test getters and setters
        f3.SetTop(3);
        f3.SetBottom(4);

        Console.WriteLine(f3.GetFractionString());   // Should show 3/4
        Console.WriteLine(f3.GetDecimalValue());     // Should show 0.75
    }
}
