using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Problems;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using Bogus;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using UnitTest.TestData;
using MethodTimer;
using System.Linq;
using static LeetCode.Problems.Problem2AddTwoNumbersUsingLinkedList;

namespace UnitTest
{
    [TestClass]
    public class UnitTestProblem2AddTwoNumbersUsingLinkedList
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

        //public static ListNode[] TestData { get; set; }
        //public static ListNode[] GenerateTestData()
        //{
        //    var l1 = new List<ListNode>();
        //    ListNode[] testData = [
        //        l1
        //    ];

        //    return testData;
        //}

        [Time]
        [TestMethod]
        public void TestMethod1()
        {
            var IV = new Problem2AddTwoNumbersUsingLinkedList();
            var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var QueueResult = IV.AddTwoNumbers(l1, l2);
            

            Assert.AreEqual(7, QueueResult.val);
            Assert.AreEqual(0, QueueResult.next.val);
            Assert.AreEqual(8, QueueResult.next.next.val);
        }

        [Time]
        [TestMethod]
        public void TestMethod2()
        {
            var IV = new Problem2AddTwoNumbersUsingLinkedList();
            var l1 = new ListNode(0);
            var l2 = new ListNode(0);
            var QueueResult = IV.AddTwoNumbers(l1, l2);


            Assert.AreEqual(0, QueueResult.val);
            Assert.AreEqual(null, QueueResult.next);
        }

        [Time]
        [TestMethod]
        public void TestMethod3()
        {
            var IV = new Problem2AddTwoNumbersUsingLinkedList();
            var l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            var l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            var QueueResult = IV.AddTwoNumbers(l1, l2);

            Assert.AreEqual(8, QueueResult.val);
            Assert.AreEqual(9, QueueResult.next.val);
            Assert.AreEqual(9, QueueResult.next.next.next.val);
            Assert.AreEqual(0, QueueResult.next.next.next.next.val);
            Assert.AreEqual(0, QueueResult.next.next.next.next.next.val);
            Assert.AreEqual(0, QueueResult.next.next.next.next.next.next.val);
            Assert.AreEqual(1, QueueResult.next.next.next.next.next.next.next.val);
        }
    }
}