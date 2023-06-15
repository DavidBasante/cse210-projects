using System;
namespace Develop03;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Scripture Memorize \n");

        var scripture = new Scripture();

        // Adicione aqui os versículos da escritura
        scripture.AddVerse("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.WriteLine("Press Enter to hide words. Type 'quit' to quit.");
        Console.ReadLine();

        var wordCountToHide = 3; // Quantidade de palavras a serem ocultadas em cada versículo

        while (scripture.GetHiddenVerseCount() < scripture.GetVerseCount())
        {
            Console.Clear();
            var verse = scripture.GetRandomHiddenVerse();
            scripture.HideWordsInVerse(verse, wordCountToHide);
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide more words. Type 'quit' to quit.");
            var userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;
        }
    }
}