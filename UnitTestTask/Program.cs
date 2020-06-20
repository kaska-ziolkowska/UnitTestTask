using System;

namespace WordsInSentence
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi! Please write a sentence and I will do the calculations: ");
            // instantiating new instance of class Sentence
            Sentence sentence = new Sentence();

            // passing the variable - to be tested
            string input = Console.ReadLine();

            LongestWord longestWord = sentence.FindLongestWord(input);
            ShortestWord shortestWord = sentence.FindShortestWord(input);

            Console.WriteLine("The longest word has " + longestWord.Length + " characters");
            Console.WriteLine("The longest word is: " + longestWord.Word);
            Console.WriteLine("The shortest word has " + shortestWord.Length + " characters");
            Console.WriteLine("The shortest word is: " + shortestWord.Word);
            Console.ReadKey();
        }
    }
}
