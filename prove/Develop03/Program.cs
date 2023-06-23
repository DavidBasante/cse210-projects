using System;
using System.Collections.Generic;
using System.Linq;

namespace Develop03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var scripture = new Scripture();
            scripture.AddVerse("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            scripture.AddVerse("Proverbs 3:5-6", "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

            Console.Clear();
            scripture.DisplayScripture();

            while (scripture.GetHiddenVerseCount() < scripture.GetVerseCount())
            {
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                var input = Console.ReadLine();

                if (input == "quit")
                    break;

                Console.Clear();
                var verse = scripture.GetRandomHiddenVerse();
                scripture.HideWordsInVerse(verse, 2);
                scripture.DisplayScripture();
            }
       }
   }
}