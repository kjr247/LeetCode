using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.TestData;
using BenchmarkDotNet.Engines;
using MethodTimer;
using MethodMeasure;
using Microsoft.Extensions.Logging;
using Bogus.Bson;
using Microsoft.Extensions.Primitives;

/* 151. Reverse Words in a String
Medium
Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words. The returned string should only have a single space separating the words. Do not include any extra spaces.



Example 1:

Input: s = "the sky is blue"
Output: "blue is sky the"
Example 2:

Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.
Example 3:

Input: s = "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.
 

Constraints:

1 <= s.length <= 104
s contains English letters (upper-case and lower-case), digits, and spaces ' '.
There is at least one word in s.
 

Follow-up: If the string data type is mutable in your language, can you solve it in-place with O(1) extra space?
*/

/* 
 * Notes on Optimizations
 * 
 * */
namespace LeetCode.Problems
{
    //[MemoryDiagnoser(true)]
    //[SimpleJob(RunStrategy.Throughput, launchCount: 4, warmupCount: 4, iterationCount: 40)]
    /*
     * Benchmarks from solution to solution
     */
    public class Problem151ReverseWordsInAString
    {
        // Setup for benchmark testing with data
        public Problem151ReverseWordsInAString()
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            MethodTimeLogger.Logger = logger;
        }

        /* Original Solution - no optimizations */
        /* LeetCode 50 ms Better than 90% of Users with C# */
        /* LeetCode 42ish MB Better than 35% of Users with C# */
        /* Time Complexity: O(n) */
        /* Space Complexity: O(n) increases linearly with the size of the input */
        /* Observations: the space is likely high because of all of the tostring calls. */
        [Time("File name Problem151ReverseWordsInAString: input: '{s}'")]
        public string ReverseWords(string s)
        {
            string result = "";
            if (s.Length == 0) { return result; } // handle simplest case for perf

            s = s.Trim();
            string[] wordArray = new string[s.Length];
            wordArray = System.Text.RegularExpressions.Regex.Split(s, @"\s+").ToArray();
            Array.Reverse(wordArray);

            return String.Join(" ", wordArray);
        }

    }
}
