
using NUnit.Framework;
using System.Collections.Generic;

namespace Extension
{
    [TestFixture]
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Test]
        public void TestAdd_2and3is5()
        {
            Assert.AreEqual(5, extension.Add(2, 3));
        }

        [Test]
        public void TestAdd_3and3is6()
        {
            Assert.AreEqual(6, extension.Add(3, 3));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            Assert.AreEqual(5, extension.Add(1, 4));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(5, extension.MaxOfThree(5, 4, 3));
        }

        [Test]
        public void TestMaxOfThree_Second()
        {
            Assert.AreEqual(5, extension.MaxOfThree(3, 5, 3));
        }


        [Test]
        public void TestMaxOfThree_Third()
        {
            Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
        }
        [Test]
        public void TestMaxOfThree_All()
        {
            Assert.AreEqual(5, extension.MaxOfThree(5, 5, 5));
        }
        public void TestMaxOfThree_TwoSame()
        {
            Assert.AreEqual(5, extension.MaxOfThree(4, 4, 5));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Test]
        public void TestIsVowel_A()
        {
            Assert.True(extension.IsVowel('A'));
        }

        [Test]
        public void TestIsVowel_I()
        {
            Assert.True(extension.IsVowel('I'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual("lavagovopuvus", extension.Translate("lagopus"));
        }

        [Test]
        public void testTranslate_Magzat()
        {
            Assert.AreEqual("mavagzavat", extension.Translate("magzat"));
        }
    }
}