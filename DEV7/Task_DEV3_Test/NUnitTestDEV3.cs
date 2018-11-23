using System;
using NUnit.Framework;
using DEV7;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTesTransferRadix
    {
        TransferRadix test = new TransferRadix();

        [TestCase("-2147483647", "19", "-27C57H32")]
        [TestCase("2147483647", "20", "1DB1F927")]
        [TestCase("10", "2", "1010")]
        [TestCase("-10", "11", "-A")]
        [TestCase("0", "11", "0")]
        [Test]
        public void TestTransferValueToAnotherNumberSystem(string decimalValue, string radix, string result)
        {
            string tests = test.TransferValueToAnotherNumberSystem(decimalValue, radix);
            Assert.AreEqual(tests, result);
        }
    }
    [TestFixture]
    public class NUnitTesCheckInput
    {
        CheckInput check = new CheckInput();
        [TestCase("", "", false)]
        [TestCase("3","", false)]
        [TestCase("", "2", false)]
        [TestCase("2147483647", "2", true)]
        [TestCase("-2147483648", "11", true)]
        [TestCase("543", "20", true)]
        [TestCase("0", "11", true)]
        [TestCase("255", "1", false)]
        [TestCase("255", "-1", false)]
        [TestCase("255", "21", false)]
        [Test]
        public void TestCheckForCorrectInput(string decimalValue, string radix, bool result)
        {
           
            bool checks = check.CheckForCorrectInput(decimalValue, radix); 
            Assert.AreEqual(checks, result);
        }

    }
}