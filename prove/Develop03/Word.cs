using System;

namespace Develop03
{
     public class Word
    {
        public string Reference { get; set; }
        public string Text { get; set; }
        public bool Hidden { get; set; }

        public Word(string reference, string text)
        {
            Reference = reference;
            Text = text;
            Hidden = false;
        }
    }
}