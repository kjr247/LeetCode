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
    public class UnitTestProblem20
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        public string[] GenerateTestData()
        {
            string[] testData = [
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

            return testData;
        }

        //[Time]
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var IV =  new Problem20();
        //    const string str = "()";
        //    var result = IV.IsValid(str);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    var IV = new Problem20();
        //    const string str = "()[]{}";
        //    var result = IV.IsValid(str);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    var IV = new Problem20();
        //    const string str = "(]";
        //    var result = IV.IsValid(str);
        //    Assert.AreEqual(false, result);
        //}

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