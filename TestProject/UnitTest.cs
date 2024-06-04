using Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject
{
    public class UnitTest
    {
        [TestClass]
        public class NumberConverterTests
        {
            [TestMethod]
            public void ToBaseFive_ValidNumber_ReturnsCorrectResult()
            {
                int number = 10;
                string expected = "20";
                string actual = NumberConverter.ToBaseFive(number);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ToBaseFive_AnotherValidNumber_ReturnsCorrectResult()
            {
                int number = 25;
                string expected = "100";
                string actual = NumberConverter.ToBaseFive(number);
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ToBaseFive_LargeNumber_ReturnsCorrectResult()
            {
                int number = 625;
                string expected = "10000";
                string actual = NumberConverter.ToBaseFive(number);
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void ToBaseFive_SmallestValidNumber_ReturnsCorrectResult()
            {
                int number = 1;
                string expected = "1";
                string actual = NumberConverter.ToBaseFive(number);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
