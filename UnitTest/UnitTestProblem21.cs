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
    public class UnitTestProblem21
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
* Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
* Use[TestInitialize] to run code before each and every test in the class where the method is defined.
* decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
*/

        public string[] GenerateTestData()
        {
            string[] testData = [];

            return testData;
        }

        //[Time]
        //[TestMethod]
        //public void TestMethod1()
        //{
        //    var list1 = new Problem21.ListNode();
        //    var list2 = new Problem21.ListNode();
        //    var problem =  new Problem21();
        //    const string str = "()";
        //    var result = problem.MergeTwoLists(list1, list2);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    var list1 = new Problem21.ListNode();
        //    var list2 = new Problem21.ListNode();
        //    var problem = new Problem21();
        //    const string str = "()[]{}";
        //    var result = problem.MergeTwoLists(list1, list2);
        //    Assert.AreEqual(true, result);
        //}

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    var list1 = new Problem21.ListNode();
        //    var list2 = new Problem21.ListNode();
        //    var problem = new Problem21();
        //    const string str = "(]";
        //    var result = problem.MergeTwoLists(list1, list2);
        //    Assert.AreEqual(false, result);
        //}
    }
}