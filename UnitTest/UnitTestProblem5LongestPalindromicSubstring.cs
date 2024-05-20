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
    public class UnitTestProblem5LongestPalindromicSubstring
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        [TestMethod]
        public void ShouldFindLongestPalindromicSubstringofOddSizeString()
        {
            var MSA =  new Problem5LongestPalindromicSubstring();
            var s = "babad";
            var result = MSA.LongestPalindrome(s);
            var expected = "bab"; // Explanation: "aba" is also a valid answer.
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldFindLongestPalindromicSubstringofEvenSizeString()
        {
            var MSA = new Problem5LongestPalindromicSubstring();
            var s = "cbbd";
            var result = MSA.LongestPalindrome(s);
            var expected = "bb";
            Assert.AreEqual(expected, result);
        }

    }
}