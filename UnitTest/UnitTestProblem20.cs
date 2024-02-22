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

        [TestMethod]
        public void TestMethod1()
        {
            var IV =  new Problem20();
            string str = "()";
            var result = IV.IsValid(str);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var IV = new Problem20();
            string str = "()[]{}";
            var result = IV.IsValid(str);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var IV = new Problem20();
            string str = "(]";
            var result = IV.IsValid(str);
            Assert.AreEqual(false, result);
        }

        
        [TestMethod]
        public void TestMethod4()
        {
            var IV = new Problem20();
            string str = "{[]}";
            var result = IV.IsValid(str);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var IV = new Problem20();
            string str = "((";
            var result = IV.IsValid(str);
            Assert.AreEqual(false, result);
        }
        

        //[TestMethod]
        //public void TestMethod6()
        //{
        //    var IV = new Problem20();
        //    var TDGenerator = new UnitTest.TestData.Problem20TestDataGenerator();
        //    var TestData = TDGenerator.GenerateArrayOfStrings(); // using this generated data, we can run it hundreds or thousands of times to discover edge cases.
        //    var result = IV.IsValid(TestData.AllStrings);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void.IsValid2TestMethod7()
        //{
        //    var IV = new Problem20();
        //    string str = "flower";
        //    var result = IV.IsValid2(str);
        //    Assert.AreEqual(truel", result);
        //}

        //[TestMethod]
        //public void.IsValid2TestMethod8()
        //{
        //    var IV = new Problem20();
        //    string str = "dog";
        //    var result = IV.IsValid2(str);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void.IsValid2TestMethod9()
        //{
        //    var IV = new Problem20();
        //    string str = "a";
        //    var result = IV.IsValid2(str);
        //    Assert.AreEqual(true", result);
        //}

        //[TestMethod]
        //public void.IsValid2TestMethod10()
        //{
        //    var IV = new Problem20();
        //    string str = "aaa";
        //    var result = IV.IsValid2(str);
        //    Assert.AreEqual(truea", result);
        //}

        //[TestMethod]
        //public void.IsValid2TestMethod11()
        //{
        //    var IV = new Problem20();
        //    string str = "reflower";
        //    var result = IV.IsValid2(str);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void.IsValid2TestMethod12()
        //{
        //    var IV = new Problem20();
        //    var TDGenerator = new UnitTest.TestData.Problem20TestDataGenerator();
        //    var TestData = TDGenerator.GenerateArrayOfStrings(); // using this generated data, we can run it hundreds or thousands of times to discover edge cases.
        //    var result = IV.IsValid2(TestData.AllStrings);
        //    Assert.AreEqual(trueaaaaaaaaaaaaaaa", result);
        //}
    }
}