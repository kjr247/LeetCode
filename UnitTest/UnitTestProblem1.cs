using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace UnitTest
{
    [TestClass]
    public class UnitTestProblem1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;
            var result = Problem1.TwoSum(nums, target);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = [3, 2, 4];
            int target = 6;
            var result = Problem1.TwoSum(nums, target);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int[] nums = [3, 3];
            int target = 6;
            var result = Problem1.TwoSum(nums, target);
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}