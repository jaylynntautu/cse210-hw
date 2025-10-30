using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // EXCEED REQUIREMENTS:
        // I added a list of some of my favorite Book of Mormon scriptures.
        // The program chooses one at random instead of using only one scripture.


        List<Scripture> library = new List<Scripture>()
        {
            new Scripture(
                new Reference("1 Nephi", 3, 7),
                "I will go and do the things which the Lord hath commanded..."
            ),

            new Scripture(
                new Reference("Mosiah", 2, 17),
                "When ye are in the service of your fellow beings ye are only in the service of your God."
            ),

            new Scripture(
                new Reference("Alma", 37, 6),
                "By small and simple things are great things brought to pass."
            ),

            new Scripture(
                new Reference("Ether", 12, 27),
                "If men come unto me I will show unto them their weakness..."
            )
        };

        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine("All words are hidden. Good job!");
    }
}
