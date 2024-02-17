using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace UnitTest
{
    [TestClass]
    public class UnitTestProblem9
    {
        [TestMethod]
        public void TestMethod1()
        {
            int num = 121;
            var result = Problem9.IsPalindrome(num);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int num = -121;
            var result = Problem9.IsPalindrome(num);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int num = 10;
            var result = Problem9.IsPalindrome(num);
            Assert.AreEqual(false, result);
        }


        [TestMethod]
        public void TestMethod4()
        {
            int num = 11;
            var result = Problem9.IsPalindrome(num);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            int num = 1001;
            var result = Problem9.IsPalindrome(num);
            Assert.AreEqual(true, result);
        }
    }
}