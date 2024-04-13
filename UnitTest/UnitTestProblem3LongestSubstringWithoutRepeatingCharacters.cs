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
    public class UnitTestProblem3LongestSubstringWithoutRepeatingCharacters
    {
        /* Use[AssemblyInitialize] to run code once per assembly, before any test in that assembly runs.
         * Use[ClassInitialize] to run code once per class, before any test in the class where the method is defined.
         * Use[TestInitialize] to run code before each and every test in the class where the method is defined.
         * decorated method must be in a TestClass-decorated class which contains at least one TestMethod-decorated method, otherwise it will not be executed! 
         */

        [TestMethod]
        public void ShouldAccountForDuplicatesAtTheEnd()
        {
            var MSA =  new Problem3LongestSubstringWithoutRepeatingCharacters();
            var s = "abcabcbb";
            var result = MSA.LengthOfLongestSubstring(s);
            var expected = 3;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldAccountForAllDuplicates()
        {
            var MSA = new Problem3LongestSubstringWithoutRepeatingCharacters();
            var s = "bbbbb";
            var result = MSA.LengthOfLongestSubstring(s);
            var expected = 1;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldAccountForDuplicatesMidString()
        {
            var MSA = new Problem3LongestSubstringWithoutRepeatingCharacters();
            var s = "pwwkew";
            var result = MSA.LengthOfLongestSubstring(s);
            var expected = 3;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ShouldAccountForTwoLetters()
        {
            var MSA = new Problem3LongestSubstringWithoutRepeatingCharacters();
            var s = "au";
            var result = MSA.LengthOfLongestSubstring(s);
            var expected = 2;
            Assert.AreEqual(expected, result);
        }
    }
}