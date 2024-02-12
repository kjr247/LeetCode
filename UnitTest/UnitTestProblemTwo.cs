using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace UnitTest
{
    [TestClass]
    public class UnitTestProblemTwo
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 121;
            var result = ProblemTwo.IsPalindrome(num);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = -121;
            var result = ProblemTwo.IsPalindrome(num);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int num = 10;
            var result = ProblemTwo.IsPalindrome(num);
            Assert.AreEqual(false, result);
        }
    }
}