using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // Create a reference for John 3:16
        Reference scriptureReference = new Reference("John", 3, 16);

        // Create a scripture with the reference and text
        Scripture scripture = new Scripture(scriptureReference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide more words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            // Hide 3 random words
            scripture.HideRandomWords(3);

            // If all words are hidden, end the program
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden. You've memorized the scripture!");
                break;
            }
        }
    }
}
