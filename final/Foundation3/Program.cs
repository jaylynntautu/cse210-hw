using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address a2 = new Address("45 Beach Rd", "Apia", "Upolu", "Samoa");
        Address a3 = new Address("99 Palm Ave", "Pago Pago", "Tutuila", "American Samoa");

        Lecture lecture = new Lecture("Island History", "Cultural roots of Samoa", "Dec 15", "6 PM", a1, "Dr. Tupu", 100);
        Reception reception = new Reception("Family Reunion", "RSVP required for headcount", "Dec 20", "2 PM", a2, "rsvp@family.com");
        OutdoorGathering outdoor = new OutdoorGathering("Luau Celebration", "Outdoor feast and dances", "Dec 25", "5 PM", a3, "Sunny");

        Event[] events = { lecture, reception, outdoor };

        foreach (Event e in events)
        {
            Console.WriteLine("----- Standard -----");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine("\n----- Full -----");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine("\n----- Short -----");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n");
        }
    }
}
