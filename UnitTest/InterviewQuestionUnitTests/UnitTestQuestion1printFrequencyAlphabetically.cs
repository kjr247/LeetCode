using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Bogus;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using UnitTest.TestData;
using MethodTimer;
using LeetCode.InterviewQuestions;

namespace UnitTest
{
    [TestClass]
    public class UnitTestQuestion1printFrequencyAlphabetically
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        public string GenerateTestData()
        {
            string testData = "";

            return testData;
        }

        [Time]
        [TestMethod]
        public void TestMethod1()
        {
            var IV = new PrintAlphabeticalWithFrequency();
            const string str = "Hello";
            var result = IV.printFrequencyAlphabetically(str);
            Assert.AreEqual("e1h1l2o1", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var IV = new PrintAlphabeticalWithFrequency();
            const string str = "zHelloasdfqwer";
            var result = IV.printFrequencyAlphabetically(str);
            Assert.AreEqual("a1d1e2f1h1l2o1q1r1s1w1z1", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var IV = new PrintAlphabeticalWithFrequency();
            const string str = "h";
            var result = IV.printFrequencyAlphabetically(str);
            Assert.AreEqual("h1", result);
        }

    }
}