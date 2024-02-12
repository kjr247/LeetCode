using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace UnitTest
{
    [TestClass]
    public class UnitTestProblemThree
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "III";
            var result = ProblemThree.RomanToInt(str);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string str = "LVIII";
            var result = ProblemThree.RomanToInt(str);
            Assert.AreEqual(58, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string str = "MCMXCIV";
            var result = ProblemThree.RomanToInt(str);
            Assert.AreEqual(1994, result);
        }

    }
}