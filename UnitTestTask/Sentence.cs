using System;
using System.Collections.Generic;
using System.Text;

namespace WordsInSentence
{
    public class Sentence
    {

        public LongestWord FindLongestWord(string phrase)
        {
            LongestWord longestWord = new LongestWord();

            if (phrase is null)
            {
                throw new ArgumentNullException(nameof(phrase));
            }

            string[] words = phrase.Split(new char[] { ' ', ',', '.', '-' });

            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord.Length = word.Length;
                    longestWord.Word = word;
                }
            }
            return longestWord;
        }


        public ShortestWord FindShortestWord(string phrase)
        {
            ShortestWord shortestWord = new ShortestWord();

            if (phrase is null)
            {
                throw new ArgumentNullException(nameof(phrase));
            }

            phrase = phrase.TrimEnd();

            string[] words = phrase.Split(new char[] { ' ', ',', '.', '-' });

            foreach (var word in words)
            {
                if (word.Length < shortestWord.Length)
                {
                    shortestWord.Length = word.Length;
                    shortestWord.Word = word;
                }
            }
            return shortestWord;
        }
    }
}
