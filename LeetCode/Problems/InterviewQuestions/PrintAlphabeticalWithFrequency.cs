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
using Microsoft.Diagnostics.Runtime.Utilities;

/* 
 * Given a string str containing only both lowercase and uppercase characters. The problem is to print the characters along with their frequency in order of their occurrence and in the given format explained in the examples below and organize the characters in alphabetical order.

For example word:
Hello → input
e1h1l2o1 → output


reverse a string in any language
 Implement a queue

*/

namespace LeetCode.InterviewQuestions
{
    //[MemoryDiagnoser(true)]
    //[SimpleJob(RunStrategy.Throughput, launchCount: 4, warmupCount: 4, iterationCount: 40)]
    /*
     * Benchmarks from solution to solution
     */
    public class PrintAlphabeticalWithFrequency
    {
        // Setup for benchmark testing with data
        public PrintAlphabeticalWithFrequency()
        {
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
            ILogger logger = factory.CreateLogger("Program");
            MethodTimeLogger.Logger = logger;
        }

        /* Original Solution - no optimizations */

        /* Time Complexity: O(n) linear based on input */
        /* Space Complexity: This grows in size dependent on its input it will create a copy 3 times including the result with numbers */
        /* Observations: the space is likely high because of all of the tostring calls. */

        [Time("File Name: PrintAlphabeticalWithFrequency, Input: '{str}'")]
        public string printFrequencyAlphabetically(string str)
        {
            var seenLast = "";
            string strCopy = Alphabetize(str);

            // in C# strings are immutable, and therefore for performance reasons we use string builder
            StringBuilder sbResult = new StringBuilder("", 100);

            int count = 0;

            foreach (var c in strCopy)
            {
                if (seenLast.CompareTo(c.ToString()) != 0)
                {
                    // get the counts of each one and update sbResult
                    count = strCopy.Count(f => string.Equals(f.ToString(), c.ToString(), StringComparison.OrdinalIgnoreCase));
                    seenLast = c.ToString();
                    sbResult.Append(c + count.ToString());
                }
            }

            return sbResult.ToString();
        }

        /* time complexity here is O (n) where n is the length of the string. this gets better with quick sort or merge sort space complexity is O(1) because the copies created are constant */
        private static string Alphabetize(string str)
        {
            var copy = str.ToLower().ToCharArray();
            Array.Sort(copy);
            return new string(copy);
        }
    }
}
