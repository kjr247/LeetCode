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
    public class UnitTestProblem1431KidsWithTheGreatestNumberOfCandies
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        [TestMethod]
        public void TestMethod1()
        {
            var MSA =  new Problem1431KidsWithTheGreatestNumberOfCandies();
            var candies = new int[5] { 2, 3, 5, 1, 3 };
            var extraCandies = 3;
            var result = MSA.KidsWithCandies(candies, extraCandies);
            var expected = new bool[5] { true, true, true, false, true };
            var falses = result.Count(x => x == false);
            var trues = result.Count(x => x == true);
            Assert.AreEqual(1, falses);
            Assert.AreEqual(4, trues);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var MSA = new Problem1431KidsWithTheGreatestNumberOfCandies();
            var candies = new int[5] { 4, 2, 1, 1, 2 };
            var extraCandies = 1;
            var result = MSA.KidsWithCandies(candies, extraCandies);
            var expected = new bool[5] { true, false, false, false, false };
            var falses = result.Count(x => x == false);
            var trues = result.Count(x => x == true);
            Assert.AreEqual(4, falses);
            Assert.AreEqual(1, trues);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var MSA = new Problem1431KidsWithTheGreatestNumberOfCandies();
            var candies = new int[3] { 12, 1, 12 };
            var extraCandies = 10;
            var result = MSA.KidsWithCandies(candies, extraCandies);
            var expected = new bool[3] { true, false, true };
            var falses = result.Count(x => x == false);
            var trues = result.Count(x => x == true);
            Assert.AreEqual(1, falses);
            Assert.AreEqual(2, trues);
        }
    }
}