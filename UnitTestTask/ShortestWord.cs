using System;
using System.Collections.Generic;
using System.Text;

namespace WordsInSentence
{
    public class ShortestWord
    {
        public ShortestWord()
        {
            Length = int.MaxValue;
            Word = "Default";
        }

        public int Length;
        public string Word;
    }
}
