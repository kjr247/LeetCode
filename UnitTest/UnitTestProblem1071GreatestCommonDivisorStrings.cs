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
    public class UnitTestProblem1071GreatestCommonDivisorStrings
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        [TestMethod]
        public void TestMethod1()
        {
            var MSA =  new Problem1071GreatestCommonDivisorStrings();
            string str1 = "ABCABC", str2 = "ABC";
            var result = MSA.GcdOfStrings(str1, str2);
            Assert.AreEqual("ABC", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var MSA = new Problem1071GreatestCommonDivisorStrings();
            string str1 = "ABABAB", str2 = "ABAB";
            var result = MSA.GcdOfStrings(str1, str2);
            Assert.AreEqual("AB", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var MSA = new Problem1071GreatestCommonDivisorStrings();
            string str1 = "LEET", str2 = "CODE";
            var result = MSA.GcdOfStrings(str1, str2);
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var MSA = new Problem1071GreatestCommonDivisorStrings();
            string str1 = "ABCDEF", str2 = "ABC";
            var result = MSA.GcdOfStrings(str1, str2);
            Assert.AreEqual("", result);
        }
    }
}