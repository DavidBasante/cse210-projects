namespace Develop03;
    public class Scripture
    {
    private List<Word> verses; // Lista de versiculos

    public Scripture()
    {
        verses = new List<Word>();
    }

    public void AddVerse(string reference, string text)
    {
        var verse = new Word(reference, text);
        verses.Add(verse);
    }

    public int GetVerseCount()
    {
        return verses.Count;
    }

    public int GetHiddenVerseCount()
    {
        return verses.Count(v => v.Hidden);
    }

    public Word GetRandomHiddenVerse()
    {
        var hiddenVerses = verses.Where(v => v.Hidden).ToList();
        var random = new Random();
        var index = random.Next(hiddenVerses.Count);
        return hiddenVerses[index];
    }

    public void HideWordsInVerse(Word verse, int wordCountToHide)
    {
        var words = verse.Text.Split(' ');
        var hiddenWords = new List<string>();
        var random = new Random();

        while (hiddenWords.Count < wordCountToHide)
        {
            var index = random.Next(words.Length);
            var word = words[index];

            if (!hiddenWords.Contains(word))
            {
                hiddenWords.Add(word);
                words[index] = new string('_', word.Length);
            }
        }

        verse.Text = string.Join(' ', words);
    }

    public void DisplayScripture()
    {
        foreach (var verse in verses)
        {
            Console.WriteLine($"{verse.Reference}: {verse.Text}");
        }
    }
}