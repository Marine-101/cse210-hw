
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Exceeds core requirements:
        // The program uses a library of three scriptures instead of a single scripture.
        // It randomly selects a scripture from the library for the user to memorize.
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"));

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"));

        scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ which strengtheneth me"));

        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int index = random.Next(scriptures.Count);
            Scripture scripture = scriptures[index];

            while (!scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine("Visible words remaining: " +
                    scripture.GetVisibleWordCount());
                Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");

                string input = Console.ReadLine();

                if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    return;
                }

                scripture.HideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("All words are hidden!");

            Console.WriteLine("Memorize another scripture? (yes/no)");
            string answer = Console.ReadLine();

            if (answer.ToLower() != "yes")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Great job practicing!");
    }
}
