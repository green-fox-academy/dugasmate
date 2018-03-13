
using NUnit.Framework;
using System.Collections.Generic;

namespace Sum
{
    [TestFixture]
    public class UnitTest1
    {
        Sumko summa = new Sumko();

        [TestCase]
        public void SummaTest1()
        {

            List<int> numbers = new List<int>() { 5, 5 };
            Assert.AreEqual(10, summa.Summer(numbers));
        }
        [TestCase]
        public void SummaTest2()
        {

            List<int> numbers = new List<int>() { 1, 1, 1, 1, 6 };
            Assert.AreEqual(10, summa.Summer(numbers));
        }
        [TestCase]
        public void SummaTest0()
        {

            List<int> numbers = new List<int>() { };
            Assert.AreEqual(0, summa.Summer(numbers));
        }

    }
}
