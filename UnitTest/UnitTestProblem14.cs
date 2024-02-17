using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace UnitTest
{
    [TestClass]
    public class UnitTestProblem14
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] strs = ["flower", "flow", "flight"];
            var result = Problem14.LongestCommonPrefix(strs);
            Assert.AreEqual("fl", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string[] strs = ["dog", "racecar", "car"];
            var result = Problem14.LongestCommonPrefix(strs);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string[] strs = ["a"];
            var result = Problem14.LongestCommonPrefix(strs);
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string[] strs = ["aaa", "aa", "aaa"];
            var result = Problem14.LongestCommonPrefix(strs);
            Assert.AreEqual("aa", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string[] strs = ["reflower", "flow", "flight"];
            var result = Problem14.LongestCommonPrefix(strs);
            Assert.AreEqual("", result);
        }
        
    }
}