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
    public class UnitTestProblem1768MergeStringsAlternately
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        [TestMethod]
        public void TestMethod1()
        {
            var MSA =  new Problem1768MergeStringsAlternately();
            string str1 = "abc";
            string str2 = "pqr";
            var result = MSA.MergeAlternately(str1, str2);
            Assert.AreEqual("apbqcr", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var MSA = new Problem1768MergeStringsAlternately();
            string str1 = "ab";
            string str2 = "pqrs";
            var result = MSA.MergeAlternately(str1, str2);
            Assert.AreEqual("apbqrs", result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var MSA = new Problem1768MergeStringsAlternately();
            string str1 = "abcd";
            string str2 = "pq";
            var result = MSA.MergeAlternately(str1, str2);
            Assert.AreEqual("apbqcd", result);
        }

        //[TestMethod]
        //public void TestMethod4()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        string str1 = "abc";
        string str2 = "pqr";
        //    var result = MSA.MergeAlternately(strs);
        //    Assert.AreEqual("aa", result);
        //}

        //[TestMethod]
        //public void TestMethod5()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //string str1 = "abc";
        //string str2 = "pqr";
        //    var result = MSA.MergeAlternately(strs);
        //    Assert.AreEqual("", result);
        //}

        //[TestMethod]
        //public void TestMethod6()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //    var TDGenerator = new UnitTest.TestData.Problem1768MergeStringsAlternatelyTestDataGenerator();
        //    var TestData = TDGenerator.GenerateArrayOfStrings(); // using this generated data, we can run it hundreds or thousands of times to discover edge cases.
        //    var result = MSA.MergeAlternately(TestData.AllStrings);
        //    Assert.AreEqual("aaaaaaaaaaaaaaaa", result);
        //}

        //[TestMethod]
        //public void MergeAlternately2TestMethod7()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //string str1 = "abc";
        //string str2 = "pqr";
        //    var result = MSA.MergeAlternately2(strs);
        //    Assert.AreEqual("fl", result);
        //}

        //[TestMethod]
        //public void MergeAlternately2TestMethod8()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //    ring[] strs = "dog", "racecar", "car";
        //    ring[] strs = "dog", "racecar", "car";
        //    var result = MSA.MergeAlternately2(strs);
        //    Assert.AreEqual("", result);
        //}

        //[TestMethod]
        //public void MergeAlternately2TestMethod9()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //    ring[] strs = "a";
        //    ring[] strs = "a";
        //    var result = MSA.MergeAlternately2(strs);
        //    Assert.AreEqual("a", result);
        //}

        //[TestMethod]
        //public void MergeAlternately2TestMethod10()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //    ring[] strs = "aaa", "aa", "aaa";
        //    ring[] strs = "aaa", "aa", "aaa";
        //    var result = MSA.MergeAlternately2(strs);
        //    Assert.AreEqual("aa", result);
        //}

        //[TestMethod]
        //public void MergeAlternately2TestMethod11()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //    ring[] strs = "reflower", "flow", "flight";
        //    ring[] strs = "reflower", "flow", "flight";
        //    var result = MSA.MergeAlternately2(strs);
        //    Assert.AreEqual("", result);
        //}

        //[TestMethod]
        //public void MergeAlternately2TestMethod12()
        //{
        //    var MSA = new Problem1768MergeStringsAlternately();
        //    var TDGenerator = new UnitTest.TestData.Problem1768MergeStringsAlternatelyTestDataGenerator();
        //    var TestData = TDGenerator.GenerateArrayOfStrings(); // using this generated data, we can run it hundreds or thousands of times to discover edge cases.
        //    var result = MSA.MergeAlternately2(TestData.AllStrings);
        //    Assert.AreEqual("aaaaaaaaaaaaaaaa", result);
        //}
    }
}