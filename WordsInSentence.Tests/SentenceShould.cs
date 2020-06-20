using System;
using Xunit;

namespace WordsInSentence.Tests
{
    public class SentenceShould
    {
        // Longest Word Tests

        [Fact]
        public void ReturnLongestWord()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("The cow jumped joyfully over the moon");

            Assert.Equal("joyfully", result.Word);
        }

        [Fact]
        public void ReturnLongestWordLength()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("The cow jumped joyfully over the moon");

            Assert.Equal(8, result.Length);
        }

        [Fact]
        public void ReturnFirstLongestWordWhenMoreThanOneLongest()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("The cow jumps over the sandy beach");

            Assert.Equal("jumps", result.Word);
        }

        [Fact]
        public void ReturnEmptyLongestWordWhenEmptySentence()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("");

            Assert.Equal("", result.Word);
        }

        [Fact]
        public void ReturnZeroLongestWordLengthWordWhenEmptySentence()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("");

            Assert.Equal(0, result.Length);
        }

        [Fact]
        public void ReturnLongestWordContainingSpecialCharacters()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("The !@#$%^&*()_+={}[]:;'<>?/`~\"\\ jumped joyfully over the moon");

            Assert.Equal("!@#$%^&*()_+={}[]:;'<>?/`~\"\\", result.Word);
        }

        [Fact]
        public void ReturnLongestWordIngnoringMultipleAdjoiningSpaces()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("The                  jumped");

            Assert.Equal("jumped", result.Word);
        }

        [Fact]
        public void ReturnLongestWordContainingNumbers()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("T123he C0vv is ok");

            Assert.Equal("T123he", result.Word);
        }

        [Fact]
        public void ReturnLongestWordFromLongSentence()
        {
            Sentence sentence = new Sentence();

            LongestWord result = sentence.FindLongestWord("Lorem ipsum dolor sit amet consecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsectetur adipiscing elit Mauris porta consequat mauris et maximus dui pellentesque ac Curabitur dapibus mi nec orci pharetra efficitur Fusce eget magna enim. Nulla ultricies augue sed arcu mollis malesuada Nullam at feugiat turpis Nam enim libero, mollis ultricies accumsan non, venenatis nec erat Vivamus rhoncus massa ac consequat lacinia Proin ac sollicitudin metus Nunc mi arcu imperdiet et dictum a condimentum et purus Praesent interdum lectus ac ultrices auctor orci nisi fermentum tellus nec blandit dui lectus a quam Maecenas faucibus sit amet mauris id auctor Etiam blandit nibh vel lobortis elementum Nulla faucibus ");

            Assert.Equal("consecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsecteturconsectetur", result.Word);
        }


        // Shortest Word Tests

        [Fact]
        public void ReturnShortestWord()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("The cow jumped joyfully over me");

            Assert.Equal("me", result.Word);
        }

        [Fact]
        public void ReturnShortestWordLength()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("I jumped over the cow");

            Assert.Equal(1, result.Length);
        }

        [Fact]
        public void ReturnFirstShortestWordWhenMoreThanOneLongest()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("The cow jumps over the sandy beach");

            Assert.Equal("The", result.Word);
        }

        [Fact]
        public void ReturnEmptyShortestWordWhenEmptySentence()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("");

            Assert.Equal("", result.Word);
        }

        [Fact]
        public void ReturnZeroShortestWordLengthWordWhenEmptySentence()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("");

            Assert.Equal(0, result.Length);
        }

        [Fact]
        public void ReturnShortestWordContainingSpecialCharacters()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("Loremipsumdolorsitametconsecteturadipiscingelitportaconsequat !@#$%^&*()_+={}[]:;'<>?/`~\"\\");

            Assert.Equal("!@#$%^&*()_+={}[]:;'<>?/`~\"\\", result.Word);
        }

        [Fact]
        public void ReturnShortestWordContainingNumbers()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("The 2 cows jumper over moon");

            Assert.Equal("2", result.Word);
        }

        [Fact]
        public void ReturnShortestWordIgnoringSpacesAtTheEnd()
        {
            Sentence sentence = new Sentence();

            ShortestWord result = sentence.FindShortestWord("Amazing glittering cattle jumps   ");

            Assert.Equal("jumps", result.Word);
        }

        // Null Exception Tests

        [Fact]
        public void NotAllowNullInput()
        {
            Sentence sentence = new Sentence();

            Assert.Throws<ArgumentNullException>(() => sentence.FindLongestWord(null));
        }
    }
}