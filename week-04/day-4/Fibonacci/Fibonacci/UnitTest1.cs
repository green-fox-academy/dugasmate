using NUnit.Framework;

namespace Fibonacci
{
    [TestFixture]
    public class UnitTest1
    {
        Fibonacci szamoldki = new Fibonacci();
        [TestCase]
        public void FibonacciTen()
        {

            Assert.AreEqual(55, szamoldki.Fibonaccer(10));

        }
        [TestCase]
        public void FibonacciOne()
        {

            Assert.AreEqual(1, szamoldki.Fibonaccer(1));

        }
        [TestCase]
        public void FibonacciTwo()
        {

            Assert.AreEqual(1, szamoldki.Fibonaccer(2));

        }
        [TestCase]
        public void FibonacciNegative()
        {

            Assert.AreEqual(0, szamoldki.Fibonaccer(-100));

        }
        [TestCase]
        public void FibonacciZero()
        {

            Assert.AreEqual(0, szamoldki.Fibonaccer(0));

        }

    }
}
