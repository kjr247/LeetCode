using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Bogus;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using UnitTest.TestData;
using MethodTimer;
using static LeetCode.Problems.Problem232ImplementQueueUsingStacks;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class UnitTestProblem232ImplementQueueUsingStacks
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        //[AssemblyInitialize]
        //public static void AssemblyInit(TestContext context)
        //{
        //    // Initalization code goes here
        //    TestData = GenerateTestData();
        //}

        //public static string[][] TestData { get; set; }
        //public static string[][] GenerateTestData()
        //{
        //    string[][] testData = [
        //        ["MyQueue", "push", "push", "peek", "pop", "empty"]
        //    ];

        //    return testData;
        //}

        [Time]
        [TestMethod]
        public void TestMethod1()
        {
            var IV = new Problem232ImplementQueueUsingStacks();
            //string[] arr = TestData[0];
            var QueueResult = IV.ImplementQueueUsingStacks();

            QueueResult.Push(1); // queue is: [1]
            QueueResult.Push(2); // queue is: [1, 2] (leftmost is front of the queue)
            var peekedValue = QueueResult.Peek(); // return 1
            var poppedValue = QueueResult.Pop(); // return 1, queue is [2]
            var isEmpty = QueueResult.Empty(); // return false

            Assert.AreEqual(1, peekedValue);
            Assert.AreEqual(1, poppedValue);
            Assert.AreEqual(isEmpty, false);
        }
    }
}