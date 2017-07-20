using System;
using NUnit.Framework;
using PrimeString;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject
{
    [TestFixture]
    public class KataUnitTest
    {

        [Test]
        public void BasicTests()
        {
            var kata = new Kata();

            Assert.AreEqual(true, kata.PrimeString("abac"));

            Assert.AreEqual(false, kata.PrimeString("abab"));

            Assert.AreEqual(false, kata.PrimeString("aaaa"));

            Assert.AreEqual(true, kata.PrimeString("x"));

            Assert.AreEqual(true, kata.PrimeString("abc"));

            Assert.AreEqual(false, kata.PrimeString("fdsyffdsyffdsyffdsyffdsyf"));

            Assert.AreEqual(true, kata.PrimeString("utdutdtdutd"));

            Assert.AreEqual(true, kata.PrimeString("abba"));
        }

    }
}
