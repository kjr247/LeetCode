using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Bogus;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using UnitTest.TestData;
using MethodTimer;

namespace UnitTest
{
    [TestClass]
    public class UnitTestProblem151ReverseWordsInAString
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            // Initalization code goes here
            TestData = GenerateTestData();
        }

        public static string[] TestData { get; set; }
        public static string[] GenerateTestData()
        {
            string[] testData = [
                "the sky is blue",
                "  hello world  ",
                "a good   example"
            ];

            return testData;
        }

        [Time]
        [TestMethod]
        public void TestMethod1()
        {
            var IV = new Problem151ReverseWordsInAString();
            string str = TestData[0];
            var result = IV.ReverseWords(str);
            Assert.AreEqual("blue is sky the", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var IV = new Problem151ReverseWordsInAString();
            string str = TestData[1];
            var result = IV.ReverseWords(str);
            Assert.AreEqual("world hello", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var IV = new Problem151ReverseWordsInAString();
            string str = TestData[2];
            var result = IV.ReverseWords(str);
            Assert.AreEqual("example good a", result);
        }

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    var IV = new Problem20();
        //    const string str = "{[]}";
        //    var result = IV.IsValid(str);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod5()
        //{
        //    var IV = new Problem20();
        //    const string str = "((";
        //    var result = IV.IsValid(str);
        //    Assert.AreEqual(false, result);
        //}
    }
}