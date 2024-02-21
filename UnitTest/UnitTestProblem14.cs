using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Bogus;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using UnitTest.TestData;

namespace UnitTest
{
    [TestClass]
    public class UnitTestProblem14
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        public string[] GenerateTestData()
        {
            string[] strs = [
    "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasdfhjkl",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
                "aaaaaaaaaaaaaaaasdfhjkaaaaal",
            ];


            //var f = new Faker();
            //var size = 1;
            //TestData = f.Random.WordsArray(count: size);

            

            return strs;
        }

        [TestMethod]
        public void TestMethod1()
        {
            var LCP =  new Problem14();
            string[] strs = ["flower", "flow", "flight"];
            var result = LCP.LongestCommonPrefix(strs);
            Assert.AreEqual("fl", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var LCP = new Problem14();
            string[] strs = ["dog", "racecar", "car"];
            var result = LCP.LongestCommonPrefix(strs);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var LCP = new Problem14();
            string[] strs = ["a"];
            var result = LCP.LongestCommonPrefix(strs);
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var LCP = new Problem14();
            string[] strs = ["aaa", "aa", "aaa"];
            var result = LCP.LongestCommonPrefix(strs);
            Assert.AreEqual("aa", result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var LCP = new Problem14();
            string[] strs = ["reflower", "flow", "flight"];
            var result = LCP.LongestCommonPrefix(strs);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var LCP = new Problem14();
            var TDGenerator = new UnitTest.TestData.Problem14TestDataGenerator();
            var TestData = TDGenerator.GenerateArrayOfStrings(); // using this generated data, we can run it hundreds or thousands of times to discover edge cases.
            var result = LCP.LongestCommonPrefix(TestData.AllStrings);
            Assert.AreEqual("aaaaaaaaaaaaaaaa", result);
        }

        [TestMethod]
        public void LongestCommonPrefix2TestMethod7()
        {
            var LCP = new Problem14();
            string[] strs = ["flower", "flow", "flight"];
            var result = LCP.LongestCommonPrefix2(strs);
            Assert.AreEqual("fl", result);
        }

        [TestMethod]
        public void LongestCommonPrefix2TestMethod8()
        {
            var LCP = new Problem14();
            string[] strs = ["dog", "racecar", "car"];
            var result = LCP.LongestCommonPrefix2(strs);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void LongestCommonPrefix2TestMethod9()
        {
            var LCP = new Problem14();
            string[] strs = ["a"];
            var result = LCP.LongestCommonPrefix2(strs);
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void LongestCommonPrefix2TestMethod10()
        {
            var LCP = new Problem14();
            string[] strs = ["aaa", "aa", "aaa"];
            var result = LCP.LongestCommonPrefix2(strs);
            Assert.AreEqual("aa", result);
        }

        [TestMethod]
        public void LongestCommonPrefix2TestMethod11()
        {
            var LCP = new Problem14();
            string[] strs = ["reflower", "flow", "flight"];
            var result = LCP.LongestCommonPrefix2(strs);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void LongestCommonPrefix2TestMethod12()
        {
            var LCP = new Problem14();
            var TDGenerator = new UnitTest.TestData.Problem14TestDataGenerator();
            var TestData = TDGenerator.GenerateArrayOfStrings(); // using this generated data, we can run it hundreds or thousands of times to discover edge cases.
            var result = LCP.LongestCommonPrefix2(TestData.AllStrings);
            Assert.AreEqual("aaaaaaaaaaaaaaaa", result);
        }
    }
}