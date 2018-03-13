
using NUnit.Framework;

namespace Apple
{
    [TestFixture]
    public class AppleTest
    {
        [TestCase]

        public void GetAppleTest()
        {
            Apple starking = new Apple();
            Assert.AreEqual("szotyi", starking.GetApple());

        }
    }
}
