using NUnit.Framework;

namespace AnagramTest
{
    [TestFixture]
    public class UnitTest1
    {
        Anagram annagramm = new Anagram();


        [TestCase]
        public void TestAnagramFalse()
        {

            string firstWord = "szotyi";
            string secondWord = "szotyi";
            Assert.IsTrue(annagramm.IsAnagram(firstWord,secondWord));
        }
        [TestCase]
        public void TestAnagramTrue()
        {

            string firstWord = "szotyi";
            string secondWord = "iszoty";
            Assert.IsTrue(annagramm.IsAnagram(firstWord, secondWord));
        }
    }
}
