using System;

namespace Develop03
{
     public class Word
    {

        private string _text;

        public string Reference { get; set; }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public bool Hidden { get; set; }

        public Word(string reference, string text)
        {
            Reference = reference;
            Text = text;
            Hidden = false;
        }
    }
}