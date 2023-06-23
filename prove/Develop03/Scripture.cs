namespace Develop03;
   public class Scripture
    {
        private List<Word> _verses;

        public Scripture()
        {
            _verses = new List<Word>();
        }

        public void AddVerse(string reference, string text)
        {
            var words = text.Split(' ');

            foreach (var word in words)
            {
                var verse = new Word(reference, word);
                _verses.Add(verse);
            }
        }

        public int GetVerseCount()
        {
            return _verses.Count;
        }

        public int GetHiddenVerseCount()
        {
            return _verses.Count(v => v.Hidden);
        }

        public Word GetRandomHiddenVerse()
        {
            var hiddenVerses = _verses.Where(v => v.Hidden).ToList();
            var random = new Random();
            var index = random.Next(hiddenVerses.Count);
            return hiddenVerses[index];
        }

        public void HideWordsInVerse(Word verse, int wordCountToHide)
        {
            var hiddenWords = new List<Word>();
            var random = new Random();

            while (hiddenWords.Count < wordCountToHide)
            {
                var availableWords = _verses.Where(v => v.Reference == verse.Reference && !v.Hidden).ToList();

                if (availableWords.Count == 0)
                    break;

                var index = random.Next(availableWords.Count);
                var word = availableWords[index];

                word.Hidden = true;
                hiddenWords.Add(word);
            }
        }

        public void DisplayScripture()
        {
            var groupedVerses = _verses.GroupBy(v => v.Reference);

            foreach (var group in groupedVerses)
            {
                var verseText = string.Join(" ", group.Select(v => v.Hidden ? new string('_', v.Text.Length) : v.Text));
                Console.WriteLine($"{group.Key}: {verseText}");
            }
        }
    }