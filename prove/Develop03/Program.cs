// I included a library of scriptures to my program, for the scripture to be selected at random.
using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Add some scriptures to the library
        library.AddScripture(new Scripture(new Reference("Genesis", 1, 1), "In the beginning God created the heavens and the earth."));
        library.AddScripture(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        library.AddScripture(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all of thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."));
        library.AddScripture(new Scripture(new Reference("Psalm", 27, 1, 3), "The Lord is my light and my salvation; Whom shall i fear? The Lord is the strength of my life; Of whom shall i be afraid? When the wicked came against me to eat my flesh, my enemies and foes, they stumbled and fell. Though an army may encamp against me, My heart shall not fear; Though war may rise against me, in this i will be confident"));
        library.AddScripture(new Scripture(new Reference("Alma", 38, 14), "Do not say: O God, I thank thee that we are better than our brethren; but rather say; O Lord, forgive my unworthiness, and remember my brethren in mercy--yea, acknowledge your unworthiness before God at all times.."));
        library.AddScripture(new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."));
        library.AddScripture(new Scripture(new Reference("Mosiah", 2, 17), "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in service of your fellow beings ye are only in the service of God."));
        
        Scripture randomScripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(randomScripture.GetDisplayText());

            if (randomScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            randomScripture.HideRandomWords(3); // Hides 3 random words each iteration
        }

    }
}