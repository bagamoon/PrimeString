using System;
using NUnit.Framework;
using PrimeString;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject
{
    [TestFixture]
    public class KataUnitTest
    {

        [TestCase("abac", true, TestName = "Input_abac_Should_Return_True")]
        [TestCase("abab", false, TestName = "Input_ab-ab_Should_Return_False")]
        [TestCase("aaaa", false, TestName = "Input_a-a-a-a_Should_Return_False")]
        [TestCase("x", true, TestName = "Input_x_Should_Return_True")]
        [TestCase("abc", true, TestName = "Input_abc_Should_Return_True")]
        /*[TestCase("fdsyffdsyffdsyffdsyffdsyf", false, TestName = "Input_fdsyf-fdsyf-fdsyf-fdsyf-fdsyf_Should_Return_False")]
        [TestCase("utdutdtdutd", true, TestName = "Input_utdutdtdutd_Should_Return_True")]
        [TestCase("abba", true, TestName = "Input_abba_Should_Return_True")]*/
        public void BasicTests(string input, bool expected)
        {
            var kata = new Kata();
            Assert.AreEqual(expected, kata.PrimeString(input));
        }

    }
}
