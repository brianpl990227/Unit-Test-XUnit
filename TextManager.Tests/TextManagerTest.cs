using System.Text.RegularExpressions;

namespace TextManager.Tests
{
    public class TextManagerTest
    {
        [Theory]
        [InlineData("Hola Mundo", 2)]
        [InlineData("", 0)]
        [InlineData("Saludos desde mi proyecto de pruebas", 6)]
        public void CountWords(string text, int expected)
        {
            var textManager = new TextManager(text);

            var result = textManager.CountWords();

            Assert.Equal(expected, result);


        }

        [Theory]
        [ClassData(typeof(TextManagerClassData))]//Es lo mismo que InlineData lo que permite prepar datos mas complejos
        public void CountWords_ClassData(string text, int expected)
        {
            var textManager = new TextManager(text);

            var result = textManager.CountWords();

            Assert.Equal(expected, result);

        }

        [Fact]
        public void CountWords_NoZero()
        {
            var textManager = new TextManager("Texto");

            var result = textManager.CountWords();

            Assert.NotEqual(0, result);

        }

        [Fact]
        public void FindWord()
        {
            var textManager = new TextManager("probando probando 1 2 3");

            var result = textManager.FindWord("probando", true);
            
            Assert.NotEmpty(result);
            Assert.Contains(0, result); 
            Assert.Contains(9, result);

        }

        [Fact]
        public void FindWord_Empty()
        {
            var textManager = new TextManager("probando probando 1 2 3");

            var result = textManager.FindWord("brian", true);

            Assert.Empty(result);

        }

        [Fact]
        public void FindExactWord()
        {
            var textManager = new TextManager("probando probando 1 2 3");


            Assert.ThrowsAny<Exception>(() => textManager.FindExactWord(null, true));
        }



    }
}